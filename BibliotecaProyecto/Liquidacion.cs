using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto
{
    public class Liquidacion
    {
        public Empleado empleado { get; set; }
        public double salarioBase { get; set; }
        public double montoIPS { get; set; }
        public double salario { get; set; }

        public List<Liquidacion> listLiquidaciones = new List<Liquidacion>();

        public List<Liquidacion> obtenerLiquidaciones (List<Empleado> listEmpleados)
        {
            foreach (Empleado empleado in listEmpleados)
            {
                Liquidacion liquidacion = new Liquidacion();
                liquidacion.empleado = empleado;
                liquidacion.salarioBase = empleado.salarioBase;
                liquidacion.montoIPS = empleado.salarioBase * 0.09;
                liquidacion.salario = liquidacion.salarioBase - liquidacion.montoIPS;
                listLiquidaciones.Add(liquidacion);
            }
            return listLiquidaciones;
        }

        public double ObtenerTotalSalarioBase()
        {
            return listLiquidaciones.Sum(item => item.salarioBase);
        }

        public double ObtenerTotalMontoIps()
        {
            return listLiquidaciones.Sum(item => item.montoIPS);
        }

        public double ObtenerTotalSalario()
        {
            return listLiquidaciones.Sum(item => item.salario);
        }

        public override string ToString()
        {
            return empleado.nombres;
        }
    }
}
