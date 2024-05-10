using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPatronFactoryFiguras.Ordenadores
{
    public interface IVendible
    {
        public double Precio { get; set; }
        public int TiempoGarantia { get; set; }
        public double TiempoMedioRotura();

        public void Listado();
    }
}
