using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.Figura
{
    internal class Cuadrado : IMedible
    {
        public IVisualizable Visor { get; set; }
        public int lado;
        public string Figura = "Cuadrado";

        public double DamePerimetro()
        {
            return lado * 4;
        }
        public double DameSuperficie()
        {
            return lado * lado;
        }

        public override string ToString() {
            return Visor.Visualizalo(this);
        }
    }
}
