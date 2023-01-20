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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EX9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedExerciseTask(object sender, RoutedEventArgs e)
        {
            // Создаем стрингбилдер для хранения результат
            // Делим строку с матрицей по символу новой строки, далее по пробелу, чтобы получить двумерный масив
            // Массив строк приводим к int и далее циклом проходимся по каждой строчке и находим минимальное значение

            StringBuilder stringBuilder = new StringBuilder();
            var array = StringTextBox.Text.Split('\n').Select(x => x.Split(' ').Select(y => Convert.ToDouble(y)));
            foreach (var el in array)
                stringBuilder.Append($"{el.Min()} ");
            MessageBox.Show(stringBuilder.ToString());
        }
    }
}
