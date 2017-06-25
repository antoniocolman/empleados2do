using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto
{
    public class LlegadaTardia
    {
        public DateTime fecha { get; set; }
        public Empleado empleado { get; set; }
        public int minutosTardios { get; set; }

        public static List<LlegadaTardia> listLlegadasTardias = new List<LlegadaTardia>();

        public static void AgregarLlegadaTardia(LlegadaTardia m)
        {
            listLlegadasTardias.Add(m);
        }

        public static List<LlegadaTardia> ObtenerLlegadasTardias()
        {
            return listLlegadasTardias;
        }

        public static List<LlegadaTardia> ObtenerLlegadasTardias(DateTime fecha, Empleado empleado)
        {
            List<LlegadaTardia> listLlegadasTardiasFiltradas = new List<LlegadaTardia>();

            foreach (LlegadaTardia llegadaTardia in listLlegadasTardias)
            {
                if (llegadaTardia.fecha.Date.Month == fecha.Date.Month && llegadaTardia.empleado == empleado)
                    listLlegadasTardiasFiltradas.Add(llegadaTardia);
            }

            return listLlegadasTardiasFiltradas;
        }

        public override string ToString()
        {
            return empleado.nombres;
        }
    }
}
