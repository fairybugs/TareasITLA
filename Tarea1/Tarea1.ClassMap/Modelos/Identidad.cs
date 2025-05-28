using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.ClassMap.Modelos
{

    //Esto es de Gilenni Moreno del ITLA - Programacion 2 :D

    // Con la creacion de la clase Identidad buscaba dar una super clase con los datos basicos
    // que engloben a cada miembro de la comunidad como decia el profesor en el video explicativo.

    public class Identidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int ID { get; set; }
        public string CorreoInstitucional { get; set; }
    }
}

