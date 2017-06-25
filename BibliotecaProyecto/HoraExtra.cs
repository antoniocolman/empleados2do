using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto
{
    public class HoraExtra
    {
        public Empleado empleado { get; set; }
        public DateTime fecha { get; set; }
        public int cantidadHorasAcumuladas { get; set; }
        public int cantidadHorasCanjeadas { get; set; }

        public static List<HoraExtra> ListaHorasExtra = new List<HoraExtra>();

        public HoraExtra() {
            cantidadHorasCanjeadas = 0;
        }
  
        public static void AgregarHoraExtra(HoraExtra h)
        {
            if (h.cantidadHorasAcumuladas >= 1 && h.cantidadHorasAcumuladas <= 4) {
                ListaHorasExtra.Add(h);
                h.empleado.AgregarDiaLibreAFavor(h);
            }
        }

        public static List<HoraExtra> ObtenerHorasExtra ()
        {
            return ListaHorasExtra;
        }

        public override string ToString()
        {
            return empleado.nombres;
        }
    }
}
