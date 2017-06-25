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
    public partial class frmReposo : MetroFramework.Forms.MetroForm
    {
        public frmReposo()
        {
            InitializeComponent();
        }

        private void frmReposo_Load(object sender, EventArgs e)
        {
            cboEmpleado.DataSource = Empleado.ObtenerEmpleados();
            ActualizarListaReposos();
        }

        private void ActualizarListaReposos()
        {
            lstReposos.DataSource = null;
            lstReposos.DataSource = Reposo.ObtenerReposos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboEmpleado.SelectedIndex = -1;
            txtObservacion.Text = string.Empty;
            dtpFechaInicio.Value = DateTime.Now;
            txtCantidadDias.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Reposo reposo = new Reposo();
            reposo.empleado = (Empleado)cboEmpleado.SelectedValue;
            reposo.observacion = txtObservacion.Text;
            reposo.fechaInicio = dtpFechaInicio.Value;
            reposo.cantidadDias = int.Parse(txtCantidadDias.Text);

            Reposo.AgregarReposo(reposo);

            ActualizarListaReposos();
        }

        private void lstReposos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstReposos.SelectedItem != null)
            {
                Reposo reposo = (Reposo)lstReposos.SelectedItem;

                cboEmpleado.SelectedItem = reposo.empleado;
                txtObservacion.Text = reposo.observacion;
                dtpFechaInicio.Value = reposo.fechaInicio;
                txtCantidadDias.Text = reposo.cantidadDias.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstReposos.SelectedItem != null)
            {
                Reposo reposo = (Reposo)lstReposos.SelectedItem;

                reposo.empleado = (Empleado)cboEmpleado.SelectedValue;
                reposo.observacion = txtObservacion.Text;
                reposo.fechaInicio = dtpFechaInicio.Value;
                reposo.cantidadDias = int.Parse(txtCantidadDias.Text);

                Reposo.AgregarReposo(reposo);

                ActualizarListaReposos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstReposos.SelectedItem != null)
            {
                Reposo reposo = (Reposo)lstReposos.SelectedItem;

                Reposo.EliminarReposo(reposo);

                ActualizarListaReposos();
            }
        }
    }
}
