using Modelos;

namespace Telas
{
    public partial class MatPrimaCadastro : ContentPage
    {

        public MatPrima matprima { get; set; }

        Controles.ControleMatPrima controleMatPrima = new Controles.ControleMatPrima();
        public MatPrimaCadastro()
        {
            InitializeComponent();
        }
        private void OnVoltarCadastroMatPrimaClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MatPrimaTela();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (matprima != null)
            {
                IdLabelMatPrima.Text = matprima.Id.ToString();
                EntryNomeMatPrima.Text = matprima.Nomeitem;
                EntryCustoMatPrima.Text = matprima.Custoitem;
                EntryQuantidadeMatPrima.Text = matprima.Quantidade;

            }
        }

        private void OnApagarDadosClicked(object sender, EventArgs e)
        {
            IdLabelMatPrima.Text = string.Empty;
            EntryNomeMatPrima.Text = string.Empty;
            EntryCustoMatPrima.Text = string.Empty;
            EntryQuantidadeMatPrima.Text = string.Empty;


        }

        private async void OnSalvarDadosMatPrimaClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos())
            {
                var matprima = new Modelos.MatPrima();
                if (!String.IsNullOrEmpty(IdLabelMatPrima.Text))
                    matprima.Id = int.Parse(IdLabelMatPrima.Text);
                else
                matprima.Id = 0;
                matprima.Nomeitem = EntryNomeMatPrima.Text;
                matprima.Custoitem = EntryCustoMatPrima.Text;
                matprima.Quantidade = EntryQuantidadeMatPrima.Text;


                controleMatPrima.CriarOuAtualizar(matprima);
            }
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            if (String.IsNullOrEmpty(EntryNomeMatPrima.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryCustoMatPrima.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Custo é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryQuantidadeMatPrima.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Frete é obrigatório", "OK");
                return false;
            }

            else
                return true;
        }
        private async void OnApagarMatPrimaClicked(object sender, EventArgs e)  
        {
            if (matprima == null || matprima.Id < 1)
               await DisplayAlert("Erro", "Nenhuma Matéria Prima para excluir", "ok");
            else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse fornecedor?","Excluir Fornecedor","cancelar"))
            {
                controleMatPrima.Apagar(matprima.Id);
        Application.Current.MainPage = new MatPrimaTela();                 
            }

    }

 }
}