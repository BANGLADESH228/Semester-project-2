using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemestreWork.Models
{  
    public class RegisterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Campus { get; set; }
        public string Image { get; set; }
        public string CookieId { get; set; }
        public string Years { get; set; }
    }
}
