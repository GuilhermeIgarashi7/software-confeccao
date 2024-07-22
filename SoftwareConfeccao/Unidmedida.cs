namespace SoftwareConfeccao;

public class Unidmedida
{
    string nomeunid;

    int quantidade;
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
}