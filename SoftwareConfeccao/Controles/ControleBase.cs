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
            return Id;
        }
    }