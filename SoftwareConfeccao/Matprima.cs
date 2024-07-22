namespace SoftwareConfeccao;

public class Matprima : Item
{
    int codmatprima;

    string nomeunid;

    int quantidade;
//--------------------------------------------------------------------------------------   
    public void SetCodMatPrima(int codmatprima)
    {
        this.codmatprima = codmatprima;
    }

    public int GetCodMatPrima()
    {
        return codmatprima;
    }
//--------------------------------------------------------------------------------------   

//--------------------------------------------------------------------------------------
    public void SetNomeunid(string nomeunid)
    {
        this.nomeunid = nomeunid;
    }

    public string GetNomeunid()
    {
        return nomeunid;
    }
//--------------------------------------------------------------------------------------   
    public void SetQuantidade(int quantidade)
    {
        this.quantidade = quantidade;
    }

    public int GetQuantidade()
    {
        return quantidade;
    }
//--------------------------------------------------------------------------------------   

}