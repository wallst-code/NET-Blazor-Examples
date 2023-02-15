using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryptionLibrary.Services
{
    public static class GenerateSalt
    {
        private static readonly string saltValues = @"`~!@#$%^&*()_+-={\}][:;'<>.?/|\~!@#$%^&*()_+-={*\}]$%^[:;'<>.?/|\@#$%^&*[:;'<";
        public static string GetSalt(string seed, int pin)
        {
            return GenerateSaltString(seed, pin);
        }
        private static string GenerateSaltString(string seed, int pin)
        {
            string stringPin = pin.ToString();
            
            StringBuilder sb = new StringBuilder();
            sb.Insert(0, seed);
            if (sb.Length < 12) sb.AppendLine(seed.Substring(2,4));

            for (int i = 0; i < stringPin.Length; i++)
            {
                int x = Convert.ToInt32(stringPin[i] - '0');
                //saltyString += saltValues[x];
                sb.Insert(x, saltValues[x]);               
            }

            if (sb.Length > 30)
            {
                sb.Insert(15, "$");
                sb.Insert(23, ";");
                sb.Insert(30, "@");
            }

            string saltedPassword = sb.ToString();

            return saltedPassword;
        }
    }
}
