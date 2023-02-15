using SimpleEncryptionLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryptionLibrary.Services
{
    public class EncryptionServicev2 : IEncryptionServicev2
    {

        private static readonly byte[] _IV = { 177, 132, 39, 187, 120, 255, 18, 212, 23, 33, 165, 97, 13, 63, 0, 9 };

        private readonly IPasswordModel _password;
        private readonly ISha256Hasher _hasher;
        public EncryptionServicev2(IPasswordModel password, ISha256Hasher hasher)
        {
            _password = password;
            _hasher = hasher;
        }     

        public string GetFinalPassword()
        {
            string _stringPin = _password.Pin.ToString();

            byte[] iV = _IV;
            byte[] key = Encoding.UTF8.GetBytes(_password.KeyPhrase);
            string newPassword = _hasher.GetHash();

            using (Aes myAes = Aes.Create())
            {
                byte[] rawEncryption = EncryptStringToBytes_Aes(newPassword, key, iV);
                string rawStringPassword = Convert.ToBase64String(rawEncryption);
                string finalPassword = GenerateSalt.GetSalt(rawStringPassword, _password.Pin);

                return finalPassword;
            }
        }              

        private byte[] EncryptStringToBytes_Aes(string newPassword, byte[] key, byte[] IV)
        {
            //Check arguments.
            if (newPassword == null || newPassword.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(newPassword);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }
    }
}