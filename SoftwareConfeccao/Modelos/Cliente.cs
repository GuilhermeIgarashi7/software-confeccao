namespace Modelos;

        public class Cliente : Pessoa
    {
        int idcliente;

        public void SetIdCliente(int Id)
        {
            idcliente = Id;
        }

        public int GetIdCliente()
        {
            return idcliente;
        }
    }