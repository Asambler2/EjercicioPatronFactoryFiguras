using EjercicioPatronFactoryFiguras.Ordenadores;
using EjercicioPatronFactoryFiguras.ValidadorOrdenador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.OrdenadorFactoria
{
    public interface IFactoriaVendible
    {
        public IVendible DameOrdenador(int codigo, IValidadorOrdenador validador, double precio = 0, int Tiempo = 0);
    }
}
