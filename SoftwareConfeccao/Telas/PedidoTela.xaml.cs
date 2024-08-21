using Modelos;
using SoftwareConfeccao;

namespace Telas
{
    public partial class PedidoTela
    {
    Controles.ControlePedido controlePedido = new Controles.ControlePedido();
        public PedidoTela()
        {
            InitializeComponent();

        ListaPedidos.ItemsSource = controlePedido.LerTodos();
        }

    void ListPedido(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new PedidoCadastro();
        page.pedido = e.SelectedItem as Pedido;
        Application.Current.MainPage = page;
    }

//----------------------------------------------------------------------------
        private void OnVoltarPedidoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnNovoPedidoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PedidoCadastro();
        }

//----------------------------------------------------------------------------

    void QuandoSelecionarUmItemNaListaPedido(object sender, SelectedItemChangedEventArgs e) 
        {
            var page = new PedidoCadastro();

            page.pedido = e.SelectedItem as Pedido;

            Application.Current.MainPage = page;
        }

        // Aqui você pode adicionar manipuladores de eventos para os botões, se necessário.
    }
}
