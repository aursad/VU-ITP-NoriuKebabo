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
using PanoramaApp1.ViewModels;
using Microsoft.Phone.Controls;
using System.Windows.Navigation;

namespace PanoramaApp1.Pages
{
    public partial class Details : PhoneApplicationPage
    {
        public Details()
        {
            InitializeComponent();
        }
                Comments comm = new PanoramaApp1.ViewModels.Comments();

        // When page is navigated to set data context to selected item in list
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            listComments.ItemsSource = comm;
            listRatings.ItemsSource = comm;

            string selectedIndex = "";
            if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
            {
                int index = int.Parse(selectedIndex);
                DataContext = App.ViewModel.Items[index];
            }
        }

        private void AddComment_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Pridėti komentarą!");
            comm.Add(new Comment("Vardas", "Pavarde", "Adresas", 0));
            NavigationService.Navigate(new Uri("/Pages/Add/Comment.xaml", UriKind.Relative));
            //Do work for your application here.
        }

        private void AddRating_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pridėti įvertinimą!");
            //Do work for your application here.
        }
    }
}