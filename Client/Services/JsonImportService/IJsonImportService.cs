namespace UDI_kodetest.Client.Services.JsonImportService
{
    public interface IJsonImportService
    {
        Task<ServiceResponse<List<Soknad>>> ReadFromFile();
    }
}
