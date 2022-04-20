﻿using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiniProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<String> intervals = new List<String>();
            List<String> currencies = new List<String>();
            List<String> attributes = new List<string>();

            intervals.Add("Daily");
            intervals.Add("Weekly");
            intervals.Add("Monthly");
            intervals.Add("Intraday");
            IntervalType.ItemsSource = intervals;
            IntervalType.SelectedIndex = 0;

            // TODO: Load actual currencies and add them to the comboboxes
            currencies.Add("EUR");
            currencies.Add("AUD");
            currencies.Add("RSD");
            currencies.Add("GBP");
            currencies.Add("USD");
            FromCurrency.ItemsSource = currencies;
            FromCurrency.SelectedIndex = 0;
            ToCurrency.ItemsSource = currencies;
            ToCurrency.SelectedIndex = 0;

            attributes.Add("Open");
            attributes.Add("Close");
            attributes.Add("Min");
            attributes.Add("Max");
            Attribute.ItemsSource = attributes;
            Attribute.SelectedIndex = 0;
        }
        /*
        private void lineChartInit()
        {

            SeriesCollection = new SeriesCollection
        {
            new LineSeries
            {
                Title = "Avg Speed (KM/H)",
                Values = arrayspeedavg.AsChartValues()
            },
            new LineSeries
            {
                Title = "Avg Gap (Metre)",
                Values = arraygapavg.AsChartValues()
            },

        };

            Labels = datearray;
            YFormatter = value => value.ToString("");

            DataContext = this;
            cartchartdb.Update(true);
        }*/

    }
}
