using Newtonsoft.Json;

namespace UDI_kodetest.Server.Services.JsonImportService
{
    public class JsonImportService : IJsonImportService
    {
        private readonly DataContext _context;

        public JsonImportService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Soknad>>> ReadFromFile()
        {
            var response = new ServiceResponse<List<Soknad>>();

            try 
            {
                // Lese inn og deserialisere JSON data
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "../Data", "testdata.json");
                string jsonData = File.ReadAllText(filePath);

                var data = JsonConvert.DeserializeObject<List<Soknad>>(jsonData);

                if (data != null)
                {
                    foreach (var item in data)
                    {
                        if (item.Kontakt != null)
                        {
                            _context.Personer.Add(item.Kontakt);
                        }
                        if (item.Soker != null)
                        {
                            _context.Personer.Add(item.Soker);
                        }
                        if (item.Vedtak != null)
                        {
                            _context.Vedtak.Add(item.Vedtak);
                        }
                        _context.Soknader.Add(item);
                    }
                }

                await _context.SaveChangesAsync();

                response.Data = data;
                response.Success = data != null;
                response.Message = $"Leste inn {data?.Count??0} søknader fra JSON-filen og lagret dem i databasen.";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = $"Feil under lesing av data fra fil: {ex.Message}";

                // Ytterligere logging kan skje her
            }

            return response;
        }
    }
}
