using System;
using System.Windows;

namespace Exercise11
{
    public partial class MainWindow : Window
    {

        private Random _randomNumberGenerator1 = new Random();
        private Random _randomNumberGenerator2 = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void firstNumberButton_Click(object sender, RoutedEventArgs e)
        {
            int getal1 = _randomNumberGenerator1.Next(1, 5000);
            firstNumberLabel.Content = getal1.ToString();
        }

        private void secondNumberButton_Click(object sender, RoutedEventArgs e)
        {
            int getal2 = _randomNumberGenerator2.Next(1, 5000);
            secondNumberLabel.Content = getal2.ToString();
        }
    }
}
