using Modelos;
using SoftwareConfeccao;

namespace Telas
{
    public partial class MatPrimaTela
    {
    Controles.ControleMatPrima controleMatPrima = new Controles.ControleMatPrima();
        public MatPrimaTela()
        {
            InitializeComponent();

        ListaMatPrima.ItemsSource = controleMatPrima.LerTodos();
        }

    void ListMatPrima(object sender, SelectedItemChangedEventArgs e)
    {
        var page = new MatPrimaCadastro();
        page.matprima = e.SelectedItem as MatPrima;
        Application.Current.MainPage = page;
    }

//----------------------------------------------------------------------------
        private void OnVoltarMatPrimaClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnNovoMatPrimaClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MatPrimaCadastro();
        }

//----------------------------------------------------------------------------

    void QuandoSelecionarUmItemNaListaMatPrima(object sender, SelectedItemChangedEventArgs e) 
        {
            var page = new MatPrimaCadastro();

            page.matprima = e.SelectedItem as MatPrima;

            Application.Current.MainPage = page;
        }

        // Aqui você pode adicionar manipuladores de eventos para os botões, se necessário.
    }
}
