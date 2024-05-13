using EjercicioPatronFactoryFiguras.WDidcografica.Canciones;
using EjercicioPatronFactoryFiguras.WDidcografica.ValidadorReproducibles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.WDidcografica.FactoriaCanciones
{
    public class FabricaReproducibles : IFabricaReproduciblescs
    {
        public IReproducible DameReproducible(int tipo, IValidadorReproducibles Validador, int Duracion)
        {
            if(Validador.EsValido(Duracion)) {
                switch(tipo)
                {
                    case 1: return new Cancion(Duracion);
                    case 2: return new PodCast(Duracion);
                    case 3: return new Pelicula(Duracion);
                    default: return null;
                }
            } else
            {
                switch (tipo)
                {
                    case 1: return new Cancion();
                    case 2: return new PodCast();
                    case 3: return new Pelicula();
                    default: return null;
                }
            }
        }

        public IReproducible DameReproducible(int tipo, IValidadorReproducibles Validador, int Duracion, string Titulo)
        {
            if (Validador.EsValido(Duracion))
            {
                switch (tipo)
                {
                    case 1: return new Cancion(Duracion, Titulo);
                    case 2: return new PodCast(Duracion, Titulo);
                    case 3: return new Pelicula(Duracion, Titulo);
                    default: return null;
                }
            }
            else
            {
                switch (tipo)
                {
                    case 1: return new Cancion();
                    case 2: return new PodCast();
                    case 3: return new Pelicula();
                    default: return null;
                }
            }
        }
    }
}
