using System.Windows;
using System.Windows.Controls;
using System.Threading;

namespace EncoderDecoderApp
{
    /// <summary>
    /// Логика взаимодействия для Help.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        int counter = 0;

        private void TxtBoxLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TxtBoxLogin.Text == "")
            {
                TxtBoxPassword.IsEnabled = false;
                PasswordBox.IsEnabled = false;
                LblPassword.Opacity = 0.5;
                CheckBoxShowPassword.IsEnabled = false;
                CheckBoxShowPassword.Opacity = 0.5;
                BtnEnter.IsEnabled = false;
            }
            else
            {
                TxtBoxPassword.IsEnabled = true;
                PasswordBox.IsEnabled = true;
                LblPassword.Opacity = 1;
                if (PasswordBox.Visibility == Visibility.Visible)
                {
                    if (PasswordBox.Password != "")
                    {
                        CheckBoxShowPassword.IsEnabled = true;
                        CheckBoxShowPassword.Opacity = 1;
                        BtnEnter.IsEnabled = true;
                    }
                }
                else
                {
                    if (TxtBoxPassword.Text != "")
                    {
                        CheckBoxShowPassword.IsEnabled = true;
                        CheckBoxShowPassword.Opacity = 1;
                        BtnEnter.IsEnabled = true;
                    }
                }
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
            if(PasswordBox.Visibility == Visibility.Visible)
            {
                TxtBoxPassword.Text = PasswordBox.Password;
            }
            if (TxtBoxLogin.Text == "User" && TxtBoxPassword.Text == "User")
            {
                Encryption mainWindow = new Encryption();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                if (counter == 0)
                {
                    MessageBox.Show("Неверно введен логин или пароль.", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
                    counter++;
                }
                else if (counter == 1)
                {
                    MessageBox.Show("Неверно введен логин или пароль. У вас осталась одна попытка.", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
                    counter++;
                }
                else
                {
                    GridAuthorization.Opacity = 0.5;
                    MessageBox.Show("Вы истратили попытки на вход, повторите попытку через 5 секунд.", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
                    Thread.Sleep(5000);
                    GridAuthorization.Opacity = 1;
                    counter = 0;
                    TxtBoxLogin.Text = "";
                    PasswordBox.Password = "";
                    PasswordBox.Visibility = Visibility.Visible;
                    PasswordBox.IsEnabled = true;
                    TxtBoxPassword.Text = "";
                    TxtBoxPassword.Visibility = Visibility.Hidden;
                    CheckBoxShowPassword.IsEnabled = false;
                    CheckBoxShowPassword.IsChecked = false;
                    BtnEnter.IsEnabled = false;
                }
                
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "")
            {
                CheckBoxShowPassword.IsEnabled = false;
                CheckBoxShowPassword.Opacity = 0.5;
                BtnEnter.IsEnabled = false;
            }
            else
            {
                CheckBoxShowPassword.IsEnabled = true;
                CheckBoxShowPassword.Opacity = 1;
                BtnEnter.IsEnabled = true;
            }
        }

        private void TxtBoxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtBoxPassword.Text == "")
            {
                CheckBoxShowPassword.IsEnabled = false;
                CheckBoxShowPassword.Opacity = 0.5;
                BtnEnter.IsEnabled = false;
            }
            else
            {
                CheckBoxShowPassword.IsEnabled = true;
                CheckBoxShowPassword.Opacity = 1;
                BtnEnter.IsEnabled = true;
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
