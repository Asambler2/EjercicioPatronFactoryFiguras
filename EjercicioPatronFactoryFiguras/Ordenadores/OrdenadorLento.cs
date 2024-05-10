using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPatronFactoryFiguras.ValidadorOrdenador;

namespace EjercicioPatronFactoryFiguras.Ordenadores
{
    public class OrdenadorLento : IVendible
    {
        public double Precio { get; set; }
        public int TiempoGarantia { get; set; }

        public OrdenadorLento(double precio = 100, int tiempoGarantia = 2)
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
