namespace SoftwareConfeccao;

        public class Cliente : Pessoa
    {
        int codcliente;

        public void SetCodCliente(int codcliente)
        {
            this.codcliente = codcliente;
        }
        public int GetCodCliente()
        {
            return codcliente;
        }
    }