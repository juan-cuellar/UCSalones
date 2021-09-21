using System.Runtime.InteropServices;
using System;
using UCS.App.Dominio;
using UCS.App.Persistencia;
using System.Collections.Generic;
using System.Linq;
using UCS.App.Persistencia.AppRepositorio;

namespace UCS.App.Consola
{
    class Program
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        private static IRepositorioSalones _repoSalones = new RepositorioSalones(new Persistencia.AppContext());

        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Este es mi primer sprint");
            Console.WriteLine("\nOperaciones CRUD para Directivo:");
            //AddDirectivo();
            //ActualizarDirectivo();
            
            Console.WriteLine("\nOperaciones CRUD para Salones:");
            AddSalones();
            BuscarSalones(2);
            ActualizarSalones();
            EliminarSalones(1);

            Console.WriteLine("\nOperaciones CRUD para Estudiante:");
            AddEstudiante();
            BuscarEstudiante(1);
            ActualizarEstudiante();
            EliminarEstudiante(1);



        }

        //AddDirectivo
        private static void AddDirectivo()
        {
            var directivo = new Directivo
            {
                nombre = "Giovany",
                apellido = "Pacho",
                identificacion = 1134,
                edad = 29,
                EstadoCovid = EstadoCovid.covidNegativo,
                unidadDesempeña = "Ingenierias"
            };

            Console.WriteLine(directivo.nombre+"\n" + directivo.apellido+"\n Se desempeña en = "+directivo.unidadDesempeña);
            Directivo directivoretornado = _repoDirectivo.AddDirectivo(directivo);
            if (directivoretornado!=null)
            Console.WriteLine("Se realizo un nuevo registro en la base de datos:>>"+directivoretornado.id+directivoretornado.EstadoCovid);
        }
            
        //BuscarDirectivo
        private static void BuscarDirectivo (int idDirectivo)
        {
            var directivo = _repoDirectivo.GetDirectivo(idDirectivo);
            Console.WriteLine(directivo.nombre+" "+directivo.apellido+"\n Unidad: "+directivo.unidadDesempeña);
        }

        //DeleteDirectivo
        private static void EliminarDirectivo(int idDirectivo)
        {
            _repoDirectivo.DeleteDirectivo(idDirectivo);
        }
       
        //UpdateDirectivo
         private static void ActualizarDirectivo()
        {
            var directivo = new Directivo 
            {
               id = 2,
               nombre = "Thomas",
               apellido = "Ramirez",
               identificacion = 110,
               edad = 36,
               EstadoCovid = EstadoCovid.covidPositivo,
               unidadDesempeña = "Derecho"
               
            };
            Directivo directivoretornado =_repoDirectivo.UpdateDirectivo(directivo);                         
            if (directivoretornado!=null)
                Console.WriteLine("Se sustituyo un directivo en la base de datos");
        
        }

        //GetAllDirectivo
          private static void BuscarDirectivo()
        {
            IEnumerable<Directivo> directivos = _repoDirectivo.GetAllDirectivo();
            
            foreach (var directivo in directivos)
            {
                Console.WriteLine(directivo.nombre);
            }
            
        }




        //AddSalones
        private static void AddSalones()
        {
            var salones = new Salones
            {
               numeroSalon = 1,
               maximoAforo = 20,
               cantidadActualPersonas = "18" 
            };

            Console.WriteLine("Salon ingresado >> Salon numero: "+salones.numeroSalon+" Maximo Aforo: "+salones.maximoAforo);
            Salones salonesRetornado = _repoSalones.AddSalones(salones);
            if (salonesRetornado!=null)
            Console.WriteLine("Se realizo un nuevo registro en la base de datos:>> Salonid: "+salonesRetornado.id+", Numero de salon: "+salonesRetornado.numeroSalon);
        }


        //BuscarSalones
        private static void BuscarSalones (int idSalones)
        {
            var salones = _repoSalones.GetSalones(idSalones);
            if(salones!=null){
                Console.WriteLine("Se buscó un salón en la base de datos:>> Salon numero: "+salones.numeroSalon +" Maximo Aforo"+salones.maximoAforo+" Cantidad Actual de personas: "+salones.cantidadActualPersonas);
            }else{
                Console.WriteLine("Error: Se buscó un salón en la base de datos y no se encontró resultado:>> id: "+idSalones);
            }
            
        }

        //DeleteSalones
        private static void EliminarSalones(int idSalones)
        {
            _repoSalones.DeleteSalones(idSalones);
            Console.WriteLine("Se eliminó un registro de la base de datos con id: "+idSalones);
        }


        //UpdateSalones
        private static void ActualizarSalones()
        {
            var salones = new Salones 
            {
                id = 1,
                maximoAforo = 20,
                cantidadActualPersonas = "15",
                numeroSalon = 5
               
            };
            Salones salonesRetornado =_repoSalones.UpdateSalones(salones);                         
            if (salonesRetornado!=null)
                Console.WriteLine("Se sustituyo un salon en la base de datos");
        
        }


        



        /*
        Estudiante
        */

        //AddEstudiante
        private static void AddEstudiante()
        {
            var estudiante = new Estudiante
            {
               nombre = "francisco",
               apellido = "fortuna",
               identificacion = 1111,
               edad = 32,
               EstadoCovid = EstadoCovid.covidNegativo,
               carrera = "Ingenieria de sistemas",
               Semestre = "6"

            };

            Console.WriteLine("Estudiante ingresado >> Estudiante: "+ estudiante.nombre +" "+estudiante.apellido);
            Estudiante EstudianteRetornado = _repoEstudiante.AddEstudiante(estudiante);
            if (EstudianteRetornado!=null)
            Console.WriteLine("Se realizo un nuevo registro en la base de datos:>> Estudiante Id: "+EstudianteRetornado.id+", Nombre de Estudiante: "+EstudianteRetornado.nombre);
        }


        //BuscarEstudiante
        private static void BuscarEstudiante (int idEstudiante)
        {
            var estudiante = _repoEstudiante.GetEstudiante(idEstudiante);
            if(estudiante!=null){
                Console.WriteLine("Se buscó un estudiante en la base de datos:>> Id estudiante: "+estudiante.id +" Nombre estudiante: "+estudiante.nombre+" Apellido Estudiante: "+estudiante.apellido);
            }else{
                Console.WriteLine("Error: Se buscó un estudiante en la base de datos y no se encontró resultado:>> id: "+idEstudiante);
            }
            
        }

        //DeleteEstudiante
        private static void EliminarEstudiante(int idEstudiante)
        {
            _repoEstudiante.DeleteEstudiante(idEstudiante);
            Console.WriteLine("Se eliminó un registro de la base de datos: >> Estudiante con id: "+idEstudiante);
        }


        //UpdateEstudiante
        private static void ActualizarEstudiante()
        {
            var Estudiante = new Estudiante 
            {
                nombre = "francisco",
                apellido = "fortuna",
                identificacion = 1111,
                edad = 33,
                EstadoCovid = EstadoCovid.covidPositivo,
                carrera = "Ingenieria de sistemas",
                Semestre = "7"
               
            };
            Estudiante EstudianteRetornado =_repoEstudiante.UpdateEstudiante(Estudiante);                         
            if (EstudianteRetornado!=null)
                Console.WriteLine("Se Actualizó un Estudiante en la base de datos");
        
        }

        

    }
}
