using System.Net.Http.Json;

namespace UDI_kodetest.Client.Services.JsonImportService
{
    public class JsonImportService : IJsonImportService
    {
        private readonly HttpClient _http;

        public JsonImportService(HttpClient http)
        {
            _http = http;
        }

        public async Task<ServiceResponse<List<Soknad>>> ReadFromFile()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Soknad>>>("api/import");
            return response;
        }
    }
}
