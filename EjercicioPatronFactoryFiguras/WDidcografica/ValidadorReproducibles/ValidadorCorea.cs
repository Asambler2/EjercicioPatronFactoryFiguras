using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.WDidcografica.ValidadorReproducibles
{
    public class ValidadorCorea : IValidadorReproducibles
    {
        public bool EsValido(int Duracion)
        {
            return (Duracion > 7 && Duracion < 15);
        }
    }

}
