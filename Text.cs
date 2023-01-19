using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace EncoderDecoderApp
{
    class Text
    {
        static internal void shifdesh(TextBox textBoxEncryption, bool encryption = true)
        {
            string text = textBoxEncryption.Text;
            textBoxEncryption.Clear();

            for (int i = 0; i < text.Length; i++)
                textBoxEncryption.Text += encryption ? (char)(text[i] + 22) :
                    (char)(text[i] - 22);
        }

        static internal void Error()
        {
            MessageBox.Show("Поле ввода текста должно быть заполнено!",
                "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        static internal void SaveFile(TextBox TxtBoxEncryption)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text file|*.txt";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, TxtBoxEncryption.Text);
                MessageBox.Show("Сохранение файла выполнено успешно.", "Сохранение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        static internal void OpenFile(TextBox TxtBoxEncryption)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                TxtBoxEncryption.Text = System.IO.File.ReadAllText(openFileDialog.FileName, System.Text.Encoding.GetEncoding(1251));
        }
    }
}
