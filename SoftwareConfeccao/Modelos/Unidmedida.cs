using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{

    public class Unidmedida : Registro
    {
        [BsonId]
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public string NomeUnid { get; set; }


    }

}