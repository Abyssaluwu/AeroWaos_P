using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoED_0017_0276_3B
{
    internal class Boleto
    {
        public DateTime Fecha { get; set; }
        public string NombrePasajero { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public Boleto(DateTime fecha, string nombrepasajero, string origen, string destino)
        {
            Fecha = fecha;
            NombrePasajero = nombrepasajero;
            Origen = origen;
            Destino = destino;
        }
    }
}
