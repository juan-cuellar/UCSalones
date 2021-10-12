using System.Security.AccessControl;
using System;

namespace UCS.App.Dominio
{
    public class SistemaIngresoPersonal
    {
        public int id{get;set;}

        public DateTime horayFechaIngreso{get;set;}

        public DateTime horayFechaSalida{get;set;}

        public System.Collections.Generic.List<Persona> persona {get;set;}

        public System.Collections.Generic.List<Sede> sedes{get;set;}

        public System.Collections.Generic.List<Salon> salones{get;set;}

        public Boolean pruebacovid{get;set;}

        public Boolean autoriza{get;set;}
    }
}