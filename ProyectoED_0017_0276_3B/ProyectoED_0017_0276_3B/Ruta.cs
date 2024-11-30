using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoED_0017_0276_3B
{
    //esta es la clase arista
    internal class Ruta
    {
        public Ciudad Origen { get; set; }
        public Ciudad Destino { get; set; }
        public double Distancia { get; set; }
        public Ruta(Ciudad origen, Ciudad destino, double distancia)
        {
            Origen = origen;
            Destino = destino;
            Distancia = distancia;
        }
    }
}
