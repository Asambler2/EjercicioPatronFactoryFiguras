using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.Ordenadores
{
    public class ColeccionOrdenadores
    {
        public List<IVendible> ListaOrdenadores = new ();

        public double TotalImporte { get; set; }
        public int TotalOrdenadoresVendidos { get; set; }
        public double OrdenadorMasBarato { get; set; }
        public double OrdenadorMasCaro { get; set; }
        public double PrecioMedio { get; set; }
        public int NumOrdenadoresPrecioMayor125 { get; set; }

        public void Add(IVendible Ordenador)
        {
            ListaOrdenadores.Add(Ordenador);
            this.TotalImporte += Ordenador.Precio;
            this.TotalOrdenadoresVendidos++;
            if (Ordenador.Precio > 125) this.NumOrdenadoresPrecioMayor125++;
            if(this.OrdenadorMasBarato == 0) this.OrdenadorMasBarato = Ordenador.Precio;
            if(this.OrdenadorMasBarato > Ordenador.Precio) this.OrdenadorMasBarato = Ordenador.Precio;
            if (this.OrdenadorMasCaro < Ordenador.Precio) this.OrdenadorMasCaro = Ordenador.Precio;
            this.PrecioMedio = TotalImporte / TotalOrdenadoresVendidos;
        }

        public override string ToString()
        {
            Console.WriteLine($"TOTAL IMPORTE: {this.TotalImporte} TOTAL ORDENADORES VENDIDOS: {this.TotalOrdenadoresVendidos} PRECIO MAS BARATO: {this.OrdenadorMasBarato} PRECIO MAS CARO: {this.OrdenadorMasCaro} " +
                $" PRECIO MEDIO: {this.PrecioMedio} NUM ORDENADORES PRECIO MAYOR 125: {this.NumOrdenadoresPrecioMayor125} ");

            return $"TOTAL IMPORTE: {this.TotalImporte} TOTAL ORDENADORES VENDIDOS: {this.TotalOrdenadoresVendidos} PRECIO MAS BARATO: {this.OrdenadorMasBarato} PRECIO MAS CARO: {this.OrdenadorMasCaro} " +
                $" PRECIO MEDIO: {this.PrecioMedio} NUM ORDENADORES PRECIO MAYOR 125: {this.NumOrdenadoresPrecioMayor125} ";
        }

    }
}
