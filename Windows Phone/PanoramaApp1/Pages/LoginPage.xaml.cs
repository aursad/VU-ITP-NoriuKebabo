using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PanoramaApp1
{
    public partial class LoginPage : PhoneApplicationPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void Login(object sender, EventArgs e)
        {
            MessageBox.Show("Prisijungta sėkmingai!");
            //Do work for your application here.
        }
        private void RegisterClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/RegistrationPage.xaml", UriKind.Relative));
            //Do work for your application here.
        }
    }
}