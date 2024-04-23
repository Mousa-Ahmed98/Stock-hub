using System.ComponentModel.DataAnnotations;

namespace Stock_hub.DTOS
{
    public class UserRegisterDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
