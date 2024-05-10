using EjercicioPatronFactoryFiguras.Ordenadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.ValidadorOrdenador
{
    public interface IValidadorOrdenador
    {
        public bool EsValido(double Precio, int Tiempo);
    }
}
