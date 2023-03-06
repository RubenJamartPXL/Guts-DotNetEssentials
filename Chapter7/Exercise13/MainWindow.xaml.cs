using System;
using System.Windows;
using System.Windows.Controls;

namespace Exercise13
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, RoutedEventArgs e)
        {
            double netto = Convert.ToDouble(priceTextbox.Text);
            double tarief = 0.21;
            if ((bool)tariefCheckBox.IsChecked)
            {
                tarief = 0.06;
            }
            double btw = netto * tarief;
            double totaal = netto * (1 + tarief);
            btwTextbox.Text = btw.ToString();
            totalTextbox.Text = totaal.ToString();
        }
    }
}
