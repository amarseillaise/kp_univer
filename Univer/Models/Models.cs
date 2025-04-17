using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Univer.Models
{
    public class LoginModel
    {
        public string Login {  get; set; }
        public string Password { get; set; }
    }
    public class RegistrModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
    public class ZapolModel
    {
        public string Familiya { get; set; }
        public string Name { get; set; }
        public string Otschestvo { get; set; }
        public string Email { get; set; }
    }
}