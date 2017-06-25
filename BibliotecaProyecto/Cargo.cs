using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaProyecto
{
    public class Cargo
    {
        public int ID_Cargo { get; set; }
        public string descripcion { get; set; }

        public static List<Cargo> ListaCargos = new List<Cargo>();

        public static void AgregarCargo(Cargo c)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConexionGlobal.CadenaConexionBaseDatos))
                {
                    //Paso 2 - Abrir la conexión
                    con.Open();

                    string textoCmd = @"insert into Cargo (ID_Cargo, Descripcion) 
                                        values (@ID_Cargo, @Descripcion)";

                    SqlCommand cmd = new SqlCommand(textoCmd, con);

                    SqlParameter p1 = new SqlParameter("@ID_Cargo", c.ID_Cargo);
                    p1.SqlDbType = SqlDbType.VarChar;

                    SqlParameter p2 = new SqlParameter("@Descripcion", c.descripcion);
                    p2.SqlDbType = SqlDbType.VarChar;

                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    
                    try
                    {
                        cmd.ExecuteNonQuery();
                        //return true;
                    }
                    catch (SqlException sqle)
                    {
                    //    return false;
                    }
                }
            }
            catch (Exception ex2)
            {
                //Error
                    //return false;
            }
        }
        public static void EliminarCargo(Cargo cargo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConexionGlobal.CadenaConexionBaseDatos))
                {
                    con.Open();

                    string textoCmd = @"Delete from Cargo 
                                        where Id_Cargo = @Id_Cargo";

                    SqlCommand cmd = new SqlCommand(textoCmd, con);

                    SqlParameter p1 = new SqlParameter("@Id_Cargo", cargo.ID_Cargo);
                    p1.SqlDbType = SqlDbType.Int;

                    cmd.Parameters.Add(p1);

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

        public static List<Cargo> ObtenerCargos()
        {
            Cargo cargo;
            try
            {
                using (SqlConnection con = new SqlConnection(ConexionGlobal.CadenaConexionBaseDatos))
                {
                    con.Open();

                    string textoCmd = @"SELECT * from Cargo";

                    SqlCommand cmd = new SqlCommand(textoCmd, con);

                    SqlDataReader elLectorDeDatos = cmd.ExecuteReader();
                    ListaCargos.Clear();
                    while (elLectorDeDatos.Read())
                    {
                        cargo = new Cargo();
                        cargo.ID_Cargo = elLectorDeDatos.GetInt32(0);
                        cargo.descripcion = elLectorDeDatos.GetString(1);
                       
                        ListaCargos.Add(cargo);
                    }
                }
                return ListaCargos;
            }
            catch (Exception ex2)
            {
                return null;
            }
        }

        public static bool ModificarCargo(Cargo cargo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConexionGlobal.CadenaConexionBaseDatos))
                {
                    con.Open();

                    string textoCmd = @"Update Cargo set Descripcion_Cargo = @Descripcion_Cargo, 
                                        where ID_Cargo = @ID_Cargo";

                    SqlCommand cmd = new SqlCommand(textoCmd, con);

                    SqlParameter p1 = new SqlParameter("@Descripcion_Cargo", cargo.descripcion);
                    p1.SqlDbType = SqlDbType.VarChar;

                    cmd.Parameters.Add(p1);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException sqle)
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex2)
            {
                //Error
                return false;
            }
        }
        public override string ToString()
        {
            return descripcion;
        }
    }
}
