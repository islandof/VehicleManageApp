using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VehicleManageApp.Mvvm;
using VehicleManageApp.Services;
using Xamarin.Forms;

namespace VehicleManageApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly ILoginService _loginService;
        public event PropertyChangedEventHandler PropertyChanged;
        //private readonly IAppNavigation _navigationService;

        public LoginViewModel(ILoginService loginService)
        {
            _loginService = loginService;            
            this.LoginCommand = new Command((nothing) =>
            {
                var result = _loginService.LoginAsync(Username, Password);
            });
            //_navigationService = navigationService;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        //public ICommand LoginCommand { get { return new SimpleCommand(Login); } }
        public ICommand LoginCommand { private set; get; }

        private async void Login()
        {
            var result = await _loginService.LoginAsync(Username, Password);

            //await _navigationService.LoggedIn(result != null);

        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
