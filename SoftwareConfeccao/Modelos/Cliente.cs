namespace Modelos;

        public class Cliente : Pessoa
    {
        int idcliente;

        public void SetIdCliente(int IdC)
        {
            idcliente = IdC;
        }

        public int GetIdCliente()
        {
            return idcliente;
        }
    }