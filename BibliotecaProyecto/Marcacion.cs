using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto
{
    public enum TipoMarcacion { Entrada, Salida }

    public class Marcacion
    {

        public int codigo { get; set; }
        public Empleado empleado { get; set; }
        public DateTime fecha { get; set; }
        public TipoMarcacion tipoMarcacion { get; set; }

        public static List<Marcacion> listMarcaciones = new List<Marcacion>();

        public static void AgregarMarcacion(Marcacion m)
        {
            listMarcaciones.Add(m);
        }

        public static List<Marcacion> ObtenerMarcaciones()
        {
            return listMarcaciones;
        }

        public static List<Marcacion> ObtenerMarcaciones(DateTime fecha, Empleado empleado)
        {
            List<Marcacion> listMarcacionesFiltradas = new List<Marcacion>();

            foreach (Marcacion marcacion in listMarcaciones)
            {
                if (marcacion.fecha.Date == fecha.Date && marcacion.empleado == empleado)
                    listMarcacionesFiltradas.Add(marcacion);
            }

            return listMarcacionesFiltradas;
        }

        public override string ToString()
        {
            return codigo.ToString() + " " + empleado.nombres;
        }

    }
}
