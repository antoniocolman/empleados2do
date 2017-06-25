using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Empleados
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=localhost; Initial Catalog=sistemadenomina; Integrated Security=true");
            //prueba commityyu
            try
            {
                SqlCommand cmd = new SqlCommand("select nombre, contrasena from usuarios where nombre ='" + txtUsuario.Text + "' and contrasena ='" + txtContrasena.Text + "'", con);
                con.Open();
                Console.WriteLine("abierta");
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "usuarios");
                DataRow row;
                row = ds.Tables["usuarios"].Rows[0];

                if ((txtUsuario.Text == row["nombre"].ToString()) || (txtContrasena.Text == row["contrasena"].ToString()))
                {
                    FormPrincipal p = new FormPrincipal();
                    p.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al loguearse");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
