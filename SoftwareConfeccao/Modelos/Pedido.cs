namespace Modelos;

    public class Pedido
    {

        int quantidade;

        int idpedido;

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


        public void SetIdPedido(int IdP)
        {
            idpedido = IdP;
        }

        public int GetIdPedido()
        {
            return idpedido;
        }
    //--------------------------------------------------------------------------------------
            public void SetFrete(string f)
            {
                this.frete = f;
            }

            public string GetEndereco()
            {
                return frete;
            }
    //--------------------------------------------------------------------------------------
            public void SetPrazo(string p)
            {
                this.prazo = p;
            }

            public string GetPrazo()
            {
                return prazo;
            }
    //--------------------------------------------------------------------------------------
            public void SetPedido(string ped)
            {
                this.pedido = ped;
            }

            public string GetPedido()
            {
                return pedido;
            }
    //--------------------------------------------------------------------------------------
            public void SetObservacao(string obs)
            {
                this.observacao = obs;
            }

            public string GetObservacao()
            {
                return observacao;
            }
    }
