using Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WorkTracker.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        [AllowAnonymous]
        [Route("api/v1/Login")]
        public IHttpActionResult AuthenticateUser([FromBody] LoginDto loginDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Required input is missing.");
                }
                // var loginManager = new LoginManager();
                // var loginResponse = loginManager.LoginUser(loginDto);
                /*
                if (loginResponse.Error != null)
                {
                    return BadRequest(loginResponse.Error);
                }
                */
                return Ok();
            }

            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
