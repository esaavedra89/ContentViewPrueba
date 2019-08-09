using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CUXamarin2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombrePagina.Text))
            {
                return;
            }
            
            Application.Current.MainPage.Navigation.PushAsync(new MasterD(nombrePagina.Text));
        }
    }
}