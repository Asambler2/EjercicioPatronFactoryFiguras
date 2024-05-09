using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.Figura
{
    public class VisualizadorPorConsola: IVisualizable
    {
        public string Visualizalo(IMedible figura)
        {
            Console.WriteLine($"Tiene una superficie de: {figura.DamePerimetro()} y un área de {figura.DameSuperficie()}");
            return "";
        }
    }
}
