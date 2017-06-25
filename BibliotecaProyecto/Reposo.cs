using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto
{
    public class Reposo
    {
        public Empleado empleado { get; set; }
        public string observacion { get; set; }
        public DateTime fechaInicio { get; set; }
        public int cantidadDias { get; set; }

        public static List<Reposo> listReposos = new List<Reposo>();

        public static void AgregarReposo(Reposo r)
        {
            listReposos.Add(r);
        }

        public static void EliminarReposo(Reposo r)
        {
            listReposos.Remove(r);
        }

        public static List<Reposo> ObtenerReposos()
        {
            return listReposos;
        }
    
        public override string ToString()
        {
            return empleado.nombres;
        }
    }
}
