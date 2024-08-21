using Controles;
using Modelos;
using SoftwareConfeccao;

namespace Telas
{
    public partial class TransportadoraTela
    {
    Controles.ControleTransportadora controleTransportadora = new Controles.ControleTransportadora();
        public TransportadoraTela()
        {
            InitializeComponent();

        ListaTransportadora.ItemsSource = controleTransportadora.LerTodos();
        }

    void ListClientes(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new TransportadoraCadastro();
        page.transportadora = e.SelectedItem as Transportadora;
        Application.Current.MainPage = page;
    }


//----------------------------------------------------------------------------
        private void OnVoltarTransportadoraClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnNovaTransportadoraClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroClientes();
        }

//----------------------------------------------------------------------------

    void QuandoSelecionarUmItemNaListaTransportadora(object sender, SelectedItemChangedEventArgs e) 
        {
            var page = new TransportadoraCadastro();

            page.transportadora = e.SelectedItem as Transportadora;

            Application.Current.MainPage = page;
        }

        // Aqui você pode adicionar manipuladores de eventos para os botões, se necessário.
    }
}
