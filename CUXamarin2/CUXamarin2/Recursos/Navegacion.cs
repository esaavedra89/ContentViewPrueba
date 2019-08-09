using Xamarin.Forms;

namespace CUXamarin2.Recursos
{
    public class Navegacion
    {
        public async void Navegar(string pageName)
        {
            switch (pageName)
            {
                default:
                    await Application.Current.MainPage.Navigation.PopToRootAsync();
                    break;
            }
        }

        public void CerrarSesion()
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await Application.Current.MainPage.DisplayAlert(
                    "Alerta!",
                    "Desea cerrar sesión?",
                    "Si", "No");

                if (result)
                {
                    SetNavegacion("CerrarSesion");
                }
            });
        }

        public async void SetNavegacion(string NombrePagina)
        {
            switch (NombrePagina)
            {
                case "CerrarSesion":
                    App.Current.MainPage = new NavigationPage(new Page1());
                    break;
                default:
                    await Application.Current.MainPage.Navigation.PopToRootAsync();
                    break;
            }
        }
    }
}
