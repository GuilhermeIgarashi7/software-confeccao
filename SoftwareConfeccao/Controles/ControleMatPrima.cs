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
            var collection = liteDB.GetCollection<MatPrima>(NomeDaTabela);
            return collection.FindOne(d => d.Id == idMatprima);
        }

        //----------------------------------------------------------------------------

        public virtual List<MatPrima>? LerTodos()
        {
            var tabela = liteDB.GetCollection<MatPrima>(NomeDaTabela);
            return new List<MatPrima>(tabela.FindAll().OrderBy(d => d.Nomeitem));
        }

        //----------------------------------------------------------------------------

        public virtual void Apagar(int idMatprima)
        {
            var collection = liteDB.GetCollection<MatPrima>(NomeDaTabela);
            collection.Delete(idMatprima);
        }

        //----------------------------------------------------------------------------

        public virtual void CriarOuAtualizar(MatPrima Matprima)
        {
            var collection = liteDB.GetCollection<MatPrima>(NomeDaTabela);
            collection.Upsert(Matprima);
        }
    }
}
