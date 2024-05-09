
using EjercicioPatronFactoryFiguras.Figura;
using EjercicioPatronFactoryFiguras.Factoria;


IFactoriaMedibles FactoriaFiguras = new FactoriaMedibles();

IMedible figuraCuadrado = FactoriaFiguras.DameFigura(EnumFigura.Cuadrado, 7);

IMedible figuraCirculo = FactoriaFiguras.DameFigura(EnumFigura.Circulo, 10);

Console.WriteLine($"Perímetro del cuadrado: {figuraCuadrado.DamePerimetro()} y área de cuadrado {figuraCuadrado.DameSuperficie()}");

Console.WriteLine($"Perímetro del circulo: {figuraCuadrado.DamePerimetro()} y área de circulo {figuraCirculo.DameSuperficie()}");

(figuraCirculo as Circulo).Visor = new VisualizadorPorConsola();

(figuraCirculo as Circulo).ToString();

(figuraCuadrado as Cuadrado).Visor = new VisualizadorPorConsola();

(figuraCuadrado as Cuadrado).ToString();
