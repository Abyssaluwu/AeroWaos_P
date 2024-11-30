using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoED_0017_0276_3B
{
    //esta es la clase nodo
    class Ciudad
    {
        public string NombreCiudad { get; set; }
        public Point Ubicacion { get; set; }
        public Ciudad(string nombreciudad, Point ubicacion) 
        {
            NombreCiudad = nombreciudad;
            Ubicacion = ubicacion;
        }

    }
}
