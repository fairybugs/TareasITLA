using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.ClassMap.Modelos
{
    // Gilenni Moreno ITLA
    // Esta clase representa los diferentes roles en la comunidad educativa.
    internal class Roles
    {
        internal class Estudiante : MiembroDeLaComunidad
        {
            public string Carrera { get; set; }
            public string Horario { get; set; }
            public string Genero { get; set; }

            public override void MostrarInfo()
            {
                base.MostrarInfo();
                Console.WriteLine($"Carrera: {Carrera}");
                Console.WriteLine($"Horario: {Horario}");
                Console.WriteLine($"Género: {Genero}");
                Console.WriteLine();
            }
        }

        internal class ExAlumno : MiembroDeLaComunidad
        {
            public int AñoEgreso { get; set; }

            public override void MostrarInfo()
            {
                base.MostrarInfo();
                Console.WriteLine($"Año de Egreso: {AñoEgreso}");
                Console.WriteLine();
            }
        }

        internal abstract class Empleado : MiembroDeLaComunidad
        {
            public string Departamento { get; set; }
            public int SNS { get; set; }
            public string Horario { get; set; }
        }

        //Empleado hereda dos roles
        internal class Administrativo : Empleado
        {
            public string Cargo { get; set; }

            public override void MostrarInfo()
            {
                base.MostrarInfo();
                Console.WriteLine($"Cargo: {Cargo}");
                Console.WriteLine($"Departamento: {Departamento}");
                Console.WriteLine();
            }
        }

        internal abstract class Docente : Empleado
        {
            public bool AccesoAlSistema { get; set; }

            public override void MostrarInfo()
            {
                base.MostrarInfo();
                Console.WriteLine($"Acceso al sistema: {AccesoAlSistema}");
            }
        }

        // Ahora docente hereda otro dos roles:
        internal class Maestro : Docente
        {
            public string Asignatura { get; set; }
            public string CursoAsignado { get; set; }

            public override void MostrarInfo()
            {
                base.MostrarInfo();
                Console.WriteLine($"Asignatura: {Asignatura}");
                Console.WriteLine($"Curso Asignado: {CursoAsignado}");
                Console.WriteLine();
            }
        }

        internal class Administrador : Docente
        {
            public string AreaAdministrativa { get; set; }

            public override void MostrarInfo()
            {
                base.MostrarInfo();
                Console.WriteLine($"Área Administrativa: {AreaAdministrativa}");
                Console.WriteLine();
            }
        }
    }
}
