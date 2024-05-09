using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.Factoria
{
    internal class FactoriaMedibles : IFactoriaMedibles
    {
        public EjercicioPatronFactoryFiguras.Figura.IMedible DameFigura(EnumFigura figura, int valor)
        {
            switch(figura)
            {
                case EnumFigura.Circulo: return new EjercicioPatronFactoryFiguras.Figura.Circulo();
                case EnumFigura.Cuadrado: return new EjercicioPatronFactoryFiguras.Figura.Cuadrado();
                default: return null;
            }
        }
    }
}
