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

namespace EX7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedExerciseTask(object sender, RoutedEventArgs e)
        {
            // Получем массив чисел, сплитя и приводя строку
            // Дальше двойным циклом проходимся по массиву сравнивая элемент итерации внешнего цикла со внутренним
            // Если условие выполняется, то выполняем свап элементов

            double[] array = StringTextBox.Text.Split(' ').Select(x => Convert.ToDouble(x)).ToArray();
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > 0)
                    {
                        if (array[j + 1] < 0)
                        {
                            double temp;
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
                
            MessageBox.Show(string.Join(" ", array));
        }
    }
}
