using Microsoft.AspNetCore.Identity;
using SimpleEncryptionLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace SimpleBlazorPW.Models
{
    public class DisplayPasswordModel : IPasswordModel
    {
        [Required]
        [MaxLength(30, ErrorMessage = "Maximum seed phrase length is 30 characters.")]
        [MinLength(10, ErrorMessage = "Minimum seed phrase length is 10 characters.")]
        public string SeedPhrase { get; set; }

        [Required]        
        [StringLength(16, ErrorMessage = "Key phrase must be exactly 16 characters in length.")]
        public string KeyPhrase { get; set; }

        [Required]
        [RegularExpression(@"^[1-9][0-9][0-9][0-9]", ErrorMessage = "Pin cannot begin with a 0 and must be 4-digits in length.")]
        // regex of some sort is needed
        public int Pin { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Site name must be at least 3 characters in length.")]
        public string SiteName { get; set; }
    }
}
