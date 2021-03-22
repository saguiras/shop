using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Models
{
    public class User
    {
        public int User_id { get; set; }
        public string User_FirstName { get; set; }
        public string User_LastName { get; set; }
        public string User_name { get; set; }
        public string User_PasswordHash { get; set; }
    }
}
