using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryptionLibrary.Models
{
    public class MessageModel
    {
        public string Message { get; set; }

        public string MessageKey { get; set; }
    }
}
