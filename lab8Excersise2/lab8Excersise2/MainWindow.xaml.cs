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

namespace lab8Excersise2
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

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            //Take in user Input

            string num = tbxUserEntry.Text;
            int num1;
            bool isValid = int.TryParse(num, out num1);

            //Check if number is odd or even

            bool isEven = false;
            if(num1 % 2 == 0)
            {
                isEven = true;
            }
            else
            {
                isEven = false;
            }

            //Display to screen
            if (isValid)
            {
                if (isEven)
                {
                    tblkResult.Text = "Number is Even";
                }
                else if (!isEven)
                {
                    tblkResult.Text = "Number is Odd";
                }
            }
            else
            {
                tblkResult.Text = "Invalid Entry";
            }
            
        }
    }
}
