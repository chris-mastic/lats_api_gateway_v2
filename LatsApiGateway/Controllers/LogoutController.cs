using Microsoft.AspNetCore.Mvc;
using LatsApiGateway.ViewModels;

namespace LatsApiGateway.Controllers
{
    [Route("api/Logout")]
    [ApiController]
    public class LogoutController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostLogout(LogoutViewModel model)
        {
            return new JsonResult(new { message = " Logout successful" });
        }
    }
}
