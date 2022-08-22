using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcPersona.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string Dui { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode
= true)]
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        
    }
    public class PersonasDBContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
    }
}