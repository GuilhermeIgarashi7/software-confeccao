namespace Modelos;


    public class Produto : Odin
    {
        int idproduto;

        string tempproducao;

    //--------------------------------------------------------------------------------------   
    //--------------------------------------------------------------------------------------

            public void SetIdProduto(int IdPR)
            {
                idproduto = IdPR;
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
