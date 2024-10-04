using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{

  public class Cliente : Pessoa
  {
    [BsonId]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public string CPF { get; set; }

    public string Telefone { get; set; }
  }



}