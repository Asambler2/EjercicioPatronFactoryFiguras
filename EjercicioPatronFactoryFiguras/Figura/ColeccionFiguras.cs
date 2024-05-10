using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.Figura
{
    public class ColeccionFiguras
    {
        public List<IMedible> ListaFiguras = new ();
        public int TotalFiguras { get; set; }
        public double TotalSuperficie { get; set; }
        public double TotalPerimetro { get; set; }
        public double MediaSuperficie { get; set; }
        public double MediaPerimetro { get; set; }
        public double MaxFigura { get; set; }
        public double MinFigura { get; set; }
        public void AddNuevaFigura(IMedible Figura)
        {
            ListaFiguras.Add (Figura);
            this.TotalFiguras++;
            this.TotalSuperficie += Figura.DameSuperficie();
            this.TotalPerimetro += Figura.DamePerimetro();
            this.MediaPerimetro += this.TotalPerimetro / this.TotalFiguras;
            this.MediaSuperficie += this.TotalSuperficie / this.TotalFiguras;
            if(this.MaxFigura == null)
            {
                this.MaxFigura = Figura.DameSuperficie();
                this.MinFigura = Figura.DameSuperficie();
            } else
            {
                if (this.MaxFigura < Figura.DameSuperficie()) this.MaxFigura = Figura.DameSuperficie();
                if (this.MinFigura > Figura.DameSuperficie()) this.MinFigura = Figura.DameSuperficie();
            }
        }
    }
}
