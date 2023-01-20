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

namespace EX8
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedExerciseTask(object sender, RoutedEventArgs e)
        {
            // Данных из текстбоксов записываем в двумерный массив строк, далее приводим его элементы к int
            // Инициализируем переменные значений минимального и максимального значений
            // Циклом проходим по всем элементам матрицы и по условиям записываем результаты в мин\макс переменные

            var array = new string[3][] { 
                new string[4] { _11.Text, _12.Text, _13.Text, _14.Text },
                new string[4] { _21.Text, _22.Text, _23.Text, _24.Text },
                new string[4] { _31.Text, _32.Text, _33.Text, _34.Text }
            }.Select(x => x.Select(y => Convert.ToDouble(y)));

            double min = double.MaxValue, max = double.MinValue;
            foreach (var el in array)
            {
                foreach (var result in el)
                {
                    if (result > max) max = result;
                    else if (result < min) min = result;
                }
            }
            MessageBox.Show($"{(max + min) / 2.0}");
        }
    }
}
