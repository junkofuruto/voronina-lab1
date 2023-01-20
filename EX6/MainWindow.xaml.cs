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

namespace EX6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedExerciseTask(object sender, RoutedEventArgs e)
        {
            // Создаем нужные объекты: стрингбилдер для хранения предела, переменную количества элементов входящих в предел и сам массив с элементами
            // Далее циклом проходим по всему массиву и по условиям производим замену 2 на 0 и добавляем числа в переделе
            // Ну и выводим

            StringBuilder stringBuilder = new StringBuilder();
            int count = 0;
            double[] values = SecondTextBox.Text.Split(' ').Select(x => Convert.ToDouble(x)).ToArray();
            for (int i = 0; i < Convert.ToInt32(FirstTextBox.Text); i++)
            {
                if (values[i] < 2) values[i] = 0;
                else if (values[i] >= 3 && values[i] <= 7)
                {
                    stringBuilder.Append($"{values[i]} ");
                    count++;
                }
            }
            MessageBox.Show($"Результат: {string.Join(" ", values)}\n\n\n" +
                            $"Элементы в пределе от 3 до 7: {stringBuilder}\n" +
                            $"Количество таких элементов: {count}");
        }
    }
}
