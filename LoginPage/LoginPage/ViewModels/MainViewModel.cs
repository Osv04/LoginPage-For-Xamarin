using LoginPage.Models;
using LoginPage.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginPage.ViewModels
{
    public class MainViewModel
    { 
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public ICommand OnSignUpMoveCommand { get; }

        public ICommand OnLoginCommand { get; }

        public ICommand OnRegistrationCommand { get; }

        public MenuOption International { get; } = new MenuOption("International", "location.png");

        public MenuOption Study { get; } = new MenuOption("Study", "letter.png");

        public MenuOption Sports { get; } = new MenuOption("Sports", "sports.png");

        public MenuOption Teachers { get; } = new MenuOption("Teachers", "teacher.png");

        public MenuOption Subjects { get; } = new MenuOption("Subjects", "book.png");

        public MenuOption AboutUs { get; } = new MenuOption("About Us", "school.png");

        public MainViewModel()
        {
            OnSignUpMoveCommand = new Command(OnSignUpMove);
            OnLoginCommand = new Command(OnLogin);
            OnRegistrationCommand = new Command(OnRegistration);
        }

        private async void OnSignUpMove()
        {
            await App.Current.MainPage.Navigation.PushAsync(new RegistrationPage());
        }

        private async void OnLogin()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Insertar Valores Aceptables", "Cancel");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Good", "Bienvenido Profe", "Ok");
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
            
        }

        private async void OnRegistration()
        {
            if(string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(ConfirmPassword))
            {
                await App.Current.MainPage.DisplayAlert("Error", "No se permiten campos vacios.", "Cancel");
            }
            else if (Password == ConfirmPassword)
            {

                await App.Current.MainPage.DisplayAlert("Good", "Registro Exitoso!", "Ok");
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Contraseñas no coinciden", "Por favor intentar de nuevo", "Cancel");
            }

        }
       
    }
}
