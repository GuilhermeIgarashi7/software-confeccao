namespace SoftwareConfeccao;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
       private void OnClienteClicked(object sender, EventArgs e)
        {
            // Código para quando o botão "Cliente" for clicado
            DisplayAlert("Cliente", "Você clicou em Cliente", "OK");
        }

        private void OnFornecedorClicked(object sender, EventArgs e)
        {
            // Código para quando o botão "Fornecedor" for clicado
            DisplayAlert("Fornecedor", "Você clicou em Fornecedor", "OK");
        }

        private void OnTransportadoraClicked(object sender, EventArgs e)
        {
            // Código para quando o botão "Transportadora" for clicado
            DisplayAlert("Transportadora", "Você clicou em Transportadora", "OK");
        }

        private void OnMateriaPrimaClicked(object sender, EventArgs e)
        {
            // Código para quando o botão "Matéria Prima" for clicado
            DisplayAlert("Matéria Prima", "Você clicou em Matéria Prima", "OK");
        }

        private void OnProdutoClicked(object sender, EventArgs e)
        {
            // Código para quando o botão "Produto" for clicado
            DisplayAlert("Produto", "Você clicou em Produto", "OK");
        }

        private void OnPedidosClicked(object sender, EventArgs e)
        {
            // Código para quando o botão "Pedidos" for clicado
            DisplayAlert("Pedidos", "Você clicou em Pedidos", "OK");
        }

        private void OnEstoqueClicked(object sender, EventArgs e)
        {
            // Código para quando o botão "Estoque" for clicado
            DisplayAlert("Estoque", "Você clicou em Estoque", "OK");
        }
}

