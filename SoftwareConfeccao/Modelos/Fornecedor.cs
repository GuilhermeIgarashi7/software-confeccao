using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{

  public class Fornecedor : Pessoa
  {
    [BsonId]
    public int idFornecedor { get; set; }
    public string Matprimafornecedor { get; set; }
    public string Areaproducaofornecedor { get; set; }

    public string Enderecofornecedor { get; set; }

    public string Nomefornecedor { get; set; }

    public string Emailfornecedor { get; set; }  

    public string Telefonefornecedor { get; set; }  
  }

}