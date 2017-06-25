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
    public partial class frmCambioCargo : MetroFramework.Forms.MetroForm
    {
        private void frmCambioCargo_Load(object sender, EventArgs e)
        {
            cboEmpleado.DataSource = Empleado.ObtenerEmpleados();
            cboCargoNuevo.DataSource = Cargo.ObtenerCargos();
            ActualizarListaCambiosCargos();

        }
        public frmCambioCargo()
        {
            InitializeComponent();
        }

        private void ActualizarListaCambiosCargos()
        {
            lstCambiosCargos.DataSource = null;
            lstCambiosCargos.DataSource = CambioCargo.ObtenerHistoricoCambioCargos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lstCambiosCargos.SelectedItem != null)
            {
                CambioCargo cambio = new CambioCargo();
                cambio.fecha = dtpFecha.Value;
                cambio.empleado = (Empleado)lstCambiosCargos.SelectedItem;
                cambio.cargoAnterior = ((Empleado)lstCambiosCargos.SelectedItem).cargo;
                cambio.cargoNuevo = (Cargo)cboCargoNuevo.SelectedValue;
                cambio.nuevoSalario = double.Parse(txtNuevoSalario.Text);

                CambioCargo.AgregarHistoricoCambioCargo(cambio);

                cambio.empleado.CambiarCargo(cambio.cargoNuevo, cambio.nuevoSalario);

                ActualizarListaCambiosCargos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCargoAnterior.Text = string.Empty;
            cboCargoNuevo.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            txtNuevoSalario.Text = string.Empty;
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedItem != null)
            {
                txtCargoAnterior.Text = ((Empleado)cboEmpleado.SelectedItem).cargo.descripcion;
            }
        }
    }
}
