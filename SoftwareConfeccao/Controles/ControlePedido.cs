using LiteDBExample.Modelos;
using Modelos;

namespace Controles
{

    public class ControlePedido : ControleBase
    {        
        //----------------------------------------------------------------------------

        public ControlePedido() : base()
        {
            NomeDaTabela = "Pedido";
        }

        //----------------------------------------------------------------------------

        public virtual Item? Ler(int Id)
        {
            var collection = liteDB.GetCollection<Produto>(NomeDaTabela);
            return collection.FindOne(d => d.Id == Id);
        }

        //----------------------------------------------------------------------------

        public virtual List<Produto>? LerTodos()
        {
            var tabela = liteDB.GetCollection<Produto>(NomeDaTabela);
            return new List<Produto>(tabela.FindAll().OrderBy(d => d.NomeProduto));
        }

        //----------------------------------------------------------------------------

        public virtual void Apagar(int Id)
        {
            var collection = liteDB.GetCollection<Produto>(NomeDaTabela);
            collection.Delete(Id);
        }

        //----------------------------------------------------------------------------

        public virtual void CriarOuAtualizar(Produto Produto)
        {
            var collection = liteDB.GetCollection<Produto>(NomeDaTabela);
            collection.Upsert(Produto);
        }
    }
}
