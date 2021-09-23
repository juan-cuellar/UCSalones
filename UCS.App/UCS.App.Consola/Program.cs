using System.Data;
using System.Runtime.InteropServices;
using System;
using UCS.App.Dominio;
using UCS.App.Persistencia;
using System.Collections.Generic;
using System.Linq;
using UCS.App.Persistencia.AppRepositorio;
using System.Security.Principal;
using System.Globalization;

namespace UCS.App.Consola
{
    class Program
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        private static IRepositorioSalones _repoSalones = new RepositorioSalones(new Persistencia.AppContext());

        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());

private static IRepositorioSistemaIngresoPersonal _repoSistemaIngresoPersonal = new RepositorioSistemaIngresoPersonal(new Persistencia.AppContext());
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Este es mi primer sprint");
            Console.WriteLine("\nOperaciones CRUD para Directivo:");
            //AddDirectivo();
            //ActualizarDirectivo();
            //BuscarTodosLosDirectivos();

            Console.WriteLine("\nOperaciones CRUD para Salones:");
            //AddSalones();
            //BuscarSalones(1);
            //ActualizarSalones();
            //BuscarTodosLosSalones();
            //EliminarSalones(1);

            Console.WriteLine("\nOperaciones CRUD para Estudiante:");
            //AddEstudiante();
            //BuscarEstudiante(1);
            //ActualizarEstudiante();
            //BuscarTodosLosEstudiantes();
            //EliminarEstudiante(1);

            Console.WriteLine("\nOperaciones CRUD para Sistema Ingreso Personal:");
            //AddSistemaIngresoPersonal();
            //BuscarSistemaIngresoPersonal(1);
            //ActualizarSistemaIngresoPersonal();
            //EliminarSistemaIngresoPersonal(2);

            Console.WriteLine("\nOperaciones CRUD para Personal Aseo:");
            //AddPersonalAseo();
            //BuscarPersonalAseo(11);
            //ActualizarPersonalAseo();
            BuscarTodosPersonalAseo();
            //EliminarPersonalAseo(11);

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

            Console.WriteLine(directivo.nombre + "\n" + directivo.apellido + "\n Se desempeña en = " + directivo.unidadDesempeña);
            Directivo directivoretornado = _repoDirectivo.AddDirectivo(directivo);
            if (directivoretornado != null)
                Console.WriteLine("Se realizo un nuevo registro en la base de datos:>>" + directivoretornado.id + directivoretornado.EstadoCovid);
        }

        //BuscarDirectivo
        private static void BuscarDirectivo(int idDirectivo)
        {
            var directivo = _repoDirectivo.GetDirectivo(idDirectivo);
            Console.WriteLine(directivo.nombre + " " + directivo.apellido + "\n Unidad: " + directivo.unidadDesempeña);
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
                id = 6,
                nombre = "Cesar",
                apellido = "Bustamante",
                identificacion = 117,
                edad = 42,
                EstadoCovid = EstadoCovid.covidPositivo,
                unidadDesempeña = "Administrativo"

            };
            Directivo directivoretornado = _repoDirectivo.UpdateDirectivo(directivo);
            if (directivoretornado != null)
                Console.WriteLine("Se sustituyo un directivo en la base de datos");

        }

        //GetAllDirectivo
        private static void BuscarTodosLosDirectivos()
        {
            IEnumerable<Directivo> directivos = _repoDirectivo.GetAllDirectivo();
            Console.WriteLine("Se buscaron todos los directivos de la base de datos:>> ");
            foreach (var directivo in directivos)
            {
                Console.WriteLine("    Nombre de directivo:" + directivo.nombre);
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

            Console.WriteLine("Salon ingresado >>:  Salon id: " + salones.id + ", numero de salon: " + salones.numeroSalon + " Maximo Aforo: " + salones.maximoAforo);
            Salones salonesRetornado = _repoSalones.AddSalones(salones);
            if (salonesRetornado != null)
                Console.WriteLine("Se realizo un nuevo registro en la base de datos:>> Salonid: " + salonesRetornado.id + ", Numero de salon: " + salonesRetornado.numeroSalon);
        }


        //BuscarSalones
        private static void BuscarSalones(int idSalones)
        {
            var salones = _repoSalones.GetSalones(idSalones);
            if (salones != null)
            {
                Console.WriteLine("Se buscó un salón en la base de datos:>> Salon numero: " + salones.numeroSalon + " Maximo Aforo" + salones.maximoAforo + " Cantidad Actual de personas: " + salones.cantidadActualPersonas);
            }
            else
            {
                Console.WriteLine("Error: Se buscó un salón en la base de datos y no se encontró resultado:>> id: " + idSalones);
            }

        }

        //DeleteSalones
        private static void EliminarSalones(int idSalones)
        {
            _repoSalones.DeleteSalones(idSalones);
            Console.WriteLine("Se eliminó un registro de la base de datos con id: " + idSalones);
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
            Salones salonesRetornado = _repoSalones.UpdateSalones(salones);
            if (salonesRetornado != null)
            {
                Console.WriteLine("Se sustituyo un salon en la base de datos con id: " + salonesRetornado.id);
            }
            else
            {
                Console.WriteLine("Error al hacer update de salon en la base de datos");
            }

        }


        //GetAllSalones
        private static void BuscarTodosLosSalones()
        {
            IEnumerable<Salones> todosLosSalones = _repoSalones.GetAllSalones();
            Console.WriteLine("Se buscaron todos los salones de la base de datos:>> ");
            foreach (var salones in todosLosSalones)
            {
                Console.WriteLine("    Salon id: " + salones.id + ", numero de Salon: " + salones.numeroSalon + ", cantidad actual de personas: " + salones.cantidadActualPersonas + ", maximo aforo: " + salones.maximoAforo);
            }
            Console.WriteLine("");

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

            Console.WriteLine("Estudiante ingresado >> Estudiante: " + estudiante.nombre + " " + estudiante.apellido);
            Estudiante EstudianteRetornado = _repoEstudiante.AddEstudiante(estudiante);
            if (EstudianteRetornado != null)
                Console.WriteLine("Se realizo un nuevo registro en la base de datos:>> Estudiante Id: " + EstudianteRetornado.id + ", Nombre de Estudiante: " + EstudianteRetornado.nombre);
        }


        //BuscarEstudiante
        private static void BuscarEstudiante(int idEstudiante)
        {
            var estudiante = _repoEstudiante.GetEstudiante(idEstudiante);
            if (estudiante != null)
            {
                Console.WriteLine("Se buscó un estudiante en la base de datos:>> Id estudiante: " + estudiante.id + " Nombre estudiante: " + estudiante.nombre + " Apellido Estudiante: " + estudiante.apellido);
                Console.WriteLine("    Estudiante id: " + estudiante.id + ", nombre:" + estudiante.nombre, ", apellidos: " + estudiante.apellido + ", identificacion: " + estudiante.identificacion + ", edad: " + estudiante.edad + ", estado covid: " + estudiante.EstadoCovid + ", Carrera: " + estudiante.carrera + ", semestre: " + estudiante.Semestre);
            }
            else
            {
                Console.WriteLine("Error: Se buscó un estudiante en la base de datos y no se encontró resultado:>> id: " + idEstudiante);
            }

        }

        //DeleteEstudiante
        private static void EliminarEstudiante(int idEstudiante)
        {
            _repoEstudiante.DeleteEstudiante(idEstudiante);
            Console.WriteLine("Se eliminó un registro de la base de datos: >> Estudiante con id: " + idEstudiante);
        }


        //UpdateEstudiante
        private static void ActualizarEstudiante()
        {
            var estudiante = new Estudiante
            {
                id = 9,
                nombre = "Carlos Andres",
                apellido = "Amado",
                identificacion = 1010,
                edad = 30,
                EstadoCovid = EstadoCovid.covidNegativo,
                carrera = "Lenguas Modernas",
                Semestre = "5"

            };
            Estudiante EstudianteRetornado = _repoEstudiante.UpdateEstudiante(estudiante);
            if (EstudianteRetornado != null)
            {
                Console.WriteLine("Se Actualizó un Estudiante en la base de datos");
                Console.WriteLine("    Estudiante id: " + EstudianteRetornado.id + ", nombre:" + EstudianteRetornado.nombre, ", apellidos: " + EstudianteRetornado.apellido + ", identificacion: " + EstudianteRetornado.identificacion + ", edad: " + EstudianteRetornado.edad + ", estado covid: " + EstudianteRetornado.EstadoCovid + ", Carrera: " + EstudianteRetornado.carrera + ", semestre: " + EstudianteRetornado.Semestre);
            }
            else
            {
                Console.WriteLine("Error al hacer update de estudiante en la base de datos");
            }
        }

        //GetAllEstudiante
        private static void BuscarTodosLosEstudiantes()
        {
            IEnumerable<Estudiante> todosLosEstudiantes = _repoEstudiante.GetAllEstudiante();
            Console.WriteLine("Se buscaron todos los estudiantes de la base de datos:>> ");
            foreach (var estudiante in todosLosEstudiantes)
            {
                Console.WriteLine("    Estudiante id: " + estudiante.id + ", nombre:" + estudiante.nombre, ", apellidos: " + estudiante.apellido + ", identificacion: " + estudiante.identificacion + ", edad: " + estudiante.edad + ", estado covid: " + estudiante.EstadoCovid + ", Carrera: " + estudiante.carrera + ", semestre: " + estudiante.Semestre);
            }
            Console.WriteLine("");

        }

        //AddSistemaIngresoPersonal
        private static void AddSistemaIngresoPersonal()
        {
            var SistemaIngresoPersonal = new SistemaIngresoPersonal
            {
                horayFechaIngreso = DateTime.ParseExact("02/08/2014; 10:00", "dd/MM/yyyy; hh:mm", CultureInfo.InvariantCulture),
                horayFechaSalida = DateTime.ParseExact("02/08/2014; 10:20", "dd/MM/yyyy; hh:mm", CultureInfo.InvariantCulture),
                sede = "Central",
                sintomas = Sintomas.congestion,
                pruebacovid = true,
                autoriza = true,

            };

            Console.WriteLine("SistemaIngresoPersonal ingresado >> SistemaIngresoPersonal: " + SistemaIngresoPersonal.horayFechaIngreso + " " + SistemaIngresoPersonal.horayFechaSalida);
            SistemaIngresoPersonal SistemaIngresoPersonalRetornado = _repoSistemaIngresoPersonal.AddSistemaIngresoPersonal(SistemaIngresoPersonal);
            if (SistemaIngresoPersonalRetornado != null)
            {
                Console.WriteLine("Se realizo un nuevo registro en la base de datos:>> SistemaIngresoPersonal hora y fecha ingreso: " + SistemaIngresoPersonalRetornado.horayFechaIngreso + ", fecha salida Sistema Ingreso Personal: " + SistemaIngresoPersonalRetornado.horayFechaSalida);
            }
            else
            {
                Console.WriteLine("Se presento un error en la adicion: AddSistemaIngresoPersonal");
            }

        }


        //BuscarSistemaIngresoPersonal
        private static void BuscarSistemaIngresoPersonal(int idSistemaIngresoPersonal)
        {
            var SistemaIngresoPersonal = _repoSistemaIngresoPersonal.GetSistemaIngresoPersonal(idSistemaIngresoPersonal);
            if (SistemaIngresoPersonal != null)
            {
                Console.WriteLine("Se buscó un SistemaIngresoPersonal en la base de datos:>> Id SistemaIngresoPersonal: " + SistemaIngresoPersonal.id + " Hora ingreso SistemaIngresoPersonal: " + SistemaIngresoPersonal.horayFechaIngreso + " Hora salida SistemaIngresoPersonal: " + SistemaIngresoPersonal.horayFechaSalida);
            }
            else
            {
                Console.WriteLine("Error: Se buscó un SistemaIngresoPersonal en la base de datos y no se encontró resultado:>> id: " + idSistemaIngresoPersonal);
            }

        }

        //DeleteSistemaIngresoPersonal
        private static void EliminarSistemaIngresoPersonal(int idSistemaIngresoPersonal)
        {
            _repoSistemaIngresoPersonal.DeleteSistemaIngresoPersonal(idSistemaIngresoPersonal);
            Console.WriteLine("Se eliminó un registro de la base de datos: >> Sistema de ingreso con id " + idSistemaIngresoPersonal);
        }


        //UpdateSistemaIngresoPersonal
        private static void ActualizarSistemaIngresoPersonal()
        {
            var SistemaIngresoPersonal = new SistemaIngresoPersonal
            {
                id = 1,
                horayFechaIngreso = DateTime.ParseExact("02/08/2014; 10:00", "dd/MM/yyyy; hh:mm", CultureInfo.InvariantCulture),
                horayFechaSalida = DateTime.ParseExact("02/08/2014; 10:30", "dd/MM/yyyy; hh:mm", CultureInfo.InvariantCulture),
                sede = "Secundaria",
                sintomas = Sintomas.congestion,
                pruebacovid = false,
                autoriza = false,
            };

            SistemaIngresoPersonal SistemaIngresoPersonalretornado = _repoSistemaIngresoPersonal.UpdateSistemaIngresoPersonal(SistemaIngresoPersonal);
            if (SistemaIngresoPersonalretornado != null)
                Console.WriteLine("Se Actualizó el registro en la base de datos");
        }
        
        //AddPersonalAseo
        private static void AddPersonalAseo()
        {
            var PersonalAseo = new PersonalAseo
            {
                nombre = "Yessica",
                apellido = "Muñoz",
                identificacion = 1313,
                edad = 29,
                EstadoCovid = EstadoCovid.covidNegativo,
                turnoServicio =  DateTime.ParseExact("12/06/2014; 06:00", "dd/MM/yyyy; hh:mm", CultureInfo.InvariantCulture),
            };

            Console.WriteLine("Nombre Personal Aseo ingresado >> " + PersonalAseo.nombre + "Turno " + PersonalAseo.turnoServicio);
            PersonalAseo PersonalAseoRetornado = _repoPersonalAseo.AddPersonalAseo(PersonalAseo);
            if (PersonalAseoRetornado != null)
            {
                Console.WriteLine("Se realizo una adicion de personal de aseo en la base de datos:>>  " + PersonalAseoRetornado.nombre + ", Turno Personal: " + PersonalAseoRetornado.turnoServicio);
            }
            else
            {
                Console.WriteLine("Se presento un error en la adicion: AddPersonalAseo");
            }

        }


        //BuscarPersonalAseo
        private static void BuscarPersonalAseo(int idPersonalAseo)
        {
            var PersonalAseo = _repoPersonalAseo.GetPersonalAseo(idPersonalAseo);
            if (PersonalAseo != null)
            {
                Console.WriteLine("Se buscó un PersonalAseo en la base de datos:>> Id PersonalAseo: " + PersonalAseo.id + " Nombre PersonalAseo: " + PersonalAseo.nombre + " apellido Personal Aseo " + PersonalAseo.apellido);
            }
            else
            {
                Console.WriteLine("Error: Se buscó un PersonalAseo en la base de datos y no se encontró resultado:>> id: " + idPersonalAseo);
            }

        }

        //DeletePersonalAseo
        private static void EliminarPersonalAseo(int idPersonalAseo)
        {
            _repoPersonalAseo.DeletePersonalAseo(idPersonalAseo);
            Console.WriteLine("Se eliminó un registro de la base de datos: >> Personal de aseo con id " + idPersonalAseo);
        }


        //UpdatePersonalAseo
        private static void ActualizarPersonalAseo()
        {
            var PersonalAseo = new PersonalAseo
            {
                id = 11,
                nombre = "Silvio",
                apellido = "Marin",
                identificacion = 1212,
                edad = 38,
                EstadoCovid = EstadoCovid.covidPositivo,
                turnoServicio =  DateTime.ParseExact("03/11/2015; 11:00", "dd/MM/yyyy; hh:mm", CultureInfo.InvariantCulture),
   
            };

            PersonalAseo PersonalAseoretornado = _repoPersonalAseo.UpdatePersonalAseo(PersonalAseo);
            if (PersonalAseoretornado != null)
                Console.WriteLine("Se Actualizó el registro en la base de datos");
        }

        //GetAllPersonalAseo
        private static void BuscarTodosPersonalAseo()
        {
            IEnumerable<PersonalAseo> todosLosPersonalAseo = _repoPersonalAseo.GetAllPersonalAseo();
            Console.WriteLine("Se buscaron todos los PersonalAseo de la base de datos:>> ");
            foreach (var PersonalAseo in todosLosPersonalAseo)
            {
                Console.WriteLine("    Id: " + PersonalAseo.id + ", nombre: " + PersonalAseo.nombre + ", Apellido: " + PersonalAseo.apellido + ", Turno" + PersonalAseo.turnoServicio);
            }
            Console.WriteLine("");

        }
    }

}
