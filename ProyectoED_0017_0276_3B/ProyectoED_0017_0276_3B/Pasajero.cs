using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoED_0017_0276_3B
{
    internal class Pasajero
    {
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public string NumTelefono { get; set; }
        public string Correo { get; set; }

        public Pasajero(string nombre, int edad, string numTel, string correo)
        {
            Nombre = nombre;
            Edad = edad;
            NumTelefono = numTel;
            Correo = correo;
        }
    }
}
