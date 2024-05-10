using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPatronFactoryFiguras.ValidadorOrdenador;

namespace EjercicioPatronFactoryFiguras.Ordenadores
{
    internal class OrdenadorGamer : IVendible
    {
        public double Precio { get; set; } = 1000;
        public int TiempoGarantia { get; set; } = 4;

        public OrdenadorGamer(double precio = 1000, int tiempoGarantia = 4)
        {
            Precio = precio;
            TiempoGarantia = tiempoGarantia;
        }

        public double TiempoMedioRotura()
        {
            return this.Precio / this.TiempoGarantia;
        }
        public void Listado()
        {
            Console.WriteLine($"Tipo: {this.GetType()} Precio: {this.Precio} Garantia: {this.TiempoGarantia} Tiempo medio rotura: {this.TiempoMedioRotura()}");
        }

    }
}
