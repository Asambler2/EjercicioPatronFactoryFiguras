using EjercicioPatronFactoryFiguras.WDidcografica.Canciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.WDidcografica.ValidadorReproducibles
{
    public interface IValidadorReproducibles
    {
        public bool EsValido(int Duracion);
    }
}
