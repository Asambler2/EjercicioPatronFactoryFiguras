using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.Figura
{
    public interface IVisualizable
    {
        public string Visualizalo(IMedible figura);
    }
}
