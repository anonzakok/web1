using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class Contact
    {
        public string Name { get; set; }

        public string Email { get; set; }
        [EmailAddress]
        public string Subject { get; set; }
        public string Message { get; set; }
        public string SendCopy { get; set; }
    }
}
