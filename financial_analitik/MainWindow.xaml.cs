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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace financial_analitik
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (var sr = new StreamReader(@"D:\\financial0402-main\\financial_analitik\\financial_analitik\\file\\rashod.txt"))
            {
                var str = sr.ReadToEnd();
                rashod_main.Text = str.ToString();
            }
            using (var sr = new StreamReader(@"D:\\financial0402-main\\financial_analitik\\financial_analitik\\file\\dohod.txt"))
            {
                var str = sr.ReadToEnd();
                dohod_main.Text = str.ToString();
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            insert_windows insert_Windows = new insert_windows();
            insert_Windows.Show();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var sr = new StreamReader(@"D:\\financial0402-main\\financial_analitik\\financial_analitik\\file\\rashod.txt"))
            {
                var str = sr.ReadToEnd();
                rashod_main.Text = str.ToString();
            }
            using (var sr = new StreamReader(@"D:\\financial0402-main\\financial_analitik\\financial_analitik\\file\\dohod.txt"))
            {
                var str = sr.ReadToEnd();
                dohod_main.Text = str.ToString();
            }
        }
    }
}
