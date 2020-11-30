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

namespace String
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char[] array = new char[] {'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н','о','п','р','с','т',
                                       'у','ф','х','ц','ч','ш','щ','ь','ы','ъ','э','ю','я',' '};
            string count = countBox.Text.ToString();
            string result = "";
            for (int i = 0; i < count.Length; i++)
            {
                result += array[Array.IndexOf(array, count[i]) + 1];
            }
            resultBox.Text += $"Изначальная: {count} Переведенная: {result}" + Environment.NewLine;
            countBox.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "";
        }
    }
}
