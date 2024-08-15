using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{

  public class Fornecedor : Pessoa
  {
    [BsonId]
    public int idFornecedor { get; set; }
    public string Matprima { get; set; }
    public string AreaproducaoFornecedor { get; set; }

    public string Enderecofornecedor { get; set; }

    public string Nomefornecedor { get; set; }

    public string Emailfornecedor { get; set; }  

    public string Telefonefornecedor { get; set; }  
  }

}