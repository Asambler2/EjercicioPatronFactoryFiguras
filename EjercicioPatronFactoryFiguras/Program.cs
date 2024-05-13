
using EjercicioPatronFactoryFiguras.Figura;
using EjercicioPatronFactoryFiguras.Factoria;
using EjercicioPatronFactoryFiguras.Ordenadores;
using EjercicioPatronFactoryFiguras.OrdenadorFactoria;
using EjercicioPatronFactoryFiguras.WDidcografica.Menu;


IFactoriaMedibles FactoriaFiguras = new FactoriaMedibles();

IMedible figuraCuadrado = FactoriaFiguras.DameFigura(EnumFigura.Cuadrado, 7);

IMedible figuraCirculo = FactoriaFiguras.DameFigura(EnumFigura.Circulo, 10);

Console.WriteLine($"Perímetro del cuadrado: {figuraCuadrado.DamePerimetro()} y área de cuadrado {figuraCuadrado.DameSuperficie()}");

Console.WriteLine($"Perímetro del circulo: {Math.Round(figuraCirculo.DamePerimetro(), 2)} y área de circulo {Math.Round(figuraCirculo.DameSuperficie(), 2)}");

(figuraCirculo as Circulo).Visor = new VisualizadorPorConsola();

(figuraCirculo as Circulo).ToString();

(figuraCuadrado as Cuadrado).Visor = new VisualizadorPorConsola();

(figuraCuadrado as Cuadrado).ToString();

ColeccionFiguras Coleccion = new();
Coleccion.ToString();

Coleccion.AddNuevaFigura(figuraCuadrado);
Coleccion.ToString();
Coleccion.AddNuevaFigura(figuraCirculo);
Coleccion.ToString();

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CrearOrdenador Crear = new CrearOrdenador();
Crear.Crear();

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------

MenuCreacionLista Menu = new MenuCreacionLista();
Menu.CreacionLista();