using System;
using Xamarin.Forms;
using XamarinApp4Projeto.Pages;

namespace XamarinApp4Projeto
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new Home())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToHome(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new Home())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToProfile(object sender, EventArgs args)
        {
            var btn = (Button)sender;
            var page = new Profile();
            page.Title = "About " + btn.Text;

            Detail = new NavigationPage(page)
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }

        private void GoToAbout(object sender, EventArgs args)
        {
            Detail = new NavigationPage(new About())
            {
                BarBackgroundColor = Color.FromHex("#0D1F2D"),
                BarTextColor = Color.White
            };
            IsPresented = false;
        }
    }
}
