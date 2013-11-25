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

namespace PanoramaApp1.Pages.Add
{
    public partial class AddComment : PhoneApplicationPage
    {
        public AddComment()
        {
            InitializeComponent();
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            String _autorius;
            String _laikas;
            String _komentaras;
            String message = "";

            _autorius = autorius.Text;
            _laikas = laikas.Text;
            _komentaras = komentaras.Text;

            if (_autorius == "") { message += "Neįvestas autoriaus vardas!\n"; }
            if (_laikas == "") { message += "Neįvestas laikas!\n"; }
            if (_komentaras == "") { message += "Neįvestas komentaras!\n"; }

            if (message == "")
            {
                Comments Comm = new Comments();
                Random rnd = new Random();
                int _rating = rnd.Next(1, 5); 
                Comm.Add(new Comment(_autorius, _laikas, _komentaras, _rating));
                MessageBox.Show("Pridėtas komentaras!");
            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}