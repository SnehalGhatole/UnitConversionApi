using Microsoft.AspNetCore.Mvc;
using UnitConversionApi.Services;

namespace UnitConversionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionController : ControllerBase
    {
        private readonly IConversionService _conversionService;

        public ConversionController(IConversionService conversionService)
        {
            _conversionService = conversionService;
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("API Working");
        }

        [HttpGet("convert")]
        public IActionResult Convert(double value,string from,string to)
        {
            try
            {
                var result = _conversionService.Convert(value,from,to);

                return Ok(new
                {
                    OriginalValue = value,
                    From = from,
                    To = to,
                    ConvertedValue = result
                });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}