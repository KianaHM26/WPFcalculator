using System;
using System.Collections.Generic;
using System.Data;
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
namespace MinimalCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Text += (sender as System.Windows.Controls.Button).Content.ToString();
        }


        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            string op = (sender as System.Windows.Controls.Button).Content.ToString();

            if (op == "×") op = "*";
            if (op == "÷") op = "/";

            InputBox.Text += op;
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(InputBox.Text, null);
                ResultBox.Text = result.ToString();
            }
            catch
            {
                ResultBox.Text = "Error";
            }
        }

        private void ClearEntry_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Text = "";
        }

        
        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            InputBox.Text = "";
            ResultBox.Text = "0";
        }

     
        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (InputBox.Text.Length > 0)
            {
                InputBox.Text = InputBox.Text.Substring(0, InputBox.Text.Length - 1);
            }
        }
    }
}