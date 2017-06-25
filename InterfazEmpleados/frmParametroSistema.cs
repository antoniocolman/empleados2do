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
    public partial class frmParametroSistema : MetroFramework.Forms.MetroForm
    {
        public frmParametroSistema()
        {
            InitializeComponent();
        }

        private void ActualizarListaParametros()
        {
            lstParametros.DataSource = null;
            lstParametros.DataSource = ParametroSistema.ObtenerParametrosSistema();
        }

        private void frmParametroSistema_Load(object sender, EventArgs e)
        {
            ActualizarListaParametros();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpHorarioEntrada.Value = DateTime.Now;
            dtpHorarioSalida.Value = DateTime.Now;
            txtTolerancia.Text = string.Empty;
            txtMaxVacaciones.Text = string.Empty;
            rdbActivo.Checked = true;
            rdbInactivo.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Horario horarioEntrada = new Horario();
            horarioEntrada.Hora = dtpHorarioEntrada.Value.Hour;
            horarioEntrada.Hora = dtpHorarioEntrada.Value.Minute;

            Horario horarioSalida = new Horario();
            horarioSalida.Hora = dtpHorarioSalida.Value.Hour;
            horarioSalida.Hora = dtpHorarioSalida.Value.Minute;

            ParametroSistema parametro = new ParametroSistema();
            parametro.horarioEntrada = horarioEntrada;
            parametro.horarioSalida = horarioSalida;
            parametro.minutosTolerancia = int.Parse(txtTolerancia.Text);
            parametro.maxDiasVacacionesAcumulados = int.Parse(txtMaxVacaciones.Text);
            parametro.activo = (rdbActivo.Checked) ? true : false;

            ParametroSistema.AgregarParametroSistema(parametro);

            ActualizarListaParametros();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstParametros.SelectedItem != null)
            {
                Horario horarioEntrada = new Horario();
                horarioEntrada.Hora = dtpHorarioEntrada.Value.Hour;
                horarioEntrada.Minutos = dtpHorarioEntrada.Value.Minute;

                Horario horarioSalida = new Horario();
                horarioSalida.Hora = dtpHorarioSalida.Value.Hour;
                horarioSalida.Minutos = dtpHorarioSalida.Value.Minute;

                ParametroSistema parametroSeleccionado = (ParametroSistema)lstParametros.SelectedItem;

                parametroSeleccionado.horarioEntrada = horarioEntrada;
                parametroSeleccionado.horarioSalida = horarioSalida;
                parametroSeleccionado.minutosTolerancia = int.Parse(txtTolerancia.Text);
                parametroSeleccionado.maxDiasVacacionesAcumulados = int.Parse(txtMaxVacaciones.Text);
                parametroSeleccionado.activo = (rdbActivo.Checked) ? true : false;

                ActualizarListaParametros();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstParametros.SelectedItem != null)
            {
                ParametroSistema parametroSeleccionado = (ParametroSistema)lstParametros.SelectedItem;

                ParametroSistema.EliminarParametroSistema(parametroSeleccionado);

                ActualizarListaParametros();
            }
        }

        private void lstParametros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstParametros.SelectedItem != null)
            {
                ParametroSistema p = (ParametroSistema)lstParametros.SelectedItem;
                dtpHorarioEntrada.Value = (DateTime.Now).Date.AddHours(p.horarioEntrada.Hora).AddMinutes(p.horarioEntrada.Minutos);
                dtpHorarioSalida.Value = (DateTime.Now).Date.AddHours(p.horarioSalida.Hora).AddMinutes(p.horarioSalida.Minutos);
                txtTolerancia.Text = p.minutosTolerancia.ToString();
                txtMaxVacaciones.Text = p.maxDiasVacacionesAcumulados.ToString();
                rdbActivo.Checked = (p.activo) ? true : false;
                rdbInactivo.Checked = (p.activo) ? false : true;
            }
        }
    }
}
