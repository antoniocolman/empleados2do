using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto
{
    public class DiaLibre
    {
        public Empleado empleado { get; set; }
        public DateTime fecha { get; set; }

        public static List<DiaLibre> ListaCanjesDiasLibres = new List<DiaLibre>();

        public static void AgregarDiaLibre(DiaLibre diaLibre)
        {
            if (diaLibre.empleado.diasLibresAFavor >= 1)
            {
                ListaCanjesDiasLibres.Add(diaLibre);

                diaLibre.empleado.diasLibresAFavor -= 1;

                List<HoraExtra> listHorasExtras  = HoraExtra.ObtenerHorasExtra();

                List<HoraExtra> sortedList = listHorasExtras.OrderBy(o => o.fecha).ToList();
                int totalCanjeado = 0;
                foreach (HoraExtra horaExtra in sortedList)
                {
                    while (totalCanjeado <= 8)
                    {
                        if (diaLibre.empleado == horaExtra.empleado)
                        {
                            int horasCanjeables = (horaExtra.cantidadHorasAcumuladas - horaExtra.cantidadHorasCanjeadas);
                            if (horasCanjeables > 0)
                            {
                                int exceso = (totalCanjeado + horasCanjeables) - 8;
                                int canje = (exceso > 0) ? (horasCanjeables - exceso) : horasCanjeables;

                                totalCanjeado += canje;
                                horaExtra.cantidadHorasCanjeadas += canje;
                            }
                        }
                    }
                }
            }
        }

        public static List<DiaLibre> ObtenerDiasLibres()
        {
            return ListaCanjesDiasLibres;
        }

        public override string ToString()
        {
            return empleado.nombres;
        }
    }
}
