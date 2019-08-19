using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LuckyPaw.Models
{
    public class LoginModel
    {
        [Key]
        public int LoginID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

    }
}