using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JwtWebAPI.Controllers
{
    [Route("api/[controller]")]

    public class AuthController : Controller
    {
        public static User user = new User();

        [HttpPost("register")]

        public async Task<ActionResult<User>> Register(UserDto request)
        {
        }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {

        }

    }
}

