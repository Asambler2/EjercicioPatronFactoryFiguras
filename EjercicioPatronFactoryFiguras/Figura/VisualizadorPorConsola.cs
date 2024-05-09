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
            Console.WriteLine($"Tiene una superficie de: {Math.Round(figura.DamePerimetro(), 2)} y un área de {Math.Round(figura.DameSuperficie(), 2)} y es un {figura.GetFigura()}");
            return "";
        }
    }
}
