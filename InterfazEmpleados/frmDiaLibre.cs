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
    public partial class frmDiaLibre : MetroFramework.Forms.MetroForm
    {
        public frmDiaLibre()
        {
            InitializeComponent();
        }

        private void frmDiaLibre_Load(object sender, EventArgs e)
        {
            cboEmpleado.DataSource = Empleado.ObtenerEmpleados();
            ActualizarListaDiasLibres();
        }

        private void ActualizarListaDiasLibres()
        {
            lstDiasLibres.DataSource = null;
            lstDiasLibres.DataSource = DiaLibre.ObtenerDiasLibres();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboEmpleado.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DiaLibre diaLibre = new DiaLibre();
            diaLibre.empleado = (Empleado)cboEmpleado.SelectedValue;
            diaLibre.fecha = dtpFecha.Value;

            DiaLibre.AgregarDiaLibre(diaLibre);

            ActualizarListaDiasLibres();
        }
    }
}
