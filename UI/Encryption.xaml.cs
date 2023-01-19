using System.Windows;
using Microsoft.Win32;

namespace EncoderDecoderApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Encryption : Window
    {
        public Encryption()
        {
            InitializeComponent();
        }


        private void BtnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBoxEncryption.Text != "")
                Text.shifdesh(TxtBoxEncryption);
            else
                Text.Error();
        }

        

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }

        private void BtnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBoxEncryption.Text != "")
                Text.shifdesh(TxtBoxEncryption, false);
            else
                Text.Error();
        }

        private void BtnCopy_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBoxEncryption.Text != "")
                Clipboard.SetText(TxtBoxEncryption.Text);
            else
                Text.Error();
        }

        private void BtnPaste_Click(object sender, RoutedEventArgs e)
        {
            TxtBoxEncryption.Text = TxtBoxEncryption.Text +
                Clipboard.GetText();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            TxtBoxEncryption.Clear();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Text.SaveFile(TxtBoxEncryption);
        }

        private void BtnFile_Click(object sender, RoutedEventArgs e)
        {
            Text.OpenFile(TxtBoxEncryption);
        }
    }
}
