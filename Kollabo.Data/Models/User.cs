using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollabo.Data.Models
{
    public class User : IdentityUser
    {

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string Patronymic { get; set; }
        public string Password { get; set; }
    }
}
