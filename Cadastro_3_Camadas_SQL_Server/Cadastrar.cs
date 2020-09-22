using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_3_Camadas_SQL_Server
{
    public class Cadastrar
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public string msg = "";
        public Cadastrar(string nome, string telefone)
        {
            //Comando Sql (Insert, Update e Delete) -- SqlComand
            cmd.CommandText = "INSERT INTO cadastro (Nome, Telefone) VALUES(@nome, @telefone)";
            //Parametros
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@telefone",telefone);
            //Conectar com o BD -- Classe Conexao
            try
            {
                cmd.Connection = conexao.Conectar();
                //Executar o comando
                cmd.ExecuteNonQuery();
                //Desconectar com o BD
                conexao.Desconectar();
                //Mensagem de Sucesso ou Erro -- String Mesagem
                this.msg = "Cadastrado com Sucesso!";
            }
            catch (SqlException e)
            {
                this.msg = "Error: " + e.Message;
            }
            
            
        }
    }
}
