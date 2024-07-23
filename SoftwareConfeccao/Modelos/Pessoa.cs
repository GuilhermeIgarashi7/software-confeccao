namespace Modelos;
public class Pessoa
{
    string nome;
    string telefone;

    string email;

//--------------------------------------------------------------------------------------

    public void SetNome(string n)
    {
        this.nome = n;
    }

    public string GetNome()
    {
        return nome;
    }
//--------------------------------------------------------------------------------------
    public void SetTelefone(string t)
    {
        this.telefone = t;
    }    

    public string GetTelefone()
    {
        return telefone;
    }
//--------------------------------------------------------------------------------------
    public void SetEmail(string e)
    {
        this.email = e;
    }    

    public string GetEmail()
    {
        return email;
    }




}

