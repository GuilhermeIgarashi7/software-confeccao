using Modelos;

namespace Telas
{
    public partial class CadastroFornecedor : ContentPage
    {

        public Fornecedor fornecedor { get; set; }

        Controles.ControleFornecedor controleFornecedor = new Controles.ControleFornecedor();
        public CadastroFornecedor()
        {
            InitializeComponent();
        }
        private void OnVoltarCadastroFornecedorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FornecedoresTelaTela();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
                IdLabelFornecedor.Text = fornecedor.idFornecedor.ToString();
                EntryNomeFornecedor.Text = fornecedor.Nomefornecedor;
                EntryEmailFornecedor.Text = fornecedor.Emailfornecedor;
                EntryTelefoneFornecedor.Text = fornecedor.Telefonefornecedor;
                EntryEnderecoFornecedor.Text = fornecedor.Enderecofornecedor;
                EntryMatPrimaFornecedor.Text = fornecedor.Matprimafornecedor;
                EntryAreaProducaoFornecedor.Text = fornecedor.AreaproducaoFornecedor;
            }
        }

        private void OnApagarDadosClicked(object sender, EventArgs e)
        {
                IdLabelFornecedor.Text = string.Empty;
                EntryNomeFornecedor.Text = string.Empty;
                EntryEmailFornecedor.Text = string.Empty;
                EntryTelefoneFornecedor.Text = string.Empty;
                EntryEnderecoFornecedor.Text = string.Empty;
                EntryMatPrimaFornecedor.Text = string.Empty;
                EntryAreaProducaoFornecedor.Text = string.Empty;

        }

        private async void OnSalvarDadosClienteClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos())
            {
                var cliente = new Modelos.Fornecedor();
                if (!String.IsNullOrEmpty(IdLabel.Text))
                    cliente.idCliente = int.Parse(IdLabel.Text);
                else
                    cliente.idCliente = 0;
                cliente.Nome = EntryNomeCliente.Text;
                cliente.Email = EntryTelefoneCliente.Text;
                cliente.Telefone = EntryEmailCliente.Text;

                controleCliente.CriarOuAtualizar(cliente);
            }
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            if (String.IsNullOrEmpty(EntryNomeCliente.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryEmailCliente.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryTelefoneCliente.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
                return false;
            }
            else
                return true;
        }


    }

}