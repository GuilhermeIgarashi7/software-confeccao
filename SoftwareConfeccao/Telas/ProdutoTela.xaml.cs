using Modelos;
using SoftwareConfeccao;

namespace Telas
{
    public partial class ProdutoTela
    {
    Controles.ControleProduto controleProduto = new Controles.ControleProduto();
        public ProdutoTela()
        {
            InitializeComponent();

        ListaProduto.ItemsSource = controleProduto.LerTodos();
        }

    void ListProduto(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new ProdutoCadastro();
        page.produto = e.SelectedItem as Produto;
        Application.Current.MainPage = page;
    }

//----------------------------------------------------------------------------
        private void OnVoltarProdutoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnNovoProdutoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ProdutoCadastro();
        }

//----------------------------------------------------------------------------

    void QuandoSelecionarUmItemNaListaProduto(object sender, SelectedItemChangedEventArgs e) 
        {
            var page = new ProdutoCadastro();

            page.produto = e.SelectedItem as Produto;

            Application.Current.MainPage = page;
        }

        // Aqui você pode adicionar manipuladores de eventos para os botões, se necessário.
    }
}
