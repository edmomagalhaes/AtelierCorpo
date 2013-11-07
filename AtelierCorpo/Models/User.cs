using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtelierCorpo.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string Nane { get; set; }

        public string CPF { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public User Indication { get; set; }

        public string Picture { get; set; }
        
        public string District { get; set; }

        public string ZipCode { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Prof { get; set; }

        public string Email { get; set; }

        public string Facebook { get; set; }

    }
}