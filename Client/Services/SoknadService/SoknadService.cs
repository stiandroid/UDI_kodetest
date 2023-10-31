using System.Net.Http.Json;

namespace UDI_kodetest.Client.Services.SoknadService
{
    public class SoknadService : ISoknadService
    {
        private readonly HttpClient _http;

        public SoknadService(HttpClient http)
        {
            _http = http;
        }

        public async Task<ServiceResponse<List<Soknad>>> GetAll()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Soknad>>>("api/soknad");
            return response;
        }

        public async Task<ServiceResponse<Soknad>> GetById(Guid id)
        {
            var response = await _http
                .GetFromJsonAsync<ServiceResponse<Soknad>>($"api/soknad/id/{id}");
            return response;
        }

        public async Task<ServiceResponse<Soknad>> GetBySakId(string sakId)
        {
            var response = await _http
                .GetFromJsonAsync<ServiceResponse<Soknad>>($"api/soknad/sakId/{sakId}");
            return response;
        }

        public async Task<ServiceResponse<List<Soknad>>> GetByPersonData(string personData)
        {
            var response = await _http
                .GetFromJsonAsync<ServiceResponse<List<Soknad>>>($"api/soknad/person-data/{personData}");
            return response;
        }
    }
}
