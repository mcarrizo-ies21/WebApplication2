using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;


namespace WebApplication2
{
    public class Datos
    {

        private SqlConnection conector;
        private SqlCommand comando;
        private string sql;


        private int codigo;
        private string nombre;
        private int stock;

        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public Datos()
        {
            conector = new SqlConnection("Data Source=.;Initial Catalog=AutoFeliz;Integrated Security=True");
            comando = new SqlCommand();
            comando.Connection = conector;
            comando.CommandType = CommandType.Text;
            sql = "";
        }
        public Datos(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        public void buscar()
        {
            sql = "SELECT * FROM Repuestos WHERE codigo=@codigo";
            comando.CommandText = sql;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@codigo", codigo);
            conector.Open();
            SqlDataReader dr = comando.ExecuteReader();
            dr.Read();
            nombre = dr["nombre"].ToString();

            conector.Close();
        }

    }
}