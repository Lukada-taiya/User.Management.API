using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using User.Management.API.Models;
using User.Management.API.Models.Authentication.Signup;

namespace User.Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AuthController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        [HttpPost]
         public async Task<IActionResult> Register([FromBody] RegisterUser user, string role)
        {
            var userExists = await _userManager.FindByEmailAsync(user.Email);
            if(userExists != null )
            {
                return StatusCode(StatusCodes.Status403Forbidden, new Response
                {
                    Status = "Error",
                    Message = "User already exists!"
                });
            }

            IdentityUser newUser = new() { Email = user.Email,
            SecurityStamp = Guid.NewGuid().ToString(),
            UserName = user.Username
            };

            var result = await _userManager.CreateAsync(newUser, user.Password);

            if(result.Succeeded)
            {
                return StatusCode(StatusCodes.Status201Created, new Response
                {
                    Status = "Success",
                    Message = "User created sucessfully"
                });
            }

            return StatusCode(StatusCodes.Status500InternalServerError, new Response
            {
                Status = "Error",
                Message = "Failed to create User"
            });
        }
    }
}
