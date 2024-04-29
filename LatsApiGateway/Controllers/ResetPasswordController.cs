using Microsoft.AspNetCore.Mvc;

namespace LatsApiGateway.Controllers
{
    [Route("api/ResetPassword")]
    [ApiController]
    public class ResetPasswordController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostRestPassword()
        {
            return new JsonResult(new { message = "Reset link sent" });
        }
    }
}
