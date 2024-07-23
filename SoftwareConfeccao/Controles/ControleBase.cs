using Modelos;

namespace Controles;

    public class ControleBase
    {
        public virtual void Criar(Pessoa p)
        {

        }

        public virtual void Atualizar(Pessoa p)
        {

        }

        public virtual void Apagar(int Id)
        {

        }

        public virtual Pessoa Ler(int Id)
        {
            return null;
        }

        public virtual void CriarI(Item i)
        {

        }

        public virtual void AtualizarI(Item i)
        {

        }


        public virtual Item LerI(int Id)
        {
            return null;
        }
    }
