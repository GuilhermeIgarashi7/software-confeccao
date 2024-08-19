using Modelos;
using SoftwareConfeccao;

namespace Telas
{
    public partial class FornecedoresTela
    {
    Controles.ControleFornecedor controleFornecedor = new Controles.ControleFornecedor();
        public FornecedoresTela()
        {
            InitializeComponent();

        ListaFornecedores.ItemsSource = controleFornecedor.LerTodos();
        }

    void ListFornecedor(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new FornecedoresCadastro();
        page.fornecedor = e.SelectedItem as Fornecedor;
        Application.Current.MainPage = page;
    }


//----------------------------------------------------------------------------
        private void OnVoltarFornecedorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnNovoFornecedorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FornecedoresCadastro();
        }

//----------------------------------------------------------------------------

    void QuandoSelecionarUmItemNaListaFornecedor(object sender, SelectedItemChangedEventArgs e) 
        {
            var page = new FornecedoresCadastro();

            page.fornecedor = e.SelectedItem as Fornecedor;

            Application.Current.MainPage = page;
        }

        // Aqui você pode adicionar manipuladores de eventos para os botões, se necessário.
    }
}
