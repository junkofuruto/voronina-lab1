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

namespace EX4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedExerciseTask(object sender, RoutedEventArgs e)
        {
            // Создаем объект StringBuilder для упрощения форматирования результата
            // Метод Where имеет возможность создания предиката с интексированим, что дает
            // Возможность взять и сравнить логическое произведение индекса и единицы:
            //          00011001                00011000
            //          00000001 &              00000001 &
            //          --------                --------
            //          00000001 (нечетное)     00000000 (четное)
            // Дальше просто по условиям применяем алгоритм к строкам

            StringBuilder result = new StringBuilder();
            if (SecondStringTextBox.Text.Length > 30)
                result.AppendLine(string.Join("", FirstStringTextBox.Text.Where((ch, index) => (index & 1) == 0)));
            if (FirstStringTextBox.Text.Length < 15)
                result.AppendLine(string.Join("", SecondStringTextBox.Text.Where((ch, index) => (index & 1) != 0)));
            MessageBox.Show(result.ToString(), "RESULT");
        }
    }
}
