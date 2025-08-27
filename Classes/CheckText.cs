using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VerificationTask.Classes
{
    internal class CheckText
    {
        public static bool checkingText(KeyPressEventArgs e) {
            return (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Convert.ToChar(","));
        }
        public static void checkingOnPointText(TextBox textBox)
        {
            string text = textBox.Text;

            string pattern = @"(\d+)\,(\d+)\,";

            text = Regex.Replace(text, pattern, match =>
            {
                return match.Groups[1].Value + "," + match.Groups[2].Value;
            });

            // Обновляем текст в текстовом поле
            textBox.Text = text;

            // Устанавливаем позицию курсора в конец текста
            textBox.SelectionStart = text.Length;
        }
        
    }
}
