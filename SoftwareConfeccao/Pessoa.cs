namespace SoftwareConfeccao;
public class Pessoa
{
    string nome;
    string telefone;

    string email;
//--------------------------------------------------------------------------------------

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public string GetNome()
    {
        return nome;
    }
//--------------------------------------------------------------------------------------
    public void SetTelefone(string telefone)
    {
        this.telefone = telefone;
    }    

    public string GetTelefone()
    {
        return telefone;
    }
//--------------------------------------------------------------------------------------
    public void SetEmail(string email)
    {
        this.email = email;
    }    

    public string GetTelefone()
    {
        return email;
    }

}

