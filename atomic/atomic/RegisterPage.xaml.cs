using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace atomic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        
        private void Entry_OnCompleted(object sender, EventArgs e)
        {
            
        }

        private async void Next(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPagePersonal());
        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}