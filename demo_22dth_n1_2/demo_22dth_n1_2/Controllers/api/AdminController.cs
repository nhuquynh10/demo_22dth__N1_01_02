using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo_22dth_n1_2.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public AdminController() { 
            
        }
        [HttpGet("get-product")]
        public ActionResult Index() { 

            return Ok(new {  status = true, message = ""});
        }
        public ActionResult getStudent() {
            return Ok();
        }
    }
}
