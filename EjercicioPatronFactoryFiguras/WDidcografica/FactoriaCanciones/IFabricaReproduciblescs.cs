using EjercicioPatronFactoryFiguras.WDidcografica.Canciones;
using EjercicioPatronFactoryFiguras.WDidcografica.ValidadorReproducibles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.WDidcografica.FactoriaCanciones
{
    public interface IFabricaReproduciblescs
    {
        public IReproducible DameReproducible(int tipo, IValidadorReproducibles Validador, int Duracion);
        public IReproducible DameReproducible(int tipo, IValidadorReproducibles Validador, int Duracion, string Titulo );
        public IReproducible DameReproducible(int tipo, IValidadorReproducibles Validador, int Duracion, string Titulo, int Canon);
    }
}
