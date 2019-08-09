
using CUXamarin2.Recursos;
using System.ComponentModel;
using Xamarin.Forms;

namespace CUXamarin2
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Attributes
        string nombreSeccion;
        #endregion

        #region Properties
        public string NombreSeccion
        {
            get { return nombreSeccion; }
            set
            {
                nombreSeccion = value;
                OnPropertyChanged("NombreSeccion");
            }
        }
        #endregion

        public MainPageViewModel()
        {
            //this.NombreSeccion = App.NombreVista;
        }

        #region Commands
        public Command HomeCommand
        {
            get
            {
                return new Command(Home);
            }
        }
        public Command PerfilCommand
        {
            get
            {
                return new Command(Perfil);
            }
        }
        public Command CerrarSesionAppCommand
        {
            get
            {
                return new Command(CerrarSesionApp);
            }
        }
        #endregion

        #region Methods
        async void Perfil()
        {
            await Application.Current.MainPage.DisplayAlert("Hello", "Perfil", "App");
        }
        private async void Home()
        {
            await Application.Current.MainPage.Navigation.PopToRootAsync();
        }
        private void CerrarSesionApp()
        {
            Navegacion navegacion = new Navegacion();
            navegacion.CerrarSesion();
        } 
        #endregion
    }
}
