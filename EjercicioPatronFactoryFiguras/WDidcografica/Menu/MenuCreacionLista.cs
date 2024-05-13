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
        public ListaReproduccionCanon Lista = new ListaReproduccionCanon();
        IFabricaReproduciblescs FactoriaReproducibles = new FabricaReproducibles();
        IValidadorReproducibles Validador = new ValidadorCorea();
        public void CreacionLista() 
        {
            int Comando = 0;
            int Duracion = 0;
            int Canon = 0;
            string Titulo = "";
            Console.WriteLine("Escribe 1 para añadir un nuevo reproducible. \nPresiona 0 para salir.");
            Comando = int.Parse(Console.ReadLine());
            if(Comando == 1) {
                Console.WriteLine("Indica la duración del reproducible");
                Duracion = int.Parse(Console.ReadLine());
                Console.WriteLine("Indica el título del reproducible");
                Titulo = Console.ReadLine();
                Console.WriteLine("Indica 1 si quieres una canción\n Indica 2 si quieres un podcast \n Indica 3 si quieres una pelicula \n Indica 4 si quieres una Reproducible con canon");
                Comando = int.Parse(Console.ReadLine());
                IReproducible Reproducible = null;
                if (Comando == 4)
                {
                    Console.WriteLine("Si quieres que el canon sea por defecto pulsa 1. \n Si quieres introducir el canon presiona 2.");
                    Comando = int.Parse(Console.ReadLine());
                    if(Comando == 1)
                    {
                        Reproducible = FactoriaReproducibles.DameReproducible(Comando, Validador, Duracion, Titulo);
                    } else
                    {
                        Console.WriteLine("Indica el canon del reproducible");
                        Canon = int.Parse(Console.ReadLine());
                        Reproducible = FactoriaReproducibles.DameReproducible(Comando, Validador, Duracion, Titulo, Canon);
                    }
                } else
                {
                   Reproducible = FactoriaReproducibles.DameReproducible(Comando, Validador, Duracion, Titulo);
                }
                if(Reproducible != null)Lista.AddReproducible(Reproducible);
                Reproducible.mostrar();
                Lista.MostrarLista();
                this.CreacionLista();
            }
        } 
    }
}
