namespace SoftwareConfeccao;

public class Transportadora : Fornecedor
{
    int codtransportadora;

    public void SetCodTransportadora(int codtransportadora)
    {
        this.codtransportadora = codtransportadora;
    }
    public int GetCodTransportadora()
    {
        return codtransportadora;
    }
}