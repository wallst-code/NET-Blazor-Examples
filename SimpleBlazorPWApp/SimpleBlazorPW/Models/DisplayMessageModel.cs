using System.ComponentModel.DataAnnotations;

namespace SimpleBlazorPW.Models
{
    public class DisplayMessageModel
    {
        // add guid and datetime - how to automtically init? 

        [Required]
        public string Message { get; set; }

        [Required]
        [StringLength(16, ErrorMessage = "Message Key must be exactly 16 characters in length.")]
        public string MessageKey { get; set; }

    }
}
