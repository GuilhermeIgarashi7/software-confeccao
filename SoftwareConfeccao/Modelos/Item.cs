namespace Modelos;

public class Item
{
    string nomeitem;

    string custoitem;

    int iditem;

//--------------------------------------------------------------------------------------

        public void SetIdItem(int id)
        {
            iditem = id;
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

    public string GetNome()
    {
        return custoitem;
    }
}