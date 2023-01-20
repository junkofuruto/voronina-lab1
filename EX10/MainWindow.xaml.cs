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

namespace EX10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedExerciseTask(object sender, RoutedEventArgs e)
        {
            // Преобразуем массив, инициализируем нужные переменные, проходимся по массиву

            var array = StringTextBox.Text.Split('\n').Select(x => x.Split(' ').Select(y => Convert.ToInt32(y)));
            int arrX = -1, arrY = -1, max = int.MinValue;
            for (int i = 0; i < array.Count(); i++)
            {
                for (int j = 0; j < array.ElementAt(i).Count(); i++)
                {
                    if (array.ElementAt(i).ElementAt(j) > max)
                    {
                        max = array.ElementAt(i).ElementAt(j);
                        arrY = i;
                        arrX = j;
                    }
                }
            }

            MessageBox.Show($"({arrX},{arrY})");
        }
    }
}
