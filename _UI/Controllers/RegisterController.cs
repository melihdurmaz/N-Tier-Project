using _UI.Models.AppUser.RequestModels;
using BLL.ManagerServices.Abstracts;
using ENTITIES.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : Controller
    {
        IAppUserManager _appUserManager;

        public RegisterController(IAppUserManager appUserManager)
        {
            _appUserManager = appUserManager;
        }

        [HttpPost("RegisterUser")]
        public async Task<IActionResult> RegisterUser([FromForm] UserRegisterrequestModel item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            AppUser appUser = new()
            {
               
               UserName=item.Email,
                Email = item.Email,
                PasswordHash = item.Password
            };

            bool result = await _appUserManager.CreateUserAsync(appUser);
            if (result)
            {
                return Ok("Kullanıcı ekleme basarılı");
            }
            return BadRequest("Kullanıcı ekleme kısmında bir sorunla karşılaşıldı");
        }
    }
}


