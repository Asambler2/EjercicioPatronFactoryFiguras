using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.Figura
{
    internal class Circulo : IMedible
    {
        public IVisualizable Visor { get; set; }
        public int radio;
        public string Figura = "Circulo";

        public double DamePerimetro()
        {
            return 2 * Math.PI * radio;
        }
        public double DameSuperficie()
        {
            return Math.PI * radio * radio;
        }

        public override string ToString()
        {
            return Visor.Visualizalo(this);
        }
    }
}
