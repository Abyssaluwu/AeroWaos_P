using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoED_0017_0276_3B
{
    //esta classe es la clase grafo
    internal class Vuelo
    {
        public List<Ciudad> ciudades { get; set; }
        public List<Ruta> rutas { get; set; }
        public Vuelo()
        {
            ciudades = new List<Ciudad>();
            rutas = new List<Ruta>();
        }
        public void AgregaNodo(Ciudad ciudad)
        {
            ciudades.Add(ciudad);
        }
        public void AgregegaArista(Ruta ruta)
        {
            rutas.Add(ruta);
        }
    }
}
