using System;
using System.ComponentModel.DataAnnotations;

namespace UCS.App.Dominio
{
    public class Profesores : Persona
    {
        [Required]
        public string departamento{get;set;}
        [Required]
        public string materia{get;set;}
    }
}