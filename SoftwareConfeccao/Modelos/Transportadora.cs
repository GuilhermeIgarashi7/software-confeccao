namespace Modelos;

public class Transportadora : Fornecedor
{
    int idtransportadora;

        public void Setidtransportadora(int IdT)
        {
            idtransportadora = IdT;
        }
        public int GetidTransportadora()
        {
            return idtransportadora;
        }
}