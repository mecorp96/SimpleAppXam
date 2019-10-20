using System;
using pruebaTecnicaXam.LoginDir;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pruebaTecnicaXam
{
    public partial class App : Application, ILoginManager
    {
        static ILoginManager loginManager;
        public static App Current;
        public static int val;

        public App()
        {
            InitializeComponent();

            Current = this;
            var isLoggedIn = Properties.ContainsKey("IsLoggedIn") ? (bool)Properties["isLoggedIn"] : false;
            if (isLoggedIn)
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new LoginModalPage(this);
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public void ShowMainPage()
        {
            MainPage = new MainPage();
        }

        public void Logout()
        {
            Properties["IsLoggedIn"] = false;
            MainPage = new LoginModalPage(this);
        }
    }
}
