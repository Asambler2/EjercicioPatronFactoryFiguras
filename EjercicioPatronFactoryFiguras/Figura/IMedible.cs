using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.Figura
{
    public interface IMedible
    {
        public string GetFigura();
        public double DamePerimetro();
        public double DameSuperficie();
    }
}
