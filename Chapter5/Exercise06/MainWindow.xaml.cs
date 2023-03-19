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

namespace Exercise06
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

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            paperCanvas.Children.Clear();
            DrawStreet();
        }

        private void DrawStreet()
        {
            double xPos = 20;
            double yPos = 100;
            double size = 100;
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);
            for (int i = 0; i < 4; i++)
            {
                DrawHouse(paperCanvas, brush, xPos, yPos, size);
                xPos += size + 20;
            }
        }

        private void DrawHouse(Canvas drawingArea, SolidColorBrush brushToUse,
                                   double xPos, double yPos, double size)
        {
            Rectangle house = new Rectangle
            {
                Width = size,
                Height = size,
                Margin = new Thickness(xPos, yPos, 0, 0),
                Stroke = brushToUse
            };
            drawingArea.Children.Add(house);
            Line lineOne = new Line
            {
                X1 = xPos, X2 = xPos + size, Y1 = yPos, Y2 = yPos,
                Stroke = brushToUse
            };
            drawingArea.Children.Add(lineOne);
            Line lineTwo = new Line
            {
                X1 = xPos,
                X2 = (xPos + (size / 2)),
                Y1 = yPos,
                Y2 = (yPos - (size / 2)),
                Stroke = brushToUse
            };
            drawingArea.Children.Add(lineTwo);
            Line lineThree = new Line
            {
                X1 = (xPos + size),
                X2 = (xPos + (size / 2)),
                Y1 = yPos,
                Y2 = (yPos - (size / 2)),
                Stroke = brushToUse
            };
            drawingArea.Children.Add(lineThree);
        }
    }
}
