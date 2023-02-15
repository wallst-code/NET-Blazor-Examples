using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryptionLibrary.Models
{
    public class PasswordModel : IPasswordModel
    {
        public string SeedPhrase { get; set; }
        public string KeyPhrase { get; set; }
        public int Pin { get; set; }
        public string SiteName { get; set; }
    }
}
