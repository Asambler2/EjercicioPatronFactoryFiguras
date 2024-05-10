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
        public string Figura { get; set; } = "Circulo";

        public Circulo(int valor)
        {
            this.radio = valor;
        }

        public string GetFigura()
        {
            return Figura;
        }

        public double DamePerimetro()
        {
            return 2 * Math.Round(Math.PI * radio, 2);
        }
        public double DameSuperficie()
        {
            return Math.Round(Math.PI * radio * radio, 2);
        }

        public override string ToString()
        {
            return Visor.Visualizalo(this);
        }
    }
}
