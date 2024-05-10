using EjercicioPatronFactoryFiguras.Ordenadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.ValidadorOrdenador
{
    public class ValidadorOrdenadorClase : IValidadorOrdenador
    {
        public bool EsValido(double Precio, int Tiempo)
        {
            if (Precio > 0 && Tiempo > 0) return true;
            return false;
        }
    }
}
