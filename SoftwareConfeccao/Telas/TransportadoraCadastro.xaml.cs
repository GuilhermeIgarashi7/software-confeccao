using Modelos;

namespace Telas
{
    public partial class TransportadoraCadastro : ContentPage
    {

        public Transportadora transportadora { get; set; }

        Controles.ControleTransportadora controleTransportadora = new Controles.ControleTransportadora();
        public TransportadoraCadastro()
        {
            InitializeComponent();
        }
        private void OnVoltarCadastroTransportadoraClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TransportadoraTela();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (transportadora != null)
            {
                IdLabelTransportadora.Text = transportadora.Id.ToString();
                EntryNomeTransportadora.Text = transportadora.Nome;
                EntryEmailTransportadora.Text = transportadora.Email;
                EntryTelefoneTransportadora.Text = transportadora.Telefone;
            }
        }

        private void OnApagarDadosClicked(object sender, EventArgs e)
        {
            IdLabelTransportadora.Text = string.Empty;
            EntryNomeTransportadora.Text = string.Empty;
            EntryEmailTransportadora.Text = string.Empty;
            EntryTelefoneTransportadora.Text = string.Empty;
        }

        private async void OnSalvarDadosTransportadoraClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos())
            {
                var transportadora = new Modelos.Transportadora();
                if (!String.IsNullOrEmpty(IdLabelTransportadora.Text))
                    transportadora.Id = int.Parse(IdLabelTransportadora.Text);
                else
                transportadora.Id = 0;
                transportadora.Nome = EntryNomeTransportadora.Text;
                transportadora.Email = EntryTelefoneTransportadora.Text;
                transportadora.Telefone = EntryEmailTransportadora.Text;

                controleTransportadora.CriarOuAtualizar(transportadora);
            }
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            if (String.IsNullOrEmpty(EntryNomeTransportadora.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryEmailTransportadora.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryTelefoneTransportadora.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
                return false;
            }
            else
                return true;
        }
        private async void OnApagarTransportadoraClicked(object sender, EventArgs e)  
        {
            if (transportadora == null || transportadora.Id < 1)
               await DisplayAlert("Erro", "Nenhuma transportadora para excluir", "ok");
            else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir essa transportadora?","Excluir Transportadora","cancelar"))
            {
                controleTransportadora.Apagar(transportadora.Id);
        Application.Current.MainPage = new ProdutoTela();                 
            }

    }

 }
}