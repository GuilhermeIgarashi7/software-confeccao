namespace SoftwareConfeccao;
public class Fornecedor : Pessoa
{
        int codfornecedor;
        string matprima;

        string areaproducao;

        string endereco;
//--------------------------------------------------------------------------------------

        public void SetCodFornecedor(int codfornecedor)
        {
            this.codfornecedor = codfornecedor;
        }
        public int GetCodFornecedor()
        {
            return codfornecedor;
        }
//--------------------------------------------------------------------------------------
        public void SetMatPrima(string matprima)
        {
            this.matprima = matprima;
        }

        public string GetMatPrima()
        {
            return matprima;
        }
//--------------------------------------------------------------------------------------
        public void SetAreaProducao(string areaproducao)
        {
            this.areaproducao = areaproducao;
        }

        public string GetAreaProducao()
        {
            return areaproducao;
        }
//--------------------------------------------------------------------------------------
        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public string GetEndereco()
        {
            return endereco;
        }
//--------------------------------------------------------------------------------------
}