namespace Modelos;


    public class Unidmedida
    {
        string nomeunid;

        int quantidade;

        int idmedida;
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

            public void SetIdMedida(int IdU)
            {
                idmedida = IdU;
            }
            public int Getidmedida()
            {
                return idmedida;
            }
    }
