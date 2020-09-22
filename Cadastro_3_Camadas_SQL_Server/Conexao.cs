using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_3_Camadas_SQL_Server
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        //Contrutor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=12V-5\SQLEXPRESS;Initial Catalog=Bd_Estudo;Integrated Security=True";
        }
        //Método para Conectar
        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Método para Desconectar
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
