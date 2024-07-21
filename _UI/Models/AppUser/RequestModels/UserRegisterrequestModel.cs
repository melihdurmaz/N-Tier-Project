using System.ComponentModel.DataAnnotations;

namespace _UI.Models.AppUser.RequestModels
{
    public class UserRegisterrequestModel
    {
        [Required]
       // public string UserName { get; set; }
        public string Password { get; set; }
        
        public string Email { get; set; }
    }
}
