using EjercicioPatronFactoryFiguras.Figura;
using EjercicioPatronFactoryFiguras.Ordenadores;
using EjercicioPatronFactoryFiguras.ValidadorOrdenador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.OrdenadorFactoria
{
    internal class FactoriaVendible : IFactoriaVendible
    {
        public IVendible DameOrdenador(int Codigo, IValidadorOrdenador Validador, double Precio = 0, int Tiempo = 0)
        {
            if (!Validador.EsValido(Precio, Tiempo)){
                switch (Codigo)
                {
                    case 1: return new OrdenadorLento();
                    case 2: return new OrdenadorNormal();
                    case 3: return new OrdenadorGamer();
                    default: return null;
                }
            } else
            {
                switch (Codigo)
                {
                    case 1: return new OrdenadorLento(Precio, Tiempo);
                    case 2: return new OrdenadorNormal(Precio, Tiempo);
                    case 3: return new OrdenadorGamer(Precio, Tiempo);
                    default: return null;
                }
            }
        }
    }
}
