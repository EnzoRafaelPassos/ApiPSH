using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PshApi.Models
{
    public class Usuario
    {
        public int Id {get; set;}
        public string Username {get; set;}
         public string Email {get; set;}
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public DateTime? DataAcesso { get; set; }



        [NotMapped] // using System.ComponentModel.DataAnnotations.Schema
        public string PasswordString { get; set; }
       
    }
}