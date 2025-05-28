using System;

namespace Tarea1.ClassMap.Modelos
{
    class Program

        // Esto es para probar el codigo. 
    {
        static void Main(string[] args)
        {
            // Estudiante
            var estudiante1 = new Roles.Estudiante
            {
                Nombre = "Gilenni Moreno",
                Edad = 19,
                ID = 20241705,
                CorreoInstitucional = "20241705@itla.edu.do",
                Carrera = "Desarrollo de Software",
                Horario = "Vespertino",
                Genero = "Femenino"
            };

            // ExAlumno
            var exAlumno1 = new Roles.ExAlumno
            {
                Nombre = "Marcus Medina",
                Edad = 25,
                ID = 20211526,
                CorreoInstitucional = "20211526@itla.edu.do",
                AñoEgreso = 2023
            };

            // Administrativo
            var administrativo1 = new Roles.Administrativo
            {
                Nombre = "Carlos García",
                Edad = 40,
                ID = 23452345,
                CorreoInstitucional = "carlosgarcia@itla.edu.do",
                Departamento = "Recursos Humanos",
                SNS = 123456789,
                Horario = "9:00 AM - 6:00 PM",
                Cargo = "Jefe de Personal"
            };

            // Maestro
            var maestro1 = new Roles.Maestro
            {
                Nombre = "Starling Germosen",
                Edad = 38,
                ID = 12345678,
                CorreoInstitucional = "sgermosen@itla.edu.do",
                Departamento = "Educación",
                SNS = 987654321,
                Horario = "Martes: 6:00pm - 10:00pm",
                Asignatura = "Programacion II",
                CursoAsignado = "4to Cuatrimestre",
                AccesoAlSistema = false
            };

            //Administrador
            var administrador1 = new Roles.Administrador
            {
                Nombre = "María López",
                Edad = 45,
                ID = 1236789,
                CorreoInstitucional = "mlopez@admin1243.com",
                Departamento = "Administración",
                SNS = 928638728,
                Horario = "9:00 AM - 5:00 PM",
                AccesoAlSistema = true,
                AreaAdministrativa = "Finanzas"
            };

            // Metodo pa mostrar la info
            estudiante1.MostrarInfo();
            exAlumno1.MostrarInfo();
            administrativo1.MostrarInfo();
            maestro1.MostrarInfo();
            administrador1.MostrarInfo();


            Console.ReadLine();
        }
    }
}
