namespace SoftwareConfeccao;

public class Pedido
{

    int quantidade;

    int codpedido;

    string frete;

    string prazo;

    string pedido;

    string observacao;


//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public void SetQuantidade(int quantidade)
    {
        this.quantidade = quantidade;
    }

    public int GetQuantidade()
    {
        return quantidade;
    }
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    public void SetCodPedido(int codpedido)
    {
        this.codpedido = codpedido;
    }

    public int GetCodPedido()
    {
        return codpedido;
    }
//--------------------------------------------------------------------------------------
        public void SetFrete(string frete)
        {
            this.frete = frete;
        }

        public string GetEndereco()
        {
            return frete;
        }
//--------------------------------------------------------------------------------------
        public void SetPrazo(string prazo)
        {
            this.prazo = prazo;
        }

        public string GetPrazo()
        {
            return prazo;
        }
//--------------------------------------------------------------------------------------
        public void SetPedido(string pedido)
        {
            this.pedido = pedido;
        }

        public string GetPedido()
        {
            return pedido;
        }
//--------------------------------------------------------------------------------------
        public void SetObservacao(string observacao)
        {
            this.observacao = observacao;
        }

        public string GetObservacao()
        {
            return observacao;
        }
}