using Microsoft.AspNetCore.Mvc;

namespace backend_lab_C25063.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hola mundo";
        }
    }
}