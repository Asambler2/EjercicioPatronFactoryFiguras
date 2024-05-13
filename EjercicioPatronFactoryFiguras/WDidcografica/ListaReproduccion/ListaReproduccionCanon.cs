using EjercicioPatronFactoryFiguras.WDidcografica.Canciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.WDidcografica.ListaReproduccion
{
    public class ListaReproduccionCanon :IListaReproduccion
    {
        public int DuracionTotalLista { get; set; } = 0;
        public int CantidadDeReproducibles { get; set; } = 0;
        public int CanonTotal { get; set; } = 0;
        public List<IReproducible> Lista = new();

        public void AddReproducible(IReproducible Reproducible)
        {
            this.Lista.Add(Reproducible);
            if(Reproducible is RepConCanon) {
                CanonTotal += ((RepConCanon)Reproducible).Canon;
            }
            DuracionTotalLista += Reproducible.Duracion;
            CantidadDeReproducibles++;
        }

        public string MostrarLista()
        {
            Console.WriteLine($"La lista de reproducción dura: {this.DuracionTotalLista} con un canon total de {this.CanonTotal} y tiene {this.CantidadDeReproducibles} reproducibles");
            return $"La lista de reproducción dura: {this.DuracionTotalLista} con un canon total de {this.CanonTotal} y tiene {this.CantidadDeReproducibles} reproducibles";
        }
    }
}
