using Microsoft.Maui.Controls;
using SoftwareConfeccao;

namespace Telas
{
    public partial class ClientesTela
    {
    Controles.ControleCliente controleCliente = new Controles.ControleCliente();
        public ClientesTela()
        {
            InitializeComponent();

        ListaClientes.ItemsSource = clienteControle.LerTodos();
        }

    void ListClientes(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new CadastroClientesPage();
        page.cliente = e.SelectedItem as Cliente;
        Application.Current.MainPage = page;
    }


//----------------------------------------------------------------------------
        private void OnVoltarClienteClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnNovoClienteClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroClientes();
        }

        // Aqui você pode adicionar manipuladores de eventos para os botões, se necessário.
    }
}
