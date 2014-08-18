using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReplaceTo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, RoutedEventArgs e)
        {
            
            string inputString = txbInputString.Text;
            string inputChar = txbInputSearchChar.Text;
            string outputChar = txbOutputSearchChar.Text;

            if (string.IsNullOrEmpty(inputString) || string.IsNullOrEmpty(inputChar) || string.IsNullOrEmpty(outputChar))
            {
                txbOutputString.Text = "Please, insert some text.";
            }
            else
            {
                if (!inputString.IndexOf(inputChar).Equals(-1))
                {
                    txbOutputString.Text = inputString.Replace(inputChar, outputChar);
                }
                else
                {
                    txbOutputString.Text = "Input character not exist in input string.";
                }
            }
        }
    }
}
