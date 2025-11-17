using InsurancePremiumCalculator.Models;
using InsurancePremiumCalculator.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsurancePremiumCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PremiumAPIController : ControllerBase
    {
        private readonly IPremiumCalculatorService _service;

        public PremiumAPIController(IPremiumCalculatorService service)
        {
            _service = service;
        }

        [HttpPost("Calculate")]
        public IActionResult Calculate([FromBody] PremiumCalculationRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _service.Calculate(request);

            return Ok(result);
        }
    }
}
