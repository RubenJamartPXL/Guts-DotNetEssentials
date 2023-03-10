using System.Windows;
using System.Windows.Controls;

namespace Exercise07
{
    public partial class MainWindow : Window
    {
        private string _cipher = "";
        private int _total = 0;
        private bool _minPlus;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addNumber(int number)
        {
            _cipher += number.ToString();
            _displayTextBlock.Text = _cipher;
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            addNumber(1);
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            addNumber(2);
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            addNumber(3);
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            addNumber(4);
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            addNumber(5);
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            addNumber(6);
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            addNumber(7);
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            addNumber(8);
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            addNumber(9);
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            addNumber(0);
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            if(_cipher != "")
            {
                _total += int.Parse(_cipher);
            }
            _minPlus = true;
            _cipher = "";
            _displayTextBlock.Text = _total.ToString();
        }

        private void minButton_Click(object sender, RoutedEventArgs e)
        {
            if (_cipher != "")
            {
                if (_total == 0)
                {
                    _total += int.Parse(_cipher);
                }
                else
                {
                    _total -= int.Parse(_cipher);
                }
            }
            _minPlus = false;
            _cipher = "";
            _displayTextBlock.Text = _total.ToString();
        }

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {
            if(_cipher != "")
            {
                if (_minPlus == true)
                {
                    _total += int.Parse(_cipher);
                }
                else
                {
                    _total -= int.Parse(_cipher);
                }
                _cipher = "";
                _displayTextBlock.Text = _total.ToString();
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            _total = 0;
            _cipher = "";
            _displayTextBlock.Text = "0";
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            _displayTextBlock.Text = "0";
        }
    }
}
