using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PanoramaApp1.ViewModels
{
    public class Comment
    {
        public String Autorius { get; set; }
        public String Komentaras { get; set; }
        public String Laikas { get; set; }
        public int Ivertinimas { get; set; }
        public Comment(String autorius, String komentaras, String laikas, int ivertinimas)
        {
            this.Autorius = autorius;
            this.Komentaras = komentaras;
            this.Laikas = laikas;
            this.Ivertinimas = ivertinimas;
        }
    }
}
