using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto
{
    public enum TipoDocumento { CI, DNI, Pasaporte }
    public enum Estado { Activo, Inactivo }

    public class Empleado
    {
        public int ID_empleado { get; set; }
        public int codigo { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string nroDocumento { get; set; }
        public TipoDocumento tipoDocumento { get; set; }
        public string nroCelular { get; set; }
        public DateTime fechaIngreso { get; set; }

        public Cargo cargo = new Cargo();
        public int diasVacacionesAcumulados { get; set; }
        public float diasLibresAFavor { get; set; }
        public double salarioBase { get; set; }
        public Estado estado { get; set; }

        public static List<Empleado> ListaEmpleados = new List<Empleado>();

        public Empleado()
        {
            estado = Estado.Activo;
            diasVacacionesAcumulados = 0;
            diasLibresAFavor = 0;
        }

        public static void AgregarEmpleado (Empleado empleado)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConexionGlobal.CadenaConexionBaseDatos))
                {
                    con.Open();

                    string textoCmd = @"insert into Empleado (Nombres, Apellidos, Direccion, Nro_Documento
                                        Tipo_Documento, Nro_Celular, Fecha_Ingreso, Cargo_Actual, Dias_Vacaciones,
                                         Dias_Libres, Estado, Salario_Base_Actual) 
                                        values (@Nombre, @Apellido, @Nombres, @Apellidos, @Direccion, @Nro_Documento
                                        @Tipo_Documento, @Nro_Celular, @Fecha_Ingreso, @Cargo_Actual, @Dias_Vacaciones,
                                         @Dias_Libres, @Estado, @Salario_Base_Actual)";

                    SqlCommand cmd = new SqlCommand(textoCmd, con);

                    SqlParameter p1 = new SqlParameter("@Nombres", empleado.nombres);
                    p1.SqlDbType = SqlDbType.VarChar;

                    SqlParameter p2 = new SqlParameter("@Apellidos", empleado.apellidos);
                    p2.SqlDbType = SqlDbType.VarChar;

                    SqlParameter p3 = new SqlParameter("@Direccion", empleado.direccion);
                    p3.SqlDbType = SqlDbType.VarChar;

                    SqlParameter p4 = new SqlParameter("@Nro_Documento", empleado.nroDocumento);
                    p4.SqlDbType = SqlDbType.VarChar;

                    SqlParameter p5 = new SqlParameter("@Tipo_Documento", empleado.tipoDocumento);
                    p4.SqlDbType = SqlDbType.VarChar;

                    SqlParameter p6 = new SqlParameter("@Nro_Celular", empleado.nroCelular);
                    p4.SqlDbType = SqlDbType.VarChar;

                    SqlParameter p7 = new SqlParameter("@Fecha_Ingreso", empleado.fechaIngreso);
                    p4.SqlDbType = SqlDbType.DateTime;

                    SqlParameter p8 = new SqlParameter("@Cargo_Actual", empleado.cargo);
                    p4.SqlDbType = SqlDbType.VarChar;

                    SqlParameter p9 = new SqlParameter("@Dias_Vacaciones", empleado.diasVacacionesAcumulados);
                    p4.SqlDbType = SqlDbType.Int;

                    SqlParameter p10 = new SqlParameter("@Dias_Libres", empleado.diasLibresAFavor);
                    p4.SqlDbType = SqlDbType.Int;

                    SqlParameter p11 = new SqlParameter("@Estado", empleado.estado);
                    p4.SqlDbType = SqlDbType.VarChar;

                    SqlParameter p12 = new SqlParameter("@Salario_Base_Actual", empleado.salarioBase);
                    p4.SqlDbType = SqlDbType.Int;

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);
                    cmd.Parameters.Add(p7);
                    cmd.Parameters.Add(p8);
                    cmd.Parameters.Add(p9);
                    cmd.Parameters.Add(p10);
                    cmd.Parameters.Add(p11);
                    cmd.Parameters.Add(p12);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        //return true;
                    }
                    catch (SqlException sqle)
                    {
                       // return false;
                    }
                }
            }
            catch (Exception ex2)
            {
                //Error
                //return false;
            }

        }

        public static void EliminarEmpleado(Empleado e)
        {
            ListaEmpleados.Remove(e);
        }

        public static List<Empleado> ObtenerEmpleados()
        {
            Empleado empleado;
            try
            {
                using (SqlConnection con = new SqlConnection(ConexionGlobal.CadenaConexionBaseDatos))
                {
                    con.Open();

                    string textoCmd = @"SELECT * from Empleado";

                    SqlCommand cmd = new SqlCommand(textoCmd, con);

                    SqlDataReader elLectorDeDatos = cmd.ExecuteReader();
                    ListaEmpleados.Clear();
                    while (elLectorDeDatos.Read())
                    {
                        empleado = new Empleado();
                        empleado.ID_empleado = elLectorDeDatos.GetInt32(0);
                        empleado.nombres = elLectorDeDatos.GetString(1);
                        empleado.apellidos = elLectorDeDatos.GetString(2);
                        empleado.direccion = elLectorDeDatos.GetString(3);
                        empleado.nroDocumento = elLectorDeDatos.GetString(4);
                        //empleado.tipoDocumento = elLectorDeDatos.GetString(5);
                        empleado.nroCelular = elLectorDeDatos.GetString(6);
                        empleado.fechaIngreso = elLectorDeDatos.GetDateTime(7);
                        //empleado.cargo = elLectorDeDatos.GetString(8);
                        empleado.diasVacacionesAcumulados = elLectorDeDatos.GetInt32(9);
                        //empleado.estado = elLectorDeDatos.GetString(10);
                        empleado.salarioBase = elLectorDeDatos.GetInt32(11);

                        ListaEmpleados.Add(empleado); //Agregamos a la lista
                    }
                }
                return ListaEmpleados;
            }
            catch (Exception ex2)
            {
                return null;
            }
        }



        public static Empleado ObtenerEmpleadoPorCodigo(int codigo)
        {
            foreach (Empleado empleado in ListaEmpleados)
            {
                if (codigo == empleado.codigo)
                    return empleado;
            }
            return null;

        }

        public void DesvincularEmpleado()
        {
            estado = Estado.Inactivo;
        }

        public void CambiarCargo(Cargo nuevoCargo, double nuevoSalario)
        {
            cargo = nuevoCargo;
            salarioBase = nuevoSalario;
        }

        public void AgregarDiaLibreAFavor(HoraExtra h)
        {
            diasLibresAFavor += (h.cantidadHorasAcumuladas - h.cantidadHorasCanjeadas) / 8;
        }

        public static void CalularVacaciones()
        {
            ParametroSistema parametroSistema = ParametroSistema.ObtenerParametroSistemaActivo();

            foreach (Empleado empleado in ListaEmpleados)
            {
                // TODO - VOLVER A REVISAR ESTA CONDICION
                if ((empleado.fechaIngreso.Year - DateTime.Today.Year) == 1)
                {
                    if ((empleado.diasVacacionesAcumulados + 12) > parametroSistema.maxDiasVacacionesAcumulados)
                        empleado.diasVacacionesAcumulados += 12;
                    else
                        empleado.diasVacacionesAcumulados = parametroSistema.maxDiasVacacionesAcumulados;
                }
            }
        }

        public override string ToString()
        {
            return nombres;
        }
    }
}
