using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{

    public class Matprima : Item
    {
        [BsonId]
        public int Id { get; set; }
        public string Nomeunid { get; set; }
        public string Quantidade { get; set; }

        public string Nomematprima { get; set; }
        //--------------------------------------------------------------------------------------


    }

}