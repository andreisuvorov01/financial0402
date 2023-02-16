using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace financial_analitik
{
    /// <summary>
    /// Логика взаимодействия для insert_windows.xaml
    /// </summary>
    public partial class insert_windows : Window
    {
        public insert_windows()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = @"D:\IS32\parada_suvorov\financial_analitik\financial_analitik\dohod.txt";
            string rashod_text = rashod.Text.ToString() ;
            File.AppendAllText(path, rashod_text + "\n");
        }
    }
}
