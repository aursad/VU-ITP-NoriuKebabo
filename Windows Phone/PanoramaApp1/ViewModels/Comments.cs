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
using System.Collections.ObjectModel;

namespace PanoramaApp1.ViewModels
{
    public class Comments : ObservableCollection<Comment>
    {
    public Comments()
        {
            Add(new Comment("Jonas Jonaitis", "Man cia labai patiko", "2000/01/22 16:00", 5));
            Add(new Comment("Antanas Jok", "Visai nieko. 4+", "2013/08/23 06:44", 3));
            Add(new Comment("Cassie Hicks", "Buvo smagu cia.", "2013/08/23 15:55", 2));
            Add(new Comment("Guido Pica", "Buenoooo....", "2013/08/23 00:44", 1));
            Add(new Comment("Aurimas Sadauskas", "Komentuoju tai kas man patinka....", "2013/11/25 13:28", 4));
        }
    }
}
