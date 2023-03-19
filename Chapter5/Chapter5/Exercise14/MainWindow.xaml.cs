﻿using System;
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

namespace Exercise14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string ConvertNumberToBinary(int number)
        {
            String result = "";
            if(number == 0)
            {
                result = "00000000";
            }
            for (int i = 0; number > 0; i++)
            {
                result = number % 2 + result;
                number = number / 2;
            }
            return result;
        }

        private void buttontoBinary_Click(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(inputNumber.Text);

            outputBinary.Content = ConvertNumberToBinary(number);
        }
    }
}
