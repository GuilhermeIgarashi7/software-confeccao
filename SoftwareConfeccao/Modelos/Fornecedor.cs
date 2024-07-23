namespace Modelos;
public class Fornecedor : Pessoa
{
        int idfornecedor;
        string matprima;


        string areaproducao;

        string endereco;
//--------------------------------------------------------------------------------------

        public void SetIdFornecedor(int id)
        {
            idfornecedor = id;
        }
        public int GetIdFornecedor()

        {
            return idfornecedor;
        }
//--------------------------------------------------------------------------------------
        public void SetMatPrima(string m)
        {
            this.matprima = m;
        }

        public string GetMatPrima()
        {
            return matprima;
        }
//--------------------------------------------------------------------------------------
        public void SetAreaProducao(string ap)
        {
            this.areaproducao = ap;
        }

        public string GetAreaProducao()
        {
            return areaproducao;
        }
//--------------------------------------------------------------------------------------
        public void SetEndereco(string en)
        {
            this.endereco = en;
        }

        public string GetEndereco()
        {
            return endereco;
        }
//--------------------------------------------------------------------------------------
}