using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webappUno.Models
{
    public class Person
    {
        [key]
        public int PersonID { get; set; }

        [Required(ErrorMessage="el nombre es requerido")]
        [Display(Name="nombre completo")]
        [stringlength(100,ErrorMessage="maximo 100 caracteres")]
        public string Name { get; set; }

        [Display(Name="carnet de identidad") ]
        public string Document { get; set; }

    }
}