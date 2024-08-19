using Modelos;

namespace Telas
{
    public partial class FornecedoresCadastro : ContentPage
    {

        public Fornecedor fornecedor { get; set; }

        Controles.ControleFornecedor controleFornecedor = new Controles.ControleFornecedor();
        public FornecedoresCadastro()
        {
            InitializeComponent();
        }
        private void OnVoltarCadastroFornecedorClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new FornecedoresTela();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (fornecedor != null)
            {
                IdLabelFornecedor.Text = fornecedor.idFornecedor.ToString();
                EntryNomeFornecedor.Text = fornecedor.Nomefornecedor;
                EntryEmailFornecedor.Text = fornecedor.Emailfornecedor;
                EntryTelefoneFornecedor.Text = fornecedor.Telefonefornecedor;
                EntryEnderecoFornecedor.Text = fornecedor.Enderecofornecedor;
                EntryMatPrimaFornecedor.Text = fornecedor.Matprimafornecedor;
                EntryAreaProducaoFornecedor.Text = fornecedor.Areaproducaofornecedor;

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

        private async void OnSalvarDadosFornecedorClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos())
            {
                var fornecedor = new Modelos.Fornecedor();
                if (!String.IsNullOrEmpty(IdLabelFornecedor.Text))
                    fornecedor.idFornecedor = int.Parse(IdLabelFornecedor.Text);
                else
                    fornecedor.idFornecedor = 0;
                fornecedor.Nome = EntryNomeFornecedor.Text;
                fornecedor.Email = EntryTelefoneFornecedor.Text;
                fornecedor.Telefone = EntryEmailFornecedor.Text;
                fornecedor.Matprimafornecedor = EntryMatPrimaFornecedor.Text;
                fornecedor.Areaproducaofornecedor = EntryAreaProducaoFornecedor.Text;
                fornecedor.Enderecofornecedor = EntryEnderecoFornecedor.Text;

                controleFornecedor.CriarOuAtualizar(fornecedor);
            }
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            if (String.IsNullOrEmpty(EntryNomeFornecedor.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryEmailFornecedor.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryEnderecoFornecedor.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Endereço é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryMatPrimaFornecedor.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Matéria Prima é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryAreaProducaoFornecedor.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Área de Produção", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryTelefoneFornecedor.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
                return false;
            }

            else
                return true;
        }


    }

}