using Microsoft.AspNetCore.Mvc;

namespace LatsApiGateway.Controllers
{
    [Route("api/ForgotPassword")]
    [ApiController]
    public class ForgotPasswordController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostForgotPassword()
        {
            return new JsonResult(new { message = "Reset link sent" });
        }
    }
}
