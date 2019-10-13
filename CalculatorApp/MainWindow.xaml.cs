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

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber;

        public MainWindow()
        {
            InitializeComponent();
            acButton.Click += AcButton_Click;
            plusMinusBuitton.Click += PlusMinusBuitton_Click;
            percentButton.Click += PercentButton_Click;
        }

        // Converts the value shown on the calculator display to percentage.
        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        //Negates the value shown on the calculator display.
        private void PlusMinusBuitton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        // Clears the calculator display.
        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        // Adds the value 7 to the calculator display.
        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Equals("0"))
            {
                resultLabel.Content = "7";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{"7"}";
            }
        }
    }
}
