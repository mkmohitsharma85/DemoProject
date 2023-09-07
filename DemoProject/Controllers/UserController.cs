using BLL.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("RoleAssosiate")]
        public async Task<IActionResult> GetRoleAssosiateUser()
        {
            var result = await _userService.GetAllRoleAssosiateUser();
            return Ok(result);
        }

        [HttpGet("RoleNotAssosiate")]
        public async Task<IActionResult> GetRoleNotAssosiateUser()
        {
            var result = await _userService.GetAllRoleNotAssosiateUser();
            return Ok(result);
        }
    }
}
