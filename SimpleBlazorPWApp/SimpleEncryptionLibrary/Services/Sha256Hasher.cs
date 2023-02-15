using SimpleEncryptionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryptionLibrary.Services
{
    public class Sha256Hasher : ISha256Hasher
    {
        private readonly IPasswordModel _password;
        private int iteration = 5;

        public Sha256Hasher(IPasswordModel password)
        {
            _password = password;
        }

        public string GetHash()
        {
            string hashedPassword = ComputeHash().Substring(0, 20);
            
            return hashedPassword;
        }

        private string ComputeHash()
        {
            if (iteration <= 0) return _password.SeedPhrase;

            string concatSeedToSiteName = string.Concat(_password.SeedPhrase, _password.SiteName);

            using var sha256 = SHA256.Create();
            var passwordSaltPepper = $"{GenerateSalt.GetSalt(concatSeedToSiteName, _password.Pin)}";
            var byteValue = Encoding.UTF8.GetBytes(passwordSaltPepper);
            var byteHash = sha256.ComputeHash(byteValue);
            var hash = Convert.ToBase64String(byteHash);
            string saltedHash = GenerateSalt.GetSalt(hash, _password.Pin);

            return saltedHash;
        }                       
    }
}
