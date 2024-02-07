﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prac6_1_Demidova
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome : ContentPage
    {
        static string login;
        static string password;
        public Welcome()
        {
            InitializeComponent();
        }
        private bool CheckFields(string _login, string _password)
        {
            if (_login == null || _login.Length <= 2)
            {
                this.DisplayToastAsync("Длина логина должна быть больше 2 символов");
                return false;
            }
            if (_password == null || _password.Length <= 4)
            {
                this.DisplayToastAsync("Длина пароля должна быть больше 4 символов");
                return false;
            }
            login = _login;
            password = _password;
            return true;
        }
        private void LogButton_Clicked(object sender, EventArgs e)
        {
            if (CheckFields(Login.Text, Password.Text))
            {
                Navigation.PushAsync(new MainPage(login, password));
            }
        }
    }
}