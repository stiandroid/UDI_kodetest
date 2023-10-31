namespace UDI_kodetest.Client.Services.SoknadService
{
    public interface ISoknadService
    {
        Task<ServiceResponse<List<Soknad>>> GetAll();
        Task<ServiceResponse<Soknad>> GetById(Guid id);
        Task<ServiceResponse<Soknad>> GetBySakId(string sakId);
        Task<ServiceResponse<List<Soknad>>> GetByPersonData(string personData);
    }
}
