using Modelos;

namespace Telas
{
    public partial class PedidoCadastro : ContentPage
    {

        public Pedido pedido { get; set; }

        Controles.ControlePedido controlePedido = new Controles.ControlePedido();
        public PedidoCadastro()
        {
            InitializeComponent();
        }
        private void OnVoltarCadastroPedidoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PedidoTela();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (pedido != null)
            {
                IdLabelPedido.Text = pedido.Id.ToString();
                EntryNomePedido.Text = pedido.Nomeitem;
                EntryCustoPedido.Text = pedido.Custoitem;
                EntryQuantidadePedido.Text = pedido.Quantidadepedido;
                EntryFretePedido.Text = pedido.Fretepedido;
                EntryPrazoPedido.Text = pedido.Prazopedido;
                EntryObsPedido.Text = pedido.Observacaopedido;
            }
        }

        private void OnApagarDadosClicked(object sender, EventArgs e)
        {
            IdLabelPedido.Text = string.Empty;
            EntryNomePedido.Text = string.Empty;
            EntryCustoPedido.Text = string.Empty;
            EntryQuantidadePedido.Text = string.Empty;
            EntryFretePedido.Text = string.Empty;
            EntryPrazoPedido.Text = string.Empty;
            EntryObsPedido.Text = string.Empty;


        }

        private async void OnSalvarDadosPedidoClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos())
            {
                var pedido = new Modelos.Pedido();
                if (!String.IsNullOrEmpty(IdLabelPedido.Text))
                    pedido.Id = int.Parse(IdLabelPedido.Text);
                else
                pedido.Id = 0;
                pedido.Nomeitem = EntryNomePedido.Text;
                pedido.Custoitem = EntryCustoPedido.Text;
                pedido.Quantidadepedido = EntryQuantidadePedido.Text;
                pedido.Fretepedido = EntryFretePedido.Text;
                pedido.Prazopedido = EntryPrazoPedido.Text;
                pedido.Observacaopedido = EntryObsPedido.Text;

                controlePedido.CriarOuAtualizar(pedido);
            }
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            if (String.IsNullOrEmpty(EntryNomePedido.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryCustoPedido.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Custo é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryFretePedido.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Frete é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryPrazoPedido.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Prazo é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryQuantidadePedido.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Quantidade é obrigatório", "OK");
                return false;
            }

            else
                return true;
        }


    }

}