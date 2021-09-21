using System.Collections.Generic;
using UCS.App.Dominio;

namespace UCS.App.Persistencia.AppRepositorio
{
    public interface IRepositorioSalones
    {
        //CRUD
        //GetAllSalones
        IEnumerable<Salones> GetAllSalones();
        //AddSalones
        Salones AddSalones(Salones Salones);
        //UptadateSalones
        Salones UpdateSalones(Salones Salones);
        //DeleteSalones
        void DeleteSalones(int idSalones);
        //GetSalones
        Salones GetSalones(int idSalones);
    }
}