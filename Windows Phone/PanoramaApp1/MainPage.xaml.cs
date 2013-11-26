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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }
        // Handle selection changed on ListBox
        private void MainListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // If selected index is -1 (no selection) do nothing
            if (listBest.SelectedIndex == -1)
                return;

            // Navigate to the new page
            NavigationService.Navigate(new Uri("/Pages/Details.xaml?selectedItem=" + listBest.SelectedIndex, UriKind.Relative));

            // Reset selected index to -1 (no selection)
            listBest.SelectedIndex = -1;
        }
        // Handle selection changed on ListBox
        private void topListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // If selected index is -1 (no selection) do nothing
            if (topList.SelectedIndex == -1)
                return;

            // Navigate to the new page
            NavigationService.Navigate(new Uri("/Pages/Details.xaml?selectedItem=" + topList.SelectedIndex, UriKind.Relative));

            // Reset selected index to -1 (no selection)
            topList.SelectedIndex = -1;
        }
        private void newListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // If selected index is -1 (no selection) do nothing
            if (newList.SelectedIndex == -1)
                return;

            // Navigate to the new page
            NavigationService.Navigate(new Uri("/Pages/Details.xaml?selectedItem=" + newList.SelectedIndex, UriKind.Relative));

            // Reset selected index to -1 (no selection)
            newList.SelectedIndex = -1;
        }
        private void ReqPlaceClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/Add/Place.xaml", UriKind.Relative));
            //Do work for your application here.
        }

        private void LoginClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/LoginPage.xaml", UriKind.Relative));
            //Do work for your application here.
        }

        private void RegisterClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/RegistrationPage.xaml", UriKind.Relative));
            //Do work for your application here.
        }
        private void ContactClick(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/ContactPage.xaml", UriKind.Relative));
            //Do work for your application here.
        }
    }
}