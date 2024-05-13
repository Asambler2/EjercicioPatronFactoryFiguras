using EjercicioPatronFactoryFiguras.WDidcografica.Canciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.WDidcografica.ValidadorReproducibles
{
    public class ValidadorDuracionReproducibles : IValidadorReproducibles
    {
        public bool EsValido(int Duracion)
        {
            return(Duracion > 0 && Duracion < 100);
        }
    }
}
