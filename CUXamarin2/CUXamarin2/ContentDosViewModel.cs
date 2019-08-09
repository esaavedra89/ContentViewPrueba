
using System.ComponentModel;
using Xamarin.Forms;

namespace CUXamarin2
{
    public class ContentDosViewModel : INotifyPropertyChanged
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
        async void Login()
        {
            await Application.Current.MainPage.DisplayAlert(
                "Segundo View",
                "Hello it's works: " + this.Password + " " + this.username,
                "Ok");
        } 
        #endregion
    }
}
