using LiteDB;
using LiteDBExample.Modelos;


namespace Controles
{

    public class ControleBase
    {
    //----------------------------------------------------------------------------

    protected string NomeDaTabela;
    protected static LiteDatabase liteDB = null;

    //----------------------------------------------------------------------------

    public ControleBase()
    {
        var pathToPersonalFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SESI.db");

        if (liteDB == null)
        liteDB = new LiteDatabase(@"filename=" + pathToPersonalFolder + "; upgrade=true; Mode=Exclusive");
    }

    //----------------------------------------------------------------------------

            public virtual void Criar(Registro o)
            {

            }

            public virtual void AtualizarOuCriar(Registro o)
            {

            }

            public virtual Registro? Ler(int id)
            {
                return null;
            }

            //----------------------------------------------------------------------------

            public virtual List<Registro>? LerTodos()
            {
                return null;
            }

            //----------------------------------------------------------------------------
            }

}