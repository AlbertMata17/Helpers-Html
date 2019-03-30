using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Helpers.Models
{
    public class Datos
    {
        [Required(ErrorMessage ="Digita una cédula")]
        public string cedula { get; set; }
        [Required(ErrorMessage = "Digita un nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Digita un apellido")]
        public string apellido { get; set; }
        [Required]
        [Range(16,100,ErrorMessage ="Digita una edad mayor de 15")]
        public int edad { get; set; }
        [Required(ErrorMessage ="agrega un telefono")]
        public string telefono { get; set; }

        [Required(ErrorMessage ="Ingresa un correo Válido")]
        [EmailAddress(ErrorMessage ="Ingresa un correo Válido")]
        public string correo { get; set; }
        [Required]
        public Sexo Sexo { get; set; }
        [Required]
        public string EstadoCivil { get; set; }
       
        public List<Checkbox> Hobbys { get; set; }
       

    }
 
    public enum Sexo
    {
        
        Masculino,
        Femenino,
    }
}