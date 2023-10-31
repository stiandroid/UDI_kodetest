using UDI_kodetest.Shared.Models;
using UDI_kodetest.Shared.Models.Entities;

namespace UDI_kodetest.Server.Services.SoknadService
{
    public interface ISoknadService
    {
        Task<ServiceResponse<List<Soknad>>> GetAll();
        Task<ServiceResponse<Soknad>> GetById(Guid id);
        Task<ServiceResponse<Soknad>> GetBySakId(string sakId);
    }
}
