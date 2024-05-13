using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.WDidcografica.Canciones
{
    public class RepConCanon : IReproducible, ICanon
    {
        public int Duracion { get; set; }
        public string Titulo { get; set; }
        public int Canon { get; set; }

        public RepConCanon(int duracion = 4, string titulo = "Por defecto", int Canon = 5)
        {
            Duracion = duracion;
            Titulo = titulo;
            this.Canon = Canon;
        }

        public string mostrar()
        {
            Console.WriteLine($"El título es {this.Titulo} con duracion {this.Duracion} con canon de {this.Canon} y es del tipo {this.GetType().ToString().Replace("EjercicioPatronFactoryFiguras.WDidcografica.Canciones.", "")} ");
            return $"El título es {this.Titulo} con duracion {this.Duracion} con canon de {this.Canon} y es del tipo {this.GetType().ToString().Replace("EjercicioPatronFactoryFiguras.WDidcografica.Canciones.", "")} ";
        }
    }
}
