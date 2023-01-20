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

namespace EX3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedExerciseTask(object sender, RoutedEventArgs e)
        {
            // Для начала создадим объект StringBuilder, это не только упростит
            // задачу сборки строки, но и предотвратить копирование данных.
            // Далее с помощью связки методов Join и Split мы удаляем все запятые,
            // а Substring и IndexOf ограничат длину зоны обрабатываемой строки
            // Потом просто присоединяем остаток строки и в конце реплейсим все плюсы на минусы

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(string.Join("" , StringTextBox.Text.Substring(0, StringTextBox.Text.IndexOf('.')).Split(',')));
            stringBuilder.Append(StringTextBox.Text.Substring(StringTextBox.Text.IndexOf('.')));
            StringTextBox.Text = stringBuilder.ToString().Replace('+', '-');
        }
    }
}
