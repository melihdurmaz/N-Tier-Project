using _UI.Models.AppUser.RequestModels;
using ENTITIES.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _UI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpPost("LoginUser")]
        public async Task<IActionResult> LoginUser([FromForm] UserLoginRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            AppUser appUser = new()
            {
                Email = model.Email,
                PasswordHash = model.Password
            };

            var result = await _signInManager.PasswordSignInAsync(appUser.Email, appUser.PasswordHash, false, true);
            if(result.Succeeded)
            {
                var user= await _userManager.FindByNameAsync(model.Email);
                if (user!=null)
                {
                    return RedirectToAction("Privacy", "home");
                }else
                {
                    return BadRequest("Kullanıcı giriş kısmında bir sorunla karşılaşıldı");
                }

            }
            else
            {
                return BadRequest("Kullanıcı result kısmında bir sorunla karşılaşıldı");
            }

            //return View();

        }
    }
}
