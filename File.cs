using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace EncoderDecoderApp
{
    class File
    {
        static internal void SaveFile(TextBox TxtBoxEncryption)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file|*.txt";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, TxtBoxEncryption.Text);
                MessageBox.Show("Сохранение файла выполнено успешно.", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        static internal void OpenFile(TextBox TxtBoxEncryption)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text file|*.txt";
            if (openFileDialog.ShowDialog() == true)
                TxtBoxEncryption.Text = System.IO.File.ReadAllText(openFileDialog.FileName, System.Text.Encoding.GetEncoding(1251));
        }
    }
}
