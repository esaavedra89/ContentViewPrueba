
using Xamarin.Forms;

namespace CUXamarin2
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string nombrePagina)
        {
            InitializeComponent();
            
            switch (nombrePagina)
            {
                case "ContentPruebaView":
                    var viewUno = new ContentPruebaView();
                    StackLayoutPrincipal.Children.Add(viewUno);
                    nombreSeccion.Text = nombrePagina;
                    break;
                case "ContentDosView":
                    var viewDos = new ContentDosView();
                    StackLayoutPrincipal.Children.Add(viewDos);
                    nombreSeccion.Text = nombrePagina;
                    break;
                default:
                    Application.Current.MainPage.DisplayAlert(
                       "Error",
                       "Error al ingresar nombre pagina",
                       "Ok");
                    break;
            }
        }
    }
}
