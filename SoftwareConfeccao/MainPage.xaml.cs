using Telas;

namespace SoftwareConfeccao;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
       private void OnClienteClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ClientesTela();
        }

        private void OnFornecedorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FornecedoresTela();
            
        }

        private void OnTransportadoraClicked(object sender, EventArgs e)
        {
            // Código para quando o botão "Transportadora" for clicado
            Application.Current.MainPage = new TransportadoraTela();

        }

        private void OnMateriaPrimaClicked(object sender, EventArgs e)
        {
            // Código para quando o botão "Matéria Prima" for clicado
            Application.Current.MainPage = new MatPrimaTela();
        }

        private void OnProdutoClicked(object sender, EventArgs e)
        {
            // Código para quando o botão "Produto" for clicado
            Application.Current.MainPage = new ProdutoTela();
        }

        private void OnPedidosClicked(object sender, EventArgs e)
        {
            // Código para quando o botão "Pedidos" for clicado
            Application.Current.MainPage = new PedidoTela();
        }

        private void OnEstoqueClicked(object sender, EventArgs e)
        {
            // Código para quando o botão "Estoque" for clicado
            DisplayAlert("Estoque", "Você clicou em Estoque", "OK");
        }
}

