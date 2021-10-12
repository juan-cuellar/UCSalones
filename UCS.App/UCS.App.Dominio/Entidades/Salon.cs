using System;

namespace UCS.App.Dominio
{
     public class Salon
    {
        public int id{get;set;}

        public int numeroSalon{get;set;}

        public int maximoAforo{get;set;}

        public int numeroDePuesto {get;set;}

        public System.Collections.Generic.List<Estudiante> estudiantes {get;set;}

        public Profesores profesor {get;set;}
    }
}