using Microsoft.AspNetCore.Mvc;
using UDI_kodetest.Server.Services.JsonImportService;

namespace UDI_kodetest.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportController : ControllerBase
    {
        private readonly IJsonImportService _jsonImportService;

        public ImportController(IJsonImportService jsonImportService)
        {
            _jsonImportService = jsonImportService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Soknad>>>> ReadFromFile()
            => Ok(await _jsonImportService.ReadFromFile());
    }
}
