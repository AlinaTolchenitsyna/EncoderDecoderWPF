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
using System.Windows.Shapes;

namespace EncoderDecoderApp
{
    /// <summary>
    /// Логика взаимодействия для Help.xaml
    /// </summary>
    public partial class Help : Window
    {
        public Help()
        {
            InitializeComponent();
        }

        private void TxtBoxLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TxtBoxLogin.Text == "")
            {
                PasswordBox.IsEnabled = false;
            }
            else
            {
                PasswordBox.IsEnabled = true;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TxtBoxPassword.Text = PasswordBox.Password;
            TxtBoxPassword.Visibility = Visibility.Visible;
            PasswordBox.Visibility = Visibility.Hidden;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordBox.Password = TxtBoxPassword.Text;
            TxtBoxPassword.Visibility = Visibility.Hidden;
            PasswordBox.Visibility = Visibility.Visible;
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBoxLogin.Text == "Admin" && (PasswordBox.Password == "admin" || TxtBoxPassword.Text == "admin"))
            {
                //Encryption encryption = new Encryption();
            }
        }
    }
}
