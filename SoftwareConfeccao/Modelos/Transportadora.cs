using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{
    public class Transportadora : Pessoa
    {
        [BsonId]
        public int Id { get; set; }
        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Nome { get; set; }


    }

}