using System;

namespace UCS.App.Dominio
{
    public class SistemaIngresoPersonal
    {
        public int id{get;set;}

        public DateTime horayFechaIngreso{get;set;}

        public DateTime horayFechaSalida{get;set;}

        public string sede{get;set;}

        public Sintomas sintomas{get;set;}

        public Boolean pruebacovid{get;set;}

        public Boolean autoriza{get;set;}
    }
}