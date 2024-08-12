using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{

  public class Fornecedor : Pessoa
  {
    [BsonId]
    public int idFornecedor { get; set; }
    public string Matprima { get; set; }
    public string Areaproducao { get; set; }

    public string Endereco { get; set; }

    public string Nomefornecedor { get; set; }
  }

}