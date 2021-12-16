using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace Proyecto_INCOMEL.Models
{
    public class Login
    {
        [Required]
        [Display(Name = "Correo electrónico")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Contra { get; set; }

        INCOMELEDBContext db = new INCOMELEDBContext();

        public bool Autenticar()
        {
            return db.Usuarios
                .Where(u => u.Email == this.Email
                && u.Contra == this.Contra)
                .FirstOrDefault() != null;
        }
    }
}