using System;
using System.ComponentModel.DataAnnotations;

namespace UCS.App.Dominio
{
    public class Persona
    {
        public int id{get;set;}
        [Required]
        public string nombre{get;set;}
        [Required]
        public string apellido{get;set;}
        [Required]
        public int identificacion{get;set;}
        [Required]
        public int edad{get;set;}
        [Required]
        public EstadoCovid EstadoCovid{get;set;}

        public Sintomas sintomas{get;set;}

    }
}