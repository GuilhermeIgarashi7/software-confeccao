namespace Modelos
{
    public class Odin
    {
        string nome;
        string telefone;

        string email;

        string nomeitem;

        string custoitem;

        int iditem;


    //--------------------------------------------------------------------------------------

        public void SetNome(string n)
        {
            this.nome = n;
        }

        public string GetNome()
        {
            return nome;
        }
    //--------------------------------------------------------------------------------------
        public void SetTelefone(string t)
        {
            this.telefone = t;
        }    

        public string GetTelefone()
        {
            return telefone;
        }
    //--------------------------------------------------------------------------------------
        public void SetEmail(string e)
        {
            this.email = e;
        }    

        public string GetEmail()
        {
            return email;
        }
                            //AQUI COMEÇAM OS ITENS
    //--------------------------------------------------------------------------------------

            public void SetIdItem(int IdI)
            {
                iditem = IdI;
            }
            public int GetIditem()
            {
                return iditem;
            }

    //--------------------------------------------------------------------------------------

        public void SetNomeItem(string nomeitem)
        {
            this.nomeitem = nomeitem;
        }

        public string GetNomeItem()
        {
            return nomeitem;
        }
    //--------------------------------------------------------------------------------------

        public void SetCustoItem(string c)
        {
            this.custoitem = c;
        }

        public string GetNomeI()
        {
            return custoitem;
        }
    }


}