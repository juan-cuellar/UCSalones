using System.Reflection.Metadata;
//using System.Data;
//using System.Runtime.InteropServices;
using System;
using UCS.App.Dominio;
using UCS.App.Persistencia;
using System.Collections.Generic;
using System.Linq;
using UCS.App.Persistencia.AppRepositorio;
//using System.Security.Principal;
using System.Globalization;

namespace UCS.App.Consola
{
    class Program
    {
        private static IRepositorioDirectivo _repoDirectivo = new RepositorioDirectivo(new Persistencia.AppContext());
        private static IRepositorioSalon _repoSalon = new RepositorioSalon(new Persistencia.AppContext());

        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());

        private static IRepositorioSistemaIngresoPersonal _repoSistemaIngresoPersonal = new RepositorioSistemaIngresoPersonal(new Persistencia.AppContext());
        private static IRepositorioPersonalAseo _repoPersonalAseo = new RepositorioPersonalAseo(new Persistencia.AppContext());

        private static IRepositorioProfesores _repoProfesores = new RepositorioProfesores(new Persistencia.AppContext());

        private static IRepositorioSede _repoSede = new RepositorioSede(new Persistencia.AppContext());

        private static IRepositorioUniversidad _repoUniversidad = new RepositorioUniversidad(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            //Console.WriteLine("Este es mi primer sprint\n");
            //Console.WriteLine("\nOperaciones CRUD para Directivo:");
            // AddDirectivo();
            // BuscarDirectivo(1);
            // ActualizarDirectivo();
            // BuscarTodosLosDirectivos();
            // EliminarDirectivo(1);

            //Console.WriteLine("\nOperaciones CRUD para Salones:");
            // AddSalones();
            // BuscarSalones(1);
            // ActualizarSalones();
            // BuscarTodosLosSalones();
            // EliminarSalones(1);

            //Console.WriteLine("\nOperaciones CRUD para Estudiante:");
            // AddEstudiante();
            // BuscarEstudiante(1);
            // ActualizarEstudiante();
            // BuscarTodosLosEstudiantes();
            // EliminarEstudiante(1);

            //Console.WriteLine("\nOperaciones CRUD para Sistema Ingreso Personal:");
            // AddSistemaIngresoPersonal();
            // BuscarSistemaIngresoPersonal(1);
            // ActualizarSistemaIngresoPersonal();
            // EliminarSistemaIngresoPersonal(2);

            //Console.WriteLine("\nOperaciones CRUD para Personal Aseo:");
            // AddPersonalAseo();
            // BuscarPersonalAseo(1);
            // ActualizarPersonalAseo();
            // BuscarTodosPersonalAseo();
            // EliminarPersonalAseo(11);

            //Console.WriteLine("\nOperaciones CRUD para Profesores:");
            // AddProfesores();
            // BuscarProfesor(1);
            // ActualizarProfesores();
            // BuscarProfesores();
            // EliminarProfesores(1);

            //Console.WriteLine("\nOperaciones CRUD para Sedes:");
            // AddSedes();
            // BuscarSede(1);
            // ActualizarSedes();
            // BuscarSedes();
            // EliminarSedes(1);

            //Console.WriteLine("\nOperaciones CRUD para Universidad:");
            // AddUniversidad();
            // BuscarUniversidad(1);
            // ActualizarUniversidad();
            // BuscarUniversidades();
            // EliminarUniversidad(2);

            //AdicionarSistemaIngresoEstudianteConSede();


            Profesores profesor1 = new Profesores{nombre="Raul",apellido="Mesa",identificacion=230,edad=34,EstadoCovid=EstadoCovid.covidNegativo,departamento="Ingeniería",materia="Ingeniería Sistemas"};

            AddSalonConProfesor(profesor1);


            // IEnumerable<SistemaIngresoPersonal> sistemaIngresosSede = _repoSistemaIngresoPersonal.GetSistemaIngresoPersonalConSede(NombreFacultad.ingenieria);
            // foreach (var sistema in sistemaIngresosSede)
            // {
            //     Console.WriteLine(sistema.id);
            // }
            // Console.WriteLine("Fin del programa");

            // IEnumerable<SistemaIngresoPersonal> sistemaIngresosPersona = _repoSistemaIngresoPersonal.GetSistemaIngresoPesonalConPersona(EstadoCovid.covidNegativo);
            // foreach (var sistema in sistemaIngresosPersona)
            // {
            //     Console.WriteLine(sistema.id);
            // }
            // Console.WriteLine("Fin del programa");

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
            {
                Console.WriteLine("Se realizo un nuevo registro en la base de datos:>> ID directivo: " + directivoretornado.id + ", estado covid: " + directivoretornado.EstadoCovid);
            }
            else
            {
                Console.WriteLine("Error: No se pudo agregar el directivo: " + directivo.nombre);
            }
        }

