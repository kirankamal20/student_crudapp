using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using student_crudapp.models;
using System.Net;

namespace student_crudapp.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class logincontroller : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
         
        public IActionResult Login(LoginModel data)
        {
            if (data.Username == "Kiran" && data.Password == "Kiran@123")
            {
                return Ok(new { message = "Logged-in Success" });
            }
            else
            {
                return BadRequest(new { message = "Login Failedfff" });
            }
        }

    }
}
