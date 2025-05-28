using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.ClassMap.Modelos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea1.ClassMap.Modelos
{

 //Aqui cree miembro de la comunidad que herede los atributos de identidad para poder imprimirlos.
    public class MiembroDeLaComunidad : Identidad
    {
        public string RolEnLaComunidad { get; set; }

        public virtual void MostrarInfo()
        {
            Console.WriteLine("Miembro de la comunidad educativa: ");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Correo Institucional: {CorreoInstitucional}");
        }
    }
}