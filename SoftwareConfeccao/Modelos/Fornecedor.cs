using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{

  public class Fornecedor : Pessoa
  {
    [BsonId]
    public int Id { get; set; }//
    public string Nome { get; set; }//

    public string CPF { get; set; }
    

    public string Email { get; set; }  
    public string Telefone { get; set; } // 
    public string Enderecofornecedor { get; set; }
    public string Matprimafornecedor { get; set; }//
    public string Areaproducaofornecedor { get; set; }





 


  }

}