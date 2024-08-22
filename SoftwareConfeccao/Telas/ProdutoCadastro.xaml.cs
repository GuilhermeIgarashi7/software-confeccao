using Modelos;

namespace Telas
{
    public partial class ProdutoCadastro : ContentPage
    {

        public Produto produto { get; set; }

        Controles.ControleProduto controleProduto = new Controles.ControleProduto();
        public ProdutoCadastro()
        {
            InitializeComponent();
        }
        private void OnVoltarCadastroProdutoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ProdutoTela();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (produto != null)
            {
                IdLabelProduto.Text = produto.Id.ToString();
                EntryNomeProduto.Text = produto.Nomeitem;
                EntryCustoProduto.Text = produto.Custoitem;
                EntryTempopProducaoProduto.Text = produto.Tempoproducaoproduto;

            }
        }

        private void OnApagarDadosClicked(object sender, EventArgs e)
        {
            IdLabelProduto.Text = string.Empty;
            EntryNomeProduto.Text = string.Empty;
            EntryCustoProduto.Text = string.Empty;
            EntryTempopProducaoProduto.Text = string.Empty;


        }

        private async void OnSalvarDadosProdutoClicked(object sender, EventArgs e)
        {
            if (await VerificaSeDadosEstaoCorretos())
            {
                var produto = new Modelos.Produto();
                if (!String.IsNullOrEmpty(IdLabelProduto.Text))
                    produto.Id = int.Parse(IdLabelProduto.Text);
                else
                produto.Id = 0;
                produto.Nomeitem = EntryNomeProduto.Text;
                produto.Custoitem = EntryCustoProduto.Text;
                produto.Tempoproducaoproduto = EntryTempopProducaoProduto.Text;


                controleProduto.CriarOuAtualizar(produto);
            }
            await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
        }

        private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            if (String.IsNullOrEmpty(EntryNomeProduto.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryCustoProduto.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Custo é obrigatório", "OK");
                return false;
            }
            else if (String.IsNullOrEmpty(EntryTempopProducaoProduto.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Frete é obrigatório", "OK");
                return false;
            }

            else
                return true;
        }
        private async void OnApagarProdutoClicked(object sender, EventArgs e)  
        {
            if (produto == null || produto.Id < 1)
               await DisplayAlert("Erro", "Nenhum Produto para excluir", "ok");
            else if (await DisplayAlert("Excluir","Tem certeza que deseja excluir esse produto?","Excluir Produto","cancelar"))
            {
                controleProduto.Apagar(produto.Id);
        Application.Current.MainPage = new ProdutoTela();                 
            }

    }

    }

}