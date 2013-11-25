using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace PanoramaApp1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel() { pavadinimas = "Jammi", adresas = "Trakų g. 0, Vilnius", ivertinimas = "5", aprasymas = "Turi buti čia aprašymas"});
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu two", adresas = "Vilniaus g. 10, Kaunas", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu three", adresas = "Klaipėdos g. 2a, Šiauliai", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu four", adresas = "Šilutės pl. 120, Klaipėda", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu five", adresas = "Ukmergės pl. 22, Vilnius", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu six", adresas = "Naugarduko g. 1, Vilnius", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu seven", adresas = "Naugarduko g. 1, Vilnius", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu eight", adresas = "Naugarduko g. 1, Vilnius", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu nine", adresas = "Naugarduko g. 1, Vilnius", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu ten", adresas = "Naugarduko g. 1, Vilnius", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu eleven", adresas = "Naugarduko g. 1, Vilnius", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu twelve", adresas = "Naugarduko g. 1, Vilnius", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu thirteen", adresas = "Naugarduko g. 1, Vilnius", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu fourteen", adresas = "Naugarduko g. 1, Vilnius", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu fifteen", adresas = "Naugarduko g. 1, Vilnius", ivertinimas = "0" });
            this.Items.Add(new ItemViewModel() { pavadinimas = "Noriu sixteen", adresas = "Naugarduko g. 1, Vilnius", ivertinimas = "0" });

            this.IsDataLoaded = true;
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