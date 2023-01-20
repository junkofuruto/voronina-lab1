using System;
using System.Linq;
using System.Windows;

namespace EX5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedExerciseTask(object sender, RoutedEventArgs e)
        {
            // Сначала сплитим строку по пробелу и кастим каждый элемент к инту
            // Далее получаем среднюю оценку по группе (без велосипедов)
            // Ну и выводим получившийся результат

            int[] marks = StringTextBox.Text.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            double avg = marks.Average();
            MessageBox.Show($"Количество студентов, чья оценка ниже {Math.Round(avg, 2)}: {marks.Where(x => x < avg).Count()}");
        }
    }
}
