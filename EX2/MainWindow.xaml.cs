using System.Windows;

namespace EX2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedExerciseTask(object sender, RoutedEventArgs e)
        {
            // Получем первый и последний индексы символа, далее
            // Простой арифметикой получем количество символов для сабстринга,
            // Который просто обрежет строку с первого символа точки с запятой

            int index1 = StringTextBox.Text.IndexOf(';');
            int index2 = StringTextBox.Text.LastIndexOf(';');
            MessageBox.Show(StringTextBox.Text.Substring(index1 + 1, index2 - index1));
        }
    }
}