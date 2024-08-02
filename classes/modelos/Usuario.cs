public class Usuario
{
    public string Login { get; set; }
    public string Nome { get; set; }
    public string Senha { get; set; }

    public Usuario() 
    { 
    }

    public Usuario(string login, string nome)
    {
        this.Login = login;
        this.Nome = nome;
    }
}
