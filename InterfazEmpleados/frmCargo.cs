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
    public partial class frmCargo : MetroFramework.Forms.MetroForm
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            ActualizarListaCargos();
        }

        private void ActualizarListaCargos()
        {
            lstCargos.DataSource = null;
            lstCargos.DataSource = Cargo.ObtenerCargos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cargo cargo = new Cargo();
            cargo.descripcion = txtDescripcion.Text;

            Cargo.AgregarCargo(cargo);

            ActualizarListaCargos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstCargos.SelectedItem != null)
            {
                Cargo cargoSeleccionado = (Cargo)lstCargos.SelectedItem;
                cargoSeleccionado.descripcion = txtDescripcion.Text;

                Cargo.ModificarCargo(cargoSeleccionado);
                ActualizarListaCargos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCargos.SelectedItem != null)
            {
                Cargo cargoSeleccionado = (Cargo)lstCargos.SelectedItem;

                Cargo.EliminarCargo(cargoSeleccionado);

                ActualizarListaCargos();
            }
        }

        private void lstCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCargos.SelectedItem != null)
            {
                Cargo cargoSeleccionado = (Cargo)lstCargos.SelectedItem;

                txtDescripcion.Text = cargoSeleccionado.descripcion;

            }
        }
    }
}
