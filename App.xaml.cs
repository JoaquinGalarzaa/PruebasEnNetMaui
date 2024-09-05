using Microsoft.Maui.Controls;
using ProbandoEnNetMaui.Views;

namespace ProbandoEnNetMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginView());
        }
    }
}
