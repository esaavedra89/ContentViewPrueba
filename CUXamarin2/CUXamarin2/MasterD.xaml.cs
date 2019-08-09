
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CUXamarin2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterD : MasterDetailPage
    {
		public MasterD (string nombrePagina)
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            this.Master = new Menu();
            this.Detail = new NavigationPage(new MainPage(nombrePagina));
        }
	}
}