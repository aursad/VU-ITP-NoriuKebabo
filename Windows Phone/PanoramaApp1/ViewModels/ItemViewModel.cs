using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace PanoramaApp1
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        private string _pavadinimas;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string pavadinimas
        {
            get
            {
                return _pavadinimas;
            }
            set
            {
                if (value != _pavadinimas)
                {
                    _pavadinimas = value;
                    NotifyPropertyChanged("Pavadinimas");
                }
            }
        }

        private string _adresas;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string adresas
        {
            get
            {
                return _adresas;
            }
            set
            {
                if (value != _adresas)
                {
                    _adresas = value;
                    NotifyPropertyChanged("adresas");
                }
            }
        }

        private string _ivertinimas;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string ivertinimas
        {
            get
            {
                return _ivertinimas;
            }
            set
            {
                if (value != _ivertinimas)
                {
                    _ivertinimas = value;
                    NotifyPropertyChanged("ivertinimas");
                }
            }
        }

        private string _aprasymas;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string aprasymas
        {
            get
            {
                return _aprasymas;
            }
            set
            {
                if (value != _aprasymas)
                {
                    _aprasymas = value;
                    NotifyPropertyChanged("Aprasymas");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}