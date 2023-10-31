namespace UDI_kodetest.Server.Services.JsonImportService
{
    public interface IJsonImportService
    {
        Task<ServiceResponse<List<Soknad>>> ReadFromFile();
    }
}
