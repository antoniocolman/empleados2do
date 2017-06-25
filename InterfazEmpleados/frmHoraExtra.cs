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
    public partial class frmHoraExtra : MetroFramework.Forms.MetroForm
    {
        public frmHoraExtra()
        {
            InitializeComponent();
        }

        private void frmHoraExtra_Load(object sender, EventArgs e)
        {
            cboEmpleado.DataSource = Empleado.ObtenerEmpleados();
            ActualizarListaHoraExtra();
        }
   
        private void ActualizarListaHoraExtra()
        {
            lstHorasExtra.DataSource = null;
            lstHorasExtra.DataSource = HoraExtra.ObtenerHorasExtra();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HoraExtra horaExtra = new HoraExtra();
            horaExtra.empleado = (Empleado)cboEmpleado.SelectedValue;
            horaExtra.fecha = dtpFecha.Value;
            horaExtra.cantidadHorasAcumuladas = int.Parse(txtCantidadHoras.Text);

            HoraExtra.AgregarHoraExtra(horaExtra);

            ActualizarListaHoraExtra();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboEmpleado.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            txtCantidadHoras.Text = string.Empty;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
