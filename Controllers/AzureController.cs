using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MiFondoAFP.Dto;

namespace MiFondoAFP.Controllers
{
    [Route("api/azure/")]
    public class AzureController : Controller
    {

        [HttpPost]
        public IActionResult CallAzureService([FromBody] AzureParams azureParams)
        {
            var edad = azureParams.edad;
            var unive = azureParams.uni;


            edad += 34;
            



            return Ok(edad);
        }
        
    }
}