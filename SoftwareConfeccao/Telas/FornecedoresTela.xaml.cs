using Modelos;

namespace Telas
{
    public partial class FornecedoresTela
    {
    Controles.ControleCliente controleCliente = new Controles.ControleFornecedor();
        public FornecedoresTela()
        {
            InitializeComponent();

        ListaClientes.ItemsSource = controleCliente.LerTodos();
        }

    void ListFornecedor(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new CadastroFornecedor();
        page.cliente = e.SelectedItem as Cliente;
        Application.Current.MainPage = page;
    }


//----------------------------------------------------------------------------
        private void OnVoltarFornecedorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnNovoFornecedorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroFornecedor();
        }

//----------------------------------------------------------------------------

    void QuandoSelecionarUmItemNaListaFornecedor(object sender, SelectedItemChangedEventArgs e) 
        {
            var page = new CadastroFornecedor();

            page.cliente = e.SelectedItem as Fornecedor;

            Application.Current.MainPage = page;
        }

        // Aqui você pode adicionar manipuladores de eventos para os botões, se necessário.
    }
}
