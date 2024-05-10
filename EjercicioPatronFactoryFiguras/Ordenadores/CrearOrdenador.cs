using EjercicioPatronFactoryFiguras.OrdenadorFactoria;
using EjercicioPatronFactoryFiguras.ValidadorOrdenador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.Ordenadores
{
    public class CrearOrdenador
    {
        public ColeccionOrdenadores Ordenadores = new ColeccionOrdenadores();
        IFactoriaVendible FactoriaOrdenadores = new FactoriaVendible();
        public void Crear()
        {
            int Comando = 0;
            double Precio = 0;
            int Garantia = 0;
            Console.WriteLine("Indica si quieres crear un ordenador con 1 o si quieres salir con 0");
            Comando = int.Parse(Console.ReadLine());
            if (Comando == 1) {
                Console.WriteLine("Indica el precio del ordenador");
                Precio = int.Parse(Console.ReadLine());
                Console.WriteLine("Indica la garantia del ordenador");
                Garantia = int.Parse(Console.ReadLine());
                Console.WriteLine("Indica 1 si quieres un ordenador lento\n Indica 2 si quieres un ordenador normal \n Indica 3 si quieres un ordenador Gamer");
                Comando = int.Parse(Console.ReadLine());
                IVendible Ordenador = FactoriaOrdenadores.DameOrdenador(Comando, new ValidadorOrdenadorClase(), Precio, Garantia);
                Ordenadores.Add(Ordenador);
                Ordenador.ToString();
                Ordenadores.ToString();
                this.Crear();
            }
        }
    }
}
