using Microsoft.AspNetCore.Mvc;

namespace NET.KeyVaultRef.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KeyVaultReader : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public KeyVaultReader(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet(Name = "Sample")]
        public string Get() => _configuration.GetValue<string>("SampleSecret");
    }
}