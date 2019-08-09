using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CUXamarin2
{
    public partial class App : Application
    {
        public static bool boleano { get; set; }

        public static string NombreVista { get; set; }

        public App()
        {
            InitializeComponent();

            App.boleano = false;

            MainPage =new NavigationPage( new Page1());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
