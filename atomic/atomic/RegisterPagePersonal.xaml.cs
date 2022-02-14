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
    public partial class RegisterPagePersonal : ContentPage
    {
        public RegisterPagePersonal()
        {
            InitializeComponent();
        }
        private void Entry_OnCompleted(object sender, EventArgs e)
        {
           
        }
        private async void Login(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppPage());
        }

        private async void RegisterPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
        
    }
}