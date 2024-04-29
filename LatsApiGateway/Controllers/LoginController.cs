using LatsApiGateway.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LatsApiGateway.Controllers
{
    [Route("api/Login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostLogin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Successful login
                return new JsonResult(new { message = "Login successful" });
            }
            else
            {
                return new JsonResult(new
                {
                    error = "Invalid username and password"
                })
                {
                    StatusCode = 401
                };
            }
        }
       
    }
}
