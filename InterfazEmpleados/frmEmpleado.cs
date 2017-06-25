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
    public partial class frmEmpleado : MetroFramework.Forms.MetroForm
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            cboTipoDoc.DataSource = Enum.GetValues(typeof(TipoDocumento));
            cboCargo.DataSource = Cargo.ObtenerCargos();
            ActualizarListaEmpleados();
        }

        private void ActualizarListaEmpleados()
        {
            lstEmpleados.DataSource = null;
            lstEmpleados.DataSource = Empleado.ObtenerEmpleados();
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNroDoc.Text = string.Empty;
            cboTipoDoc.SelectedIndex = -1;
            txtCelular.Text = string.Empty;
            dtpFechaIngreso.Value = DateTime.Now;
            cboCargo.SelectedIndex = -1;
            txtSalarioBase.Text = string.Empty;
            rdbInactivo.Checked = false;
            rdbActivo.Checked = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.codigo = Empleado.ObtenerEmpleados().Count + 1;
            empleado.nombres = txtNombres.Text;
            empleado.apellidos = txtApellidos.Text;
            empleado.direccion = txtDireccion.Text;
            empleado.nroDocumento = txtNroDoc.Text;
           // empleado.tipoDocumento = (TipoDocumento)cboTipoDoc.SelectedValue;
            empleado.nroCelular = txtCelular.Text;
            empleado.fechaIngreso = dtpFechaIngreso.Value;
           // empleado.cargo = (Cargo)cboCargo.SelectedValue;
            empleado.salarioBase = int.Parse(txtSalarioBase.Text);
            empleado.estado = (rdbActivo.Checked) ? Estado.Activo : Estado.Inactivo;

            Empleado.AgregarEmpleado(empleado);

            ActualizarListaEmpleados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstEmpleados.SelectedItem != null)
            {
                Empleado empleadoSeleccionado = (Empleado)lstEmpleados.SelectedItem;

                empleadoSeleccionado.nombres = txtNombres.Text;
                empleadoSeleccionado.apellidos = txtApellidos.Text;
                empleadoSeleccionado.direccion = txtDireccion.Text;
                empleadoSeleccionado.nroDocumento = txtNroDoc.Text;
               // empleadoSeleccionado.tipoDocumento = (TipoDocumento)cboTipoDoc.SelectedValue;
                empleadoSeleccionado.nroCelular = txtCelular.Text;
                empleadoSeleccionado.fechaIngreso = dtpFechaIngreso.Value;
               // empleadoSeleccionado.cargo = (Cargo)cboCargo.SelectedValue;
                empleadoSeleccionado.salarioBase = double.Parse(txtSalarioBase.Text);
                if(rdbActivo.Checked)
                {
                    empleadoSeleccionado.estado = Estado.Activo;
                }
                else
                {
                    empleadoSeleccionado.estado = Estado.Inactivo;
                }
                ActualizarListaEmpleados();
            }
        }

        private void btnDesvincular_Click(object sender, EventArgs e)
        {
            if (lstEmpleados.SelectedItem != null)
            {
                Empleado empleadoSeleccionado = (Empleado)lstEmpleados.SelectedItem;

                empleadoSeleccionado.DesvincularEmpleado();

                ActualizarListaEmpleados();
            }
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEmpleados.SelectedItem != null)
            {
                Empleado empleadoSeleccionado = (Empleado)lstEmpleados.SelectedItem;

                txtNombres.Text = empleadoSeleccionado.nombres;
                txtApellidos.Text = empleadoSeleccionado.apellidos;
                txtDireccion.Text = empleadoSeleccionado.direccion;
                txtNroDoc.Text = empleadoSeleccionado.nroDocumento.ToString();
                cboTipoDoc.SelectedItem = empleadoSeleccionado.tipoDocumento;
                txtCelular.Text = empleadoSeleccionado.nroCelular.ToString();
                dtpFechaIngreso.Value = empleadoSeleccionado.fechaIngreso;
                cboCargo.SelectedItem = empleadoSeleccionado.cargo;
                txtSalarioBase.Text = empleadoSeleccionado.salarioBase.ToString();
            }
        }
    }
}
