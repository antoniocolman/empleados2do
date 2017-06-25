using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using BibliotecaProyecto;

namespace InterfazEmpleados
{
    public partial class frmMarcacion : MetroFramework.Forms.MetroForm
    {
        public frmMarcacion()
        {
            InitializeComponent();
        }

        private void ActualizarListaMarcaciones()
        {
            lstMarcaciones.DataSource = null;
            lstMarcaciones.DataSource = Marcacion.ObtenerMarcaciones();
        }

        private void frmMarcacion_Load(object sender, EventArgs e)
        {
            ActualizarListaMarcaciones();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rdbEntrada.Checked = true;
            rdbSalida.Checked = false;
            txtCodigo.Text = string.Empty;
            txtEmpleado.Text = string.Empty;
            dtpFechaHora.Value = DateTime.Now;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Marcacion marcacion = new Marcacion();

            marcacion.codigo = Marcacion.ObtenerMarcaciones().Count + 1;
            marcacion.empleado = Empleado.ObtenerEmpleadoPorCodigo(int.Parse(txtCodigo.Text));
            marcacion.fecha = dtpFechaHora.Value;
            marcacion.tipoMarcacion = (rdbEntrada.Checked) ? TipoMarcacion.Entrada : TipoMarcacion.Salida;

            Marcacion.AgregarMarcacion(marcacion);

            ActualizarListaMarcaciones();

            if (rdbEntrada.Checked)
            {
                Horario entrada = new Horario();
                entrada.Hora = marcacion.fecha.Hour;
                entrada.Minutos = marcacion.fecha.Minute;

                ParametroSistema parametros = ParametroSistema.ObtenerParametroSistemaActivo();
                int minutosTardios = parametros.CalcularMinutosTardios(entrada);

                if (minutosTardios > 0)
                {
                    LlegadaTardia llegadaTardia = new LlegadaTardia();

                    llegadaTardia.fecha = marcacion.fecha;
                    llegadaTardia.empleado = marcacion.empleado;
                    llegadaTardia.minutosTardios = minutosTardios;

                    LlegadaTardia.AgregarLlegadaTardia(llegadaTardia);
                }
            }


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Empleado empleado = Empleado.ObtenerEmpleadoPorCodigo(int.Parse(txtCodigo.Text));
            txtEmpleado.Text = empleado.nombres + " " + empleado.apellidos;
        }

        private void lstMarcaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMarcaciones.SelectedItem != null)
            {
                Marcacion marcacion = (Marcacion)lstMarcaciones.SelectedItem;

                rdbEntrada.Checked = (marcacion.tipoMarcacion == TipoMarcacion.Entrada) ? true : false;
                rdbSalida.Checked = (marcacion.tipoMarcacion == TipoMarcacion.Salida) ? true : false;
                txtCodigo.Text = marcacion.codigo.ToString();
                txtEmpleado.Text = marcacion.empleado.nombres + " " + marcacion.empleado.apellidos;
                dtpFechaHora.Value = marcacion.fecha;
            }
        }
    }
}
