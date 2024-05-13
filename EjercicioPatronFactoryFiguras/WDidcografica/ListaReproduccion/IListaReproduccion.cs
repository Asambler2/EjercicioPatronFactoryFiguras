using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPatronFactoryFiguras.WDidcografica.Canciones;

namespace EjercicioPatronFactoryFiguras.WDidcografica.ListaReproduccion
{
    public interface IListaReproduccion
    {
        public int DuracionTotalLista{ get; set; }
        public int CantidadDeReproducibles { get; set; }                  
        public void AddReproducible(IReproducible Reproducible);
        public string MostrarLista();
    }
}
