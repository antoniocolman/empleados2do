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
    public partial class frmMenuPrincipal : MetroFramework.Forms.MetroForm
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            Empleado.CalularVacaciones();
        }


        private void menuSistemaSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuMantenimientoEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleado form = new frmEmpleado();
            form.ShowDialog();
        }

        private void menuMantenimientoCargos_Click(object sender, EventArgs e)
        {
            frmCargo form = new frmCargo();
            form.ShowDialog();
        }

        private void menuRegistrosCambiosCargo_Click(object sender, EventArgs e)
        {
            frmCambioCargo form = new frmCambioCargo();
            form.ShowDialog();
        }

        private void menuSistemaParametros_Click(object sender, EventArgs e)
        {
            frmParametroSistema form = new frmParametroSistema();
            form.ShowDialog();
        }

        private void menuMantenimientoReposos_Click(object sender, EventArgs e)
        {
            frmReposo form = new frmReposo();
            form.ShowDialog();
        }

        private void menuRegistroHorasExtras_Click(object sender, EventArgs e)
        {
            frmHoraExtra form = new frmHoraExtra();
            form.ShowDialog();
        }

        private void menuRegistroMarcaciones_Click(object sender, EventArgs e)
        {
            frmMarcacion form = new frmMarcacion();
            form.ShowDialog();
        }

        private void menuRegistroDiasLibres_Click(object sender, EventArgs e)
        {
            frmDiaLibre form = new frmDiaLibre();
            form.ShowDialog();
        }
    }
}
