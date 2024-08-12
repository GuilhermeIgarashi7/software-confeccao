using LiteDBExample.Modelos;
using Modelos;

namespace Controles
{

    public class ControleMatPrima : ControleBase
    {        
        //----------------------------------------------------------------------------

        public ControleMatPrima() : base()
        {
            NomeDaTabela = "Matprima";
        }

        //----------------------------------------------------------------------------

        public virtual Registro? Ler(int idMatprima)
        {
            var collection = liteDB.GetCollection<Matprima>(NomeDaTabela);
            return collection.FindOne(d => d.Id == idMatprima);
        }

        //----------------------------------------------------------------------------

        public virtual List<Matprima>? LerTodos()
        {
            var tabela = liteDB.GetCollection<Matprima>(NomeDaTabela);
            return new List<Matprima>(tabela.FindAll().OrderBy(d => d.Nomematprima));
        }

        //----------------------------------------------------------------------------

        public virtual void Apagar(int idMatprima)
        {
            var collection = liteDB.GetCollection<Matprima>(NomeDaTabela);
            collection.Delete(idMatprima);
        }

        //----------------------------------------------------------------------------

        public virtual void CriarOuAtualizar(Matprima Matprima)
        {
            var collection = liteDB.GetCollection<Matprima>(NomeDaTabela);
            collection.Upsert(Matprima);
        }
    }
}