        //BuscarDirectivo
        private static void BuscarDirectivo(int idDirectivo)
        {
            var directivo = _repoDirectivo.GetDirectivo(idDirectivo);
            if (directivo != null)
            {
                Console.WriteLine(directivo.nombre + " " + directivo.apellido + "\n Unidad: " + directivo.unidadDesempeña);
            }
            else
            {
                Console.WriteLine("Error: Se ha intentado buscar un directivo con id: " + idDirectivo);
            }
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
        private static void AddSalon()
        {
            var salon = new Salon
            {
                numeroSalon = 1,
                maximoAforo = 20,
                numeroDePuesto = 18
            };

            Console.WriteLine("Salon ingresado >>:  Salon id: " + salon.id + ", numero de salon: " + salon.numeroSalon + " Maximo Aforo: " + salon.maximoAforo);
            Salon salonRetornado = _repoSalon.AddSalon(salon);
            if (salonRetornado != null)
                Console.WriteLine("Se realizo un nuevo registro en la base de datos:>> Salonid: " + salonRetornado.id + ", Numero de salon: " + salonRetornado.numeroSalon);
        }


        //BuscarSalon
        private static void BuscarSalon(int idSalon)
        {
            var salon = _repoSalon.GetSalon(idSalon);
            if (salon != null)
            {
                Console.WriteLine("Se buscó un salón en la base de datos:>> Salon numero: " + salon.numeroSalon + " Maximo Aforo" + salon.maximoAforo + " Cantidad Actual de personas: " + salon.numeroDePuesto);
            }
            else
            {
                Console.WriteLine("Error: Se buscó un salón en la base de datos y no se encontró resultado:>> id: " + idSalon);
            }

        }

        //DeleteSalon
        private static void EliminarSalon(int idSalon)
        {
            _repoSalon.DeleteSalon(idSalon);
            Console.WriteLine("Se eliminó un registro de la base de datos con id: " + idSalon);
        }


        //UpdateSalon
        private static void ActualizarSalon()
        {
            var salon = new Salon
            {
                id = 1,
                maximoAforo = 20,
                numeroDePuesto = 15,
                numeroSalon = 5

            };
            Salon salonRetornado = _repoSalon.UpdateSalon(salon);
            if (salonRetornado != null)
            {
                Console.WriteLine("Se sustituyo un salon en la base de datos con id: " + salonRetornado.id);
            }
            else
            {
                Console.WriteLine("Error al hacer update de salon en la base de datos");
            }

        }


        //GetAllSalon
        private static void BuscarTodosLosSalon()
        {
            IEnumerable<Salon> todosLosSalon = _repoSalon.GetAllSalones();
            Console.WriteLine("Se buscaron todos los salon de la base de datos:>> ");
            foreach (var salon in todosLosSalon)
            {
                Console.WriteLine("    Salon id: " + salon.id + ", numero de Salon: " + salon.numeroSalon + ", cantidad actual de personas: " + salon.numeroDePuesto + ", maximo aforo: " + salon.maximoAforo);
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
        private static SistemaIngresoPersonal AddSistemaIngresoPersonal()
        {
            var SistemaIngresoPersonal = new SistemaIngresoPersonal
            {
                horayFechaIngreso = DateTime.ParseExact("02/08/2014; 10:00", "dd/MM/yyyy; hh:mm", CultureInfo.InvariantCulture),
                horayFechaSalida = DateTime.ParseExact("02/08/2014; 10:20", "dd/MM/yyyy; hh:mm", CultureInfo.InvariantCulture),
                persona = null,
                sedes = null,
                salones = null,
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
            return SistemaIngresoPersonalRetornado;

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
                sedes = null,
            
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
                turnoServicio = DateTime.ParseExact("12/06/2014; 06:00", "dd/MM/yyyy; hh:mm", CultureInfo.InvariantCulture),
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
                turnoServicio = DateTime.ParseExact("03/11/2015; 11:00", "dd/MM/yyyy; hh:mm", CultureInfo.InvariantCulture),

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

        /*

        Profesores

        */
        //AddProfesores().
        private static void AddProfesores()
        {
            var profesores = new Profesores
            {
                nombre = "Alberto",
                apellido = "Manzano",
                identificacion = 1001,
                edad = 40,
                EstadoCovid = EstadoCovid.covidNegativo,
                departamento = "Ingeniería",
                materia = "Sistemas"
            };
            Console.WriteLine("Nombre Profesor: " + profesores.nombre + ", Apellido = " + profesores.apellido);
            Profesores profesores_retornado = _repoProfesores.AddProfesores(profesores);
            Console.WriteLine("Se registró un profesor en la base de datos");
        }

        //GetProfesor
        private static void BuscarProfesor(int idProfesores)
        {
            var profesores = _repoProfesores.GetProfesores(idProfesores);
            if (profesores != null)
            {
                Console.WriteLine(profesores.nombre + " " + profesores.apellido + "\n Departamento: " + profesores.departamento);
            }
            else
            {
                Console.WriteLine("Error: Se ha intentado buscar un profesor con id: " + idProfesores);
            }
        }
        //DeleteProfesores
        private static void EliminarProfesores(int idProfesores)
        {
            _repoProfesores.DeleteProfesores(idProfesores);
        }

        //UpdateProfesores
        private static void ActualizarProfesores()
        {
            var profesores = new Profesores
            {
                id = 1,
                nombre = "Alberto",
                apellido = "Manzano",
                identificacion = 1001,
                edad = 40,
                EstadoCovid = EstadoCovid.covidNegativo,
                departamento = "Ingeniería",
                materia = "Sistemas"
            };
            Profesores profesores_retornado = _repoProfesores.UpdateProfesores(profesores);
            if (profesores_retornado != null)
            {
                Console.WriteLine("Se actualizó un profesor en la base de datos");
            }
            else
            {
                Console.WriteLine("Error: Se intentó actualizar un profesor con id: " + profesores.id);
            }
        }
        //GetAllProfesores
        private static void BuscarProfesores()
        {
            IEnumerable<Profesores> profesores = _repoProfesores.GetAllProfesores();
            foreach (var profesor in profesores)
            {
                Console.WriteLine(profesor.nombre);
            }
        }


        /*
         Sedes
        */
        //AddSedes().
        private static void AddSede()
        {
            var sedes = new Sede
            {
                nombreFacultad = NombreFacultad.ingenieria,
                salonesDisponibles = 4
            };
            Console.WriteLine("Nombre de la Sede: " + sedes.nombreFacultad + ", Salon Disponibles = " + sedes.salonesDisponibles);
            Sede sedes_retornado = _repoSede.AddSede(sedes);
            Console.WriteLine("Se registró Sede en la base de datos");
        }

        //GetSedes
        private static void BuscarSede(int idSedes)
        {
            var sedes = _repoSede.GetSede(idSedes);
            if (sedes != null)
            {
                Console.WriteLine("Se ha buscado una sede con id:" + sedes.id + ", nombre facultad: " + sedes.nombreFacultad);
            }
            else
            {
                Console.WriteLine("Error: se ha intentado buscar sede con id: " + idSedes);
            }
        }
        //DeleteSedes
        private static void EliminarSedes(int idSedes)
        {
            _repoSede.DeleteSede(idSedes);
        }

        //UpdateSedes
        private static void ActualizarSedes()
        {
            var sedes = new Sede
            {
                id = 1,
                nombreFacultad = NombreFacultad.artesyhumanidades,
                salonesDisponibles = 5
            };
            Sede sedes_retornado = _repoSede.UpdateSede(sedes);
            if (sedes_retornado != null)
            {
                Console.WriteLine("Se actualizó una Sede en la base de datos");
            }
            else
            {
                Console.WriteLine("Error: No se pudo actualizar la sede con id: " + sedes.id);
            }

        }
        //GetAllSedes
        private static void BuscarSedes()
        {
            IEnumerable<Sede> sedes = _repoSede.GetAllSedes();
            foreach (var sede in sedes)
            {
                Console.WriteLine(sede.nombreFacultad);
            }
        }

        //AddUniversidad
        private static void AddUniversidad()
        {
            var Universidad = new Universidad
            {
                nit = 123456789,
                direccion = "Avenida Siempre Viva 123 - Sprinfield"


            };

            Console.WriteLine("Universidad ingresado >>:  Universidad id: " + Universidad.id + ", Nit: " + Universidad.nit + ", Dirección: " + Universidad.direccion);
            Universidad UniversidadRetornado = _repoUniversidad.AddUniversidad(Universidad);
            if (UniversidadRetornado != null)
                Console.WriteLine("Se realizo un nuevo registro en la base de datos:>> UniversidadId: " + UniversidadRetornado.id + ", Universidad Nit: " + UniversidadRetornado.nit);
        }


        //BuscarUniversidad
        private static void BuscarUniversidad(int idUniversidad)
        {
            var Universidad = _repoUniversidad.GetUniversidad(idUniversidad);
            if (Universidad != null)
            {
                Console.WriteLine("Se buscó una universidad en la base de datos:>> Universidad Nit: " + Universidad.nit);
            }
            else
            {
                Console.WriteLine("Error: Se buscó una universidad en la base de datos y no se encontró resultado:>> id: " + idUniversidad);
            }
        }

        private static void EliminarUniversidad(int idUniversidad)
        {
            _repoUniversidad.DeleteUniversidad(idUniversidad);
            Console.WriteLine("Se eliminó un registro de la base de datos con id: " + idUniversidad);
        }


        //UpdateUniversidad
        private static void ActualizarUniversidad()
        {
            var Universidad = new Universidad
            {
                id = 1,
                nit = 999999999,
                direccion = "Avenida Siempre Viva 000 - Sprinfield"

            };
            Universidad UniversidadRetornado = _repoUniversidad.UpdateUniversidad(Universidad);
            if (UniversidadRetornado != null)
            {
                Console.WriteLine("Se sustituyo una Universidad en la base de datos con id: " + UniversidadRetornado.id);
            }
            else
            {
                Console.WriteLine("Error al hacer update de Universidad en la base de datos");
            }

        }


        //GetAllUniversidad
        private static void BuscarUniversidades()
        {
            IEnumerable<Universidad> Universidades = _repoUniversidad.GetAllUniversidad();
            Console.WriteLine("Se buscaron todos los Universidad de la base de datos:>> ");
            foreach (var Universidad in Universidades)
            {
                Console.WriteLine("    Universidad id: " + Universidad.id + ", Universidad Nit: " + Universidad.nit + ", Universidad Dirección:" + Universidad.direccion);
            }
            Console.WriteLine("");

        }

//======================================================
//======================================================
//NUEVAS FUNCIONES QUE SE RELACIONAN ENTRE LAS ENTIDADES
//======================================================
//======================================================

         private static SistemaIngresoPersonal AdicionarSistemaIngresoEstudianteConSede()
        {
           
         var SistemaIngresoPersonal = new SistemaIngresoPersonal
            {
                horayFechaIngreso = DateTime.ParseExact("02/08/2014; 10:00", "dd/MM/yyyy; hh:mm", CultureInfo.InvariantCulture),
                horayFechaSalida = DateTime.ParseExact("02/08/2014; 10:20", "dd/MM/yyyy; hh:mm", CultureInfo.InvariantCulture),
                persona =new List<Persona> {
	                new Estudiante{
		                nombre = "Monica",apellido="Az",identificacion=101,edad=30,EstadoCovid=EstadoCovid.covidPositivo, carrera="Ingeniería",Semestre="3"
	                }
                },
                sedes =new List<Sede>{
                    new Sede{
                        nombreFacultad=NombreFacultad.cienciasexactasynaturales,
                        salonesDisponibles=6
                    },
                     new Sede{
                        nombreFacultad=NombreFacultad.ingenieria,
                        salonesDisponibles=4
                    },
                     new Sede{
                        nombreFacultad=NombreFacultad.cienciasjuridicasysociales,
                        salonesDisponibles=5
                    }
                },
                salones = new List<Salon>{
                    new Salon{
                        numeroSalon=1,maximoAforo=10,numeroDePuesto=4 
                    },
                    new Salon{
                        numeroSalon=2,maximoAforo=10,numeroDePuesto=5 
                    },
                    new Salon{
                        numeroSalon=3,maximoAforo=10,numeroDePuesto=6 
                    }
                },
                pruebacovid = true,
                autoriza = false,

            };

            Console.WriteLine("SistemaIngresoPersonal ingresado >> SistemaIngresoPersonal: " + SistemaIngresoPersonal.persona + " " + SistemaIngresoPersonal.sedes);
            SistemaIngresoPersonal SistemaIngresoPersonalRetornado = _repoSistemaIngresoPersonal.AddSistemaIngresoPersonal(SistemaIngresoPersonal);
            if (SistemaIngresoPersonalRetornado != null)
            {
                Console.WriteLine("Se realizo un nuevo registro en la base de datos:>> SistemaIngresoPersonal hora y fecha ingreso: " + SistemaIngresoPersonalRetornado.horayFechaIngreso + ", fecha salida Sistema Ingreso Personal: " + SistemaIngresoPersonalRetornado.horayFechaSalida);
            }
            else
            {
                Console.WriteLine("Se presento un error en la adicion: AddSistemaIngresoPersonal");
            }
            return SistemaIngresoPersonalRetornado;
            
        }


        private static void AddSalonConProfesor(Profesores profesor)
        {
            var salon = new Salon
            {
                numeroSalon=10,
                maximoAforo=10,
                numeroDePuesto=12,
                estudiantes=null,
                profesor=profesor

            };
             Console.WriteLine(salon.numeroSalon+" "+ salon.profesor);
            Salon salon_retornado = _repoSalon.AddSalon(salon);
            if (salon_retornado!=null)
                Console.WriteLine("Se registró un salón en la base de datos");
        }




    }

}
