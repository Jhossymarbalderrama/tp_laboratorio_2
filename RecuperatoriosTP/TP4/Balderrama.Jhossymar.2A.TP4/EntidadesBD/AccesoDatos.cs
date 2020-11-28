using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace EntidadesBD
{
    public class AccesoDatos
    {
        #region "Atributos"
            private SqlConnection conexion;
            private SqlCommand comando;
        #endregion

        #region "Constructor"
            public AccesoDatos()
            {
                this.conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
            }
        #endregion


        #region Métodos

        #region Getters
        public List<Consecionaria> ObtenerListaPersonas()
        {
            List<Consecionaria> lista = new List<Consecionaria>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                comando.CommandText = "SELECT * FROM Consecionaria ORDER BY tipo";

                this.conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    lista.Add(new Consecionaria(oDr.GetInt32(0), oDr.GetString(1), oDr.GetFloat(2), oDr.GetString(3)));
                }

                oDr.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }

        public DataTable ObtenerTablaPersonas()
        {
            DataTable tabla = new DataTable("Consecionaria");

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                this.comando.CommandText = "SELECT * FROM Consecionaria ORDER BY tipo DESC, marca";

                this.conexion.Open();

                SqlDataReader oDr = this.comando.ExecuteReader();

                tabla.Load(oDr);

                oDr.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return tabla;
        }

        public Consecionaria ObtenerPersonaPorID(int id)
        {
            Consecionaria p = null;

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@id", id);

                this.comando.CommandText = "SELECT * FROM Consecionaria WHERE id = @id";

                this.conexion.Open();

                SqlDataReader oDr = this.comando.ExecuteReader();

                if (oDr.Read())
                {
                    p = new Consecionaria(oDr.GetInt32(0), oDr.GetString(1), oDr.GetFloat(2), oDr.GetString(3));
                }

                oDr.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return p;
        }

        #endregion

        #region Insertar Persona
        public bool InsertarPersona(Consecionaria p)
        {
            bool todoOk = false;

            string sql = "INSERT INTO Almacen (marca, precio, tipo) ";
            sql += "VALUES (@marca, @precio, @tipo)";

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@marca", p.Marca);
                this.comando.Parameters.AddWithValue("@precio", p.Precio);
                this.comando.Parameters.AddWithValue("@tipo", p.Tipo);

                this.comando.CommandText = sql;

                this.conexion.Open();

                this.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return todoOk;
        }

        #endregion

        #region Modificar Persona
        public bool ModificarPersona(Consecionaria p)
        {
            bool todoOk = false;

            string sql = "UPDATE Consecionaria SET marca = @marca, precio = @precio, tipo = @tipo";
            sql += "WHERE id = @id";

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@id", p.ID);
                this.comando.Parameters.AddWithValue("@marca", p.Marca);
                this.comando.Parameters.AddWithValue("@precio", p.Precio);
                this.comando.Parameters.AddWithValue("@tipo", p.Tipo);

                this.comando.CommandText = sql;

                this.conexion.Open();

                this.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return todoOk;
        }

        #endregion

        #region Eliminar Persona
        public bool EliminarPersona(Consecionaria p)
        {
            bool todoOk = false;

            string sql = "DELETE FROM Consecionaria WHERE id = @id";

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;

                this.comando.Connection = this.conexion;

                this.comando.Parameters.AddWithValue("@id", p.ID);

                this.comando.CommandText = sql;

                this.conexion.Open();

                this.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception)
            {
                todoOk = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return todoOk;
        }

        #endregion

        #endregion

    }
}
