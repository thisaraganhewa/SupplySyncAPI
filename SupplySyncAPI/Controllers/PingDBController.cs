using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupplySync.Application.Interfaces.Service;

namespace SupplySyncAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingDBController : ControllerBase
    {
        private readonly IHealthService _healthService;

        public PingDBController(IHealthService healthService)
        {
            _healthService = healthService;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var isHealthy = await _healthService.PingAsync();

                return Ok("Database connection is healthy." + isHealthy);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
