using MySql.Data.MySqlClient;
using System;
using System.Data;

public class Banco
{
    MySqlConnection conexao = null;

    protected void Conectar()
    {
        string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=santos";
        conexao = new MySqlConnection(linhaConexao);
        try
        {
            conexao.Open();
        }
        catch 
        {
            throw new Exception("Erro ao conectar ao Servidor");
        }
    }

    protected void Desconectar()
    { 
        if (conexao != null)
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }

    protected MySqlDataReader Consultar(string comando)
    {
        try
        {
            Conectar();
            MySqlCommand cSQL = new MySqlCommand(comando, conexao);
            return cSQL.ExecuteReader();
        }
        catch
        {
            throw new Exception("Erro na consulta");
        }
    }

    protected void Executar(string comando)
    { 
        try
        { 
            Conectar();
            MySqlCommand cSQL = new MySqlCommand(comando, conexao);
            cSQL.ExecuteNonQuery();
        }
        catch
        {
            throw new Exception("Erro na execucao");
        }
        finally
        {
            Desconectar();
        }
    }
}

