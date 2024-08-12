using LiteDB;

namespace LiteDBExample.Modelos;

public class Item : Registro
{
  [BsonId]
  public int Id { get; set; }
  public string Nomeitem { get; set; }
  public string Custoitem { get; set; }

}
