using System.Windows;
using System.Windows.Controls;

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

        
    }
}
