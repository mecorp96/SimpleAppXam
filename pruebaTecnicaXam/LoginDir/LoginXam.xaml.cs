using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace pruebaTecnicaXam.LoginDir
{
    public partial class LoginXam : ContentPage
    {
        ILoginManager ilm = null;
        User user;
        public LoginXam(ILoginManager ilm)
        {
            InitializeComponent();
            txtUsername.Text = "";
            txtUserpass.Text = "";
            this.ilm = ilm;
        }

        void btnLoginClick(object sender, EventArgs e)
        {
            user = new User(txtUsername.Text, txtUserpass.Text);
            if (user.CheckUser(user))
            {
                ilm.ShowMainPage();
            }
            else
            {
                lblAlert.Text = "Usuario y/o contraseña incorrectos";
            }

        }
    }
}
