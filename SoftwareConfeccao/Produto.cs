namespace SoftwareConfeccao;

public class Produto : Item
{
    int codproduto;

    string tempproducao;

//--------------------------------------------------------------------------------------   
    public void SetCodProduto(int codproduto)
    {
        this.codproduto = codproduto;
    }

    public int GetCodProduto()
    {
        return codproduto;
    }
//--------------------------------------------------------------------------------------   
    public void SetTempProducao(string tempprocucao)
    {
        this.tempproducao = tempprocucao;
    }

    public string GetTempProducao()
    {
        return tempproducao;
    }
//--------------------------------------------------------------------------------------   

}