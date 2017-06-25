using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto
{
    public struct Horario
    {
        public int Hora { get; set; }
        public int Minutos { get; set; }
    }

    public class ParametroSistema
    {
        public Horario horarioEntrada { get; set; }
        public Horario horarioSalida { get; set; }
        public int minutosTolerancia { get; set; }
        public int maxDiasVacacionesAcumulados { get; set; }
        public bool activo { get; set; }

        public static List<ParametroSistema> ListaParametroSistema = new List<ParametroSistema>();
   
        public static void AgregarParametroSistema(ParametroSistema p)
        {
            ListaParametroSistema.Add(p);
        }

        public static void EliminarParametroSistema(ParametroSistema p)
        {
            ListaParametroSistema.Remove(p);
        }

        public static List<ParametroSistema> ObtenerParametrosSistema()
        {
            return ListaParametroSistema;
        }
        public static ParametroSistema ObtenerParametroSistemaActivo()
        {
            foreach (ParametroSistema p in ListaParametroSistema)
            {
                if (p.activo) return p;
            }
            return null;
        }

        public int CalcularMinutosTardios(Horario entrada)
        {
            return 0;
        }
    }
}
