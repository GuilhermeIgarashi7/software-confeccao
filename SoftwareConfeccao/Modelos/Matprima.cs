using LiteDB;
using LiteDBExample.Modelos;

namespace Modelos
{

    public class MatPrima : Item
    {
        [BsonId]
        public int Id { get; set; }
        public string Nomeitem { get; set; }

        public string Custoitem { get; set; }
        
        public string Unidademed { get; set; }

        public string Quantidade { get; set; }


        //--------------------------------------------------------------------------------------


    }

}