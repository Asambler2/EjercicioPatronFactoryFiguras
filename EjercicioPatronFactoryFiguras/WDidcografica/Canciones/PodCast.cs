﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.WDidcografica.Canciones
{
    public class PodCast : IReproducible
    {
        public int Duracion { get; set; }
        public string Titulo { get; set; }

        public PodCast(int duracion = 20, string titulo = "Por defecto")
        {
            Duracion = duracion;
            Titulo = titulo;
        }
        public string mostrar()
        {
            Console.WriteLine($"El título es {this.Titulo} con duracion {this.Duracion} y es del tipo {this.GetType()} ");
            return "$\"El título es {this.Titulo} con duracion {this.Duracion} y es del tipo {this.GetType()} \"";
        }
    }
}
