namespace Modelos;

public class Produto : Item
{
    int idproduto;

    string tempproducao;

//--------------------------------------------------------------------------------------   
//--------------------------------------------------------------------------------------

        public void SetIdProduto(int id)
        {
            idproduto = id;
        }
        public int Getidproduto()
        {
            return idproduto;
        }
//--------------------------------------------------------------------------------------   
    public void SetTempProducao(string t)
    {
        this.tempproducao = t;
    }

    public string GetTempProducao()
    {
        return tempproducao;
    }
//--------------------------------------------------------------------------------------   

}