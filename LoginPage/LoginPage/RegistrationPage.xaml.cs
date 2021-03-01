using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private async void ClickedRegistration(object sender, EventArgs e)
        {
            if (Password.Text == ConfirmPassword.Text)
            {
                await DisplayAlert("Good", "Registro Exitoso!", "Cancel");
                await Navigation.PushAsync(new LoginPage());
            }
            else 
            {
                await DisplayAlert("Error", "Por favor intentar de nuevo", "Cancel");
            }
            
        }
    }
}