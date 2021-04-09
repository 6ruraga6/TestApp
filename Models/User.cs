using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        [Required(ErrorMessage = "Идентификатор пользователя не установлен")]
        public int UserId { get; set; }
        public DateTime DateRegistration { get; set; }
        public DateTime DateLastActivity { get; set; }
    }
}
