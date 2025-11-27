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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == string.Empty)
            {
                if(TextBox.Text == string.Empty) TextBox.Text += '1';
                else if (TextBox.Text[0]=='0') TextBox.Text = TextBox.Text.Substring(1) + '1';
                else TextBox.Text += '1';

            }
            else
            {
                if (TextBox_2.Text == string.Empty) TextBox_2.Text += '1';
                else if (TextBox_2.Text[0] == '0') TextBox_2.Text = TextBox_2.Text.Substring(1) + '1';
                else TextBox_2.Text += '1';
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == string.Empty)
            {
                if (TextBox.Text == string.Empty) TextBox.Text += '2';
                else if (TextBox.Text[0] == '0') TextBox.Text = TextBox.Text.Substring(1) + '2';
                else TextBox.Text += '2';

            }
            else
            {
                if (TextBox_2.Text == string.Empty) TextBox_2.Text += '2';
                else if (TextBox_2.Text[0] == '0') TextBox_2.Text = TextBox_2.Text.Substring(1) + '2';
                else TextBox_2.Text += '2';
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == string.Empty)
            {
                if (TextBox.Text == string.Empty) TextBox.Text += '3';
                else if (TextBox.Text[0] == '0') TextBox.Text = TextBox.Text.Substring(1) + '3';
                else TextBox.Text += '3';

            }
            else
            {
                if (TextBox_2.Text == string.Empty) TextBox_2.Text += '3';
                else if (TextBox_2.Text[0] == '0') TextBox_2.Text = TextBox_2.Text.Substring(1) + '3';
                else TextBox_2.Text += '3';
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) 
        {
            if (TextBox_1.Text == string.Empty)
            {
                if (TextBox.Text == string.Empty) TextBox.Text += '4';
                else if (TextBox.Text[0] == '0') TextBox.Text = TextBox.Text.Substring(1) + '4';
                else TextBox.Text += '4';

            }
            else
            {
                if (TextBox_2.Text == string.Empty) TextBox_2.Text += '4';
                else if (TextBox_2.Text[0] == '0') TextBox_2.Text = TextBox_2.Text.Substring(1) + '4';
                else TextBox_2.Text += '4';
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == string.Empty)
            {
                if (TextBox.Text == string.Empty) TextBox.Text += '5';
                else if (TextBox.Text[0] == '0') TextBox.Text = TextBox.Text.Substring(1) + '5';
                else TextBox.Text += '5';

            }
            else
            {
                if (TextBox_2.Text == string.Empty) TextBox_2.Text += '5';
                else if (TextBox_2.Text[0] == '0') TextBox_2.Text = TextBox_2.Text.Substring(1) + '5';
                else TextBox_2.Text += '5';
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == string.Empty)
            {
                if (TextBox.Text == string.Empty) TextBox.Text += '6';
                else if (TextBox.Text[0] == '0') TextBox.Text = TextBox.Text.Substring(1) + '6';
                else TextBox.Text += '6';

            }
            else
            {
                if (TextBox_2.Text == string.Empty) TextBox_2.Text += '6';
                else if (TextBox_2.Text[0] == '0') TextBox_2.Text = TextBox_2.Text.Substring(1) + '6';
                else TextBox_2.Text += '6';
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == string.Empty)
            {
                if (TextBox.Text == string.Empty) TextBox.Text += '7';
                else if (TextBox.Text[0] == '0') TextBox.Text = TextBox.Text.Substring(1) + '7';
                else TextBox.Text += '7';

            }
            else
            {
                if (TextBox_2.Text == string.Empty) TextBox_2.Text += '7';
                else if (TextBox_2.Text[0] == '0') TextBox_2.Text = TextBox_2.Text.Substring(1) + '7';
                else TextBox_2.Text += '7';
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == string.Empty)
            {
                if (TextBox.Text == string.Empty) TextBox.Text += '8';
                else if (TextBox.Text[0] == '0') TextBox.Text = TextBox.Text.Substring(1) + '8';
                else TextBox.Text += '8';

            }
            else
            {
                if (TextBox_2.Text == string.Empty) TextBox_2.Text += '8';
                else if (TextBox_2.Text[0] == '0') TextBox_2.Text = TextBox_2.Text.Substring(1) + '8';
                else TextBox_2.Text += '8';
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == string.Empty)
            {
                if (TextBox.Text == string.Empty) TextBox.Text += '9';
                else if (TextBox.Text[0] == '0') TextBox.Text = TextBox.Text.Substring(1) + '9';
                else TextBox.Text += '9';

            }
            else
            {
                if (TextBox_2.Text == string.Empty) TextBox_2.Text += '9';
                else if (TextBox_2.Text[0] == '0') TextBox_2.Text = TextBox_2.Text.Substring(1) + '9';
                else TextBox_2.Text += '9';
            }
        } 

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == string.Empty)
            {
                if (TextBox.Text == string.Empty) TextBox.Text = "0";
                else if (TextBox.Text[0] != '0')
                {
                    TextBox.Text += "0";
                }
                else return;
            }
            else
            {
                if (TextBox_2.Text == string.Empty) TextBox_2.Text = "0";
                else if (TextBox_2.Text[0] != '0')
                {
                    TextBox_2.Text += "0";
                }
                else return;
            }
        }

        private void Button_Click_comma(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == string.Empty)
            {
                if (TextBox.Text == string.Empty) return;
                else if (TextBox.Text.Contains(","))
                {
                    return;
                }
                else
                {
                    TextBox.Text += ",";
                }
            }
            else
            {
                if (TextBox_2.Text == string.Empty) return;
                else if (TextBox_2.Text.Contains(","))
                {
                    return;
                }
                else
                {
                    TextBox_2.Text += ",";
                }
            }
        }


        private void Button_Click_add(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == string.Empty) return;
            else TextBox_1.Text = "+";
        }

        private void Button_Click_subtract(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == string.Empty) return;
            else TextBox_1.Text = "-";
        }

        private void Button_Click_multyply(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == string.Empty) return;
            else TextBox_1.Text = "*";
        }

        private void Button_Click_devide(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == string.Empty) return;
            else TextBox_1.Text = "/";
        }

        private void Button_Click_change_symbol(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == string.Empty)
            {
                if (string.IsNullOrEmpty(TextBox.Text))
                {
                    TextBox.Text = "-";
                }
                else if (TextBox.Text[0] == '-')
                {
                    TextBox.Text = TextBox.Text.Substring(1);
                }
                else
                {
                   TextBox.Text = "-" + TextBox.Text;
                }
                
            }
            else
            {
                if (string.IsNullOrEmpty(TextBox_2.Text))
                {
                    TextBox_2.Text = "-";
                }
                else if (TextBox_2.Text[0] == '-')
                {
                    TextBox_2.Text = TextBox_2.Text.Substring(1);
                }
                else
                {
                    TextBox_2.Text = "-" + TextBox_2.Text;
                }
            }
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            TextBox.Text = string.Empty;
            TextBox_1.Text = string.Empty;
            TextBox_2.Text = string.Empty;
            TextBox_3.Text = string.Empty;

        }

        private void Button_Click_enter(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == string.Empty || TextBox_1.Text == string.Empty || TextBox_2.Text == string.Empty)
            {
                MessageBox.Show("Не все поля заполнены!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            double a, b;
            a = Convert.ToDouble(TextBox.Text);
            b = Convert.ToDouble(TextBox_2.Text);

            switch (TextBox_1.Text)
            {
                case "+":
                    TextBox_3.Text = Convert.ToString(a + b);
                    break;

                case "-":
                    TextBox_3.Text = Convert.ToString(a - b);
                    break;

                case "*":
                    TextBox_3.Text = Convert.ToString(a * b);
                    break;

                case "/":
                    if (TextBox_2.Text == "0" || TextBox_2.Text == "0,")
                    {
                        MessageBox.Show("На ноль делить нельзя!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    else
                    {
                        TextBox_3.Text = Convert.ToString(a / b);
                    }
                    break;

            }

        }

    }
}
