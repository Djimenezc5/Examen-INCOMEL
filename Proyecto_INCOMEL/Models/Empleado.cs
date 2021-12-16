using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_INCOMEL.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "DPI")]
        public int DPI { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required]
        [Display(Name = "Cantidad de hijos")]
        public int CantidadHijos { get; set; }
        [Required]
        [Display(Name = "Salario base")]
        public double SalarioBase { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaCreacion { get; set; }
    }

    //public class INCOMELEDBContext : DbContext 
    //{ 
    //    public DbSet<Usuario1> Usuarios { get; set;}
    //    public DbSet<Empleado> Empleados { get; set; }
    //}
}