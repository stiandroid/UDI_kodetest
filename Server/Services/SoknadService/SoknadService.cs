namespace UDI_kodetest.Server.Services.SoknadService
{
    public class SoknadService : ISoknadService
    {
        private readonly DataContext _context;

        public SoknadService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Soknad>>> GetAll()
        {
            List<Soknad>? soknader = await _context.Soknader
                .Include(s => s.Soker)
                .Include(k => k.Kontakt)
                .Include(v => v.Vedtak)
                .ToListAsync();
            var response = new ServiceResponse<List<Soknad>>()
            {
                Data = soknader,
                Success = soknader != null,
                Message = soknader != null
                    ? ""
                    : "Fant ingen søknader."
            };
            return response;
        }

        public async Task<ServiceResponse<Soknad>> GetById(Guid id)
        {
            Soknad? soknad = await _context.Soknader.FindAsync(id);
            var response = new ServiceResponse<Soknad>()
            {
                Data = soknad,
                Success = soknad != null,
                Message = soknad != null
                    ? ""
                    : $"Fant ikke søknad med id '{id}'."
            };
            return response;
        }

        public async Task<ServiceResponse<Soknad>> GetBySakId(string sakId)
        {
            Soknad? soknad = await _context.Soknader
                .FirstOrDefaultAsync(s => s.Sakid == sakId);
            var response = new ServiceResponse<Soknad>()
            {
                Data = soknad,
                Success = soknad != null,
                Message = soknad != null
                    ? ""
                    : $"Fant ikke søknad med sakid '{sakId}'."
            };
            return response;
        }
    }
}
