namespace Modelos;

public class Matprima : Item
{
    int idmatprima;

    string nomeunid;

    int quantidade;
//--------------------------------------------------------------------------------------

        public void SetIdMatPrima(int id)
        {
            idmatprima = id;
        }
        public int GetIdMatPrima()
        {
            return idmatprima;
        }
//--------------------------------------------------------------------------------------   

//--------------------------------------------------------------------------------------
    public void SetNomeunid(string unid)
    {
        this.nomeunid = unid;
    }

    public string GetNomeunid()
    {
        return nomeunid;
    }
//--------------------------------------------------------------------------------------   
    public void SetQuantidade(int q)
    {
        this.quantidade = q;
    }

    public int GetQuantidade()
    {
        return quantidade;
    }
//--------------------------------------------------------------------------------------   

}