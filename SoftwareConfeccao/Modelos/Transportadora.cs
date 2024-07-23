namespace Modelos;

public class Transportadora : Fornecedor
{
    int idtransportadora;

        public void Setidtransportadora(int id)
        {
            idtransportadora = id;
        }
        public int GetidTransportadora()
        {
            return idtransportadora;
        }
}