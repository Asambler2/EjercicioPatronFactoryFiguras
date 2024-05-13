using EjercicioPatronFactoryFiguras.WDidcografica.Canciones;
using EjercicioPatronFactoryFiguras.WDidcografica.FactoriaCanciones;
using EjercicioPatronFactoryFiguras.WDidcografica.ListaReproduccion;
using EjercicioPatronFactoryFiguras.WDidcografica.ValidadorReproducibles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.WDidcografica.Menu
{
    public class MenuCreacionLista
    {
        public ListaReproduccionReproducibles Lista = new ListaReproduccionReproducibles();
        IFabricaReproduciblescs FactoriaReproducibles = new FabricaReproducibles();
        IValidadorReproducibles Validador = new ValidadorDuracionReproducibles();
        public void CreacionLista() 
        {
            int Comando = 0;
            int Duracion = 0;
            string Titulo = "";
            Console.WriteLine("Escribe 1 para añadir un nuevo reproducible. \nPresiona 0 para salir.");
            Comando = int.Parse(Console.ReadLine());
            if(Comando == 1) {
                Console.WriteLine("Indica la duración del reproducible");
                Duracion = int.Parse(Console.ReadLine());
                Console.WriteLine("Indica el título del reproducible");
                Titulo = Console.ReadLine();
                Console.WriteLine("Indica 1 si quieres una canción\n Indica 2 si quieres un podcast \n Indica 3 si quieres una pelicula");
                Comando = int.Parse(Console.ReadLine());
                IReproducible Reproducible = FactoriaReproducibles.DameReproducible(Comando, Validador, Duracion, Titulo);
                Lista.AddReproducible(Reproducible);
                Reproducible.mostrar();
                Lista.MostrarLista();
                this.CreacionLista();
            }
        } 
    }
}
