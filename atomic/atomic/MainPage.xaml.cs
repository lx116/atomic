using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace atomic
{
    public partial class MainPage : ContentPage
    {
        
        
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Entry_OnCompleted(object sender, EventArgs e)
        {
            
        }

        private async void Login(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoadingPage());
        }

        private async void RegisterPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
        
        private async void GoToApp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoadingPage());
        }
        
    }
}