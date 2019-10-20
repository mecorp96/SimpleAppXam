using System;
using Xamarin.Forms;

namespace pruebaTecnicaXam.LoginDir
{
    public class LoginModalPage : CarouselPage
    {
        ContentPage login;
        public LoginModalPage(ILoginManager ilm)
        {
            login = new LoginXam(ilm);

            this.Children.Add(login);
            MessagingCenter.Subscribe<ContentPage>(this, "Login", (sender) =>
            {
                this.SelectedItem = login;
            });
        }
    }
}
