using Microsoft.AspNetCore.Mvc;
using UDI_kodetest.Client.Services.SoknadService;

namespace UDI_kodetest.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoknadController : ControllerBase
    {
        private readonly ISoknadService _soknadService;

        public SoknadController(ISoknadService soknadService)
        {
            _soknadService = soknadService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Soknad>>>> GetAll()
            => Ok(await _soknadService.GetAll());

        [HttpGet("id/{id}")]
        public async Task<ActionResult<ServiceResponse<List<Soknad>>>> GetById(Guid id)
            => Ok(await _soknadService.GetById(id));

        [HttpGet("sak/{sakId}")]
        public async Task<ActionResult<ServiceResponse<List<Soknad>>>> GetBySakId(string sakId)
            => Ok(await _soknadService.GetBySakId(sakId));
    }
}
