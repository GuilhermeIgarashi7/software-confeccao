using Microsoft.Maui.Controls;
using Modelos;

namespace Telas
{
    public partial class CadastroClientes : ContentPage
    {
    
    public Cliente cliente { get; set; }    

    Controles.ControleCliente controleCliente = new Controles.ControleCliente();
    public CadastroClientes()
        {
            InitializeComponent();
        }
        private void OnVoltarCadastroClienteClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ClientesTela();
        }

    protected override void OnAppearing()
    {
        base.OnAppearing();

      if (cliente != null)
        {
        IdLabel.Text        = cliente.idCliente.ToString();
        EntryNomeCliente.Text      = cliente.Nome;
        EntryEmailCliente.Text = cliente.Email;
        EntryTelefoneCliente.Text  = cliente.Telefone;
        }
    }

    private void OnApagarDadosClicked(object sender, EventArgs e)
    {
        IdLabel.Text = string.Empty;
        EntryNomeCliente.Text = string.Empty;
        EntryEmailCliente.Text = string.Empty;
        EntryTelefoneCliente.Text = string.Empty;
    }

    private async void OnSalvarDadosClicked(object sender, EventArgs e)
    {
        if (await VerificaSeDadosEstaoCorretos())
        {
        var cliente = new Modelos.Cliente();
        if (!String.IsNullOrEmpty(IdLabel.Text))
        cliente.idCliente        = int.Parse(IdLabel.Text);
        else
        cliente.idCliente = 0;
        cliente.Nome      = EntryNomeCliente.Text;
        cliente.Email = EntryTelefoneCliente.Text;
        cliente.Telefone  = EntryEmailCliente.Text;

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