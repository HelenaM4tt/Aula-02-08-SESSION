using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Web.UI.WebControls;

public class Usuarios : Banco
{
    public Usuario Acessar(string login, string senha)
    {
        Usuario usuario = null;
        try
        {

            string comando = $@"Select nm_login, nm_usuario from usuario where nm_login = '{login}' and nm_senha = '{senha}'";
            MySqlDataReader dados = Consultar(comando);
            if (dados.Read())
            {
                usuario = new Usuario(dados.GetString("nm_login"), dados.GetString("nm_usuario"));
            }
            if (dados != null)
            {
                if (!dados.IsClosed) {
                    dados.Close();
                }
            }
        }
        catch (System.Exception)
        {
            throw new System.Exception("Login e/ou Senha Inválidas!");
        }
        finally
        {
            Desconectar();
        }
        return usuario;
    }

    public Usuario BuscarDados(string login)
    {
        Usuario usuario = null;
        try
        {

            string comando = $@"Select nm_login, nm_usuario from usuario where nm_login = '{login}'";
            MySqlDataReader dados = Consultar(comando);
            if (dados.Read())
            {
                usuario = new Usuario(dados.GetString("nm_login"), dados.GetString("nm_usuario"));
            }
            if (dados != null)
            {
                if (!dados.IsClosed)
                {
                    dados.Close();
                }
            }
        }
        catch (System.Exception)
        {
            throw new System.Exception("Não foi possível buscar dados do usuário!");
        }
        finally
        {
            Desconectar();
        }
        return usuario;
    }

    public Usuario AlterarSenha(string login, string senha, string novaSenha)
    {
        Usuario usuario = null;
        try
        {
            usuario = Acessar(login, senha);
            if (usuario != null)
            {
                string comando = $@"Update usuario set nm_senha = '{novaSenha}' where nm_login = '{login}'";
                Executar(comando);
            }
        }
        catch (System.Exception)
        {
            throw new System.Exception("Não foi possível alterar a senha!");
        }

        return usuario;
    }
}
