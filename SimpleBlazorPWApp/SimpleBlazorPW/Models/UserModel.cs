using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleBlazorPW.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [PasswordPropertyText]
        [Required]
        public string  Password{ get; set; }
    }
}

