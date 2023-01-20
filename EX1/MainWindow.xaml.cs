using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace EX1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedExerciseTask(object sender, RoutedEventArgs e)
        {
            // В начале добавляем в лист строки из текстбоксов, сортируем их по длине
            // Далее по методу GetCharCount получаем количество символов в соответствии с заданием
            // Выводим все в месседж бокс

            List<string> sourceStrings = new List<string>(new string[] { FirstStringTextBox.Text, SecondStringTextBox.Text }).OrderBy(x => x.Length).ToList();
            MessageBox.Show($"Букв 'П' в длинной строке: {GetCharCount('п', sourceStrings.Last())}\n" +
                            $"Букв 'Р' в короткой строке: {GetCharCount('р', sourceStrings.First())}");
        }
        /// <summary>
        /// Метод получения количества определенного символа в строке
        /// </summary>
        /// <param name="character">Целевой символ</param>
        /// <param name="source">Целевая строка</param>
        /// <returns></returns>
        private static int GetCharCount(char character, string source)
        {
            return source.Length - string.Join("", string.Join("", source.Select(x => char.ToLower(x))).Split(character)).Length;
        }
    }
}
