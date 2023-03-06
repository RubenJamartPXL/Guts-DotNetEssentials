using System.Windows;

namespace Exercise14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, RoutedEventArgs e)
        {
            string boodschap = "";
            string geslacht = "";
            string leeftijd = "";

            //naam + voornaam (textbox)
            boodschap += lastNameTextBox.Text + " " + firstNameTextBox.Text;

            //geslacht (radiobutton)
            if (MaleRadioButton.IsChecked == true)
                geslacht = " man ";
            else if (FemaleRadioButton.IsChecked == true)
                geslacht = " vrouw ";
            boodschap += geslacht;

            //leeftijd (radiobutton)
            if (leeftijd1Button.IsChecked == true)
                leeftijd = "tussen 18 en 30 jaar";
            else if (leeftijd2Button.IsChecked == true)
                leeftijd = "tussen 30 en 45 jaar";
            else if (leeftijd3Button.IsChecked == true)
                leeftijd = "tussen 45 en 60 jaar";
            else if (leeftijd4Button.IsChecked == true)
                leeftijd = "ouder dan 60";
            boodschap += leeftijd;
            MessageBox.Show(boodschap);
        }
    }
}
