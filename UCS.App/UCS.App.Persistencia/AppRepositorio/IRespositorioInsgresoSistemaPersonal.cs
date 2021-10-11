using System.Collections;
using System.Collections.Generic;
using UCS.App.Dominio;

namespace UCS.App.Persistencia.AppRepositorio
{
    public interface IRepositorioSistemaIngresoPersonal
    {
        
        IEnumerable<SistemaIngresoPersonal> GetAllSistemaIngresoPersonal();
        //AddSistemaIngresoPersonal
        SistemaIngresoPersonal AddSistemaIngresoPersonal(SistemaIngresoPersonal SistemaIngresoPersonal);
        //UptadateSistemaIngresoPersonal
        SistemaIngresoPersonal UpdateSistemaIngresoPersonal(SistemaIngresoPersonal SistemaIngresoPersonal);
        //DeleteSistemaIngresoPersonal
        void DeleteSistemaIngresoPersonal (int idSistemaIngresoPersonal);
        //GetSistemaIngresoPersonal
        SistemaIngresoPersonal GetSistemaIngresoPersonal(int idSistemaIngresoPersonal);

        //GetSistemaIngresoPersonalConSede
        IEnumerable<SistemaIngresoPersonal> GetSistemaIngresoPersonalConSede(NombreFacultad nombreFacultad);
        //GetSistemaIngresoPesonalConPersona
        IEnumerable<SistemaIngresoPersonal> GetSistemaIngresoPesonalConPersona(EstadoCovid EstadoCovid);
        //GetSistemaIngresoPersonalConSedeYPersona 

        //IEnumerable<SistemaIngresoPersonal> GetSistemaIngresoPersonalConSedeYPersona(NombreFacultad nombreFacultad,EstadoCovid EstadoCovid);
        
    }

}