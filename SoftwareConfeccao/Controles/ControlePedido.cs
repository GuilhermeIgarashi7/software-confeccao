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
            var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
            return collection.FindOne(d => d.Id == Id);
        }

        //----------------------------------------------------------------------------

        public virtual List<Pedido>? LerTodos()
        {
            var tabela = liteDB.GetCollection<Pedido>(NomeDaTabela);
            return new List<Pedido>(tabela.FindAll().OrderBy(d => d.Nomeitem));
        }

        //----------------------------------------------------------------------------

        public virtual void Apagar(int Id)
        {
            var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
            collection.Delete(Id);
        }

        //----------------------------------------------------------------------------

        public virtual void CriarOuAtualizar(Pedido Pedido)
        {
            var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
            collection.Upsert(Pedido);
        }
    }
}
