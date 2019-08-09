using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CUXamarin2
{
    public class ContentPruebaViewModel : INotifyPropertyChanged
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
        string username;
        string password;
        bool busy;
        #endregion

        #region Properties
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public bool Busy
        {
            get { return busy; }
            set
            {
                busy = value;
                OnPropertyChanged("Busy");
            }
        }
        #endregion

        #region Constructors
        public ContentPruebaViewModel()
        {
            CargarDatos();
        } 
        #endregion

        #region Commands
        public Command LoginCommand
        {
            get
            {
                return new Command(Login);
            }
        }
        #endregion

        #region Methods
        async void CargarDatos()
        {
            this.Busy = true;

            await Task.Delay(10000);

            this.Busy = false;
        }
        async void Login()
        {
            await Application.Current.MainPage.DisplayAlert(
                "Primer View",
                "Hello it's works: " + this.Password + " " + this.username,
                "Ok");
        } 
        #endregion
    }
}
