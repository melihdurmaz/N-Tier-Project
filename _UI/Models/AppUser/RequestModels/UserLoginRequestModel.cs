using System.ComponentModel.DataAnnotations;

namespace _UI.Models.AppUser.RequestModels
{
    public class UserLoginRequestModel
    {
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
