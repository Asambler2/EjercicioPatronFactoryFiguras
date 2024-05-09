using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.Factoria
{
    public interface IFactoriaMedibles
    {
        public EjercicioPatronFactoryFiguras.Figura.IMedible DameFigura(EnumFigura figura, int valor);
    }
}
