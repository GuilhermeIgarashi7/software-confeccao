using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{

  public class Cliente : Pessoa
  {
    [BsonId]
    public int idCliente { get; set; }
    public string Nomecliente { get; set; }
    public string Email { get; set; }

    public string Telefone { get; set; }
  }



}