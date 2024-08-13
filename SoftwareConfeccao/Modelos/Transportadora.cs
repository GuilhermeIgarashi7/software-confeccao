using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{
    public class Transportadora : Pessoa
    {
        [BsonId]
        public int idTransportadora { get; set; }
        public string Telefonetransportadora { get; set; }

        public string Nometransportadora { get; set; }


    }

}