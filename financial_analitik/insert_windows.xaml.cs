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
            string kat_rashod1 = kat_rashod.Text.ToString();
            string kat_dohod1 = kat_dohod.Text.ToString();

            string path_rashod = @"D:\\financial0402-main\\financial_analitik\\financial_analitik\\file\\rashod.txt";
            string rashod_text = rashod.Text.ToString() ;
            File.AppendAllText(path_rashod, kat_rashod1 + ": " + rashod_text + "\n");

            string path_dohod = @"D:\financial0402-main\financial_analitik\financial_analitik\file\dohod.txt";
            string dohod_text = dohod.Text.ToString();
            File.AppendAllText(path_dohod, kat_dohod1+": "+ dohod_text + "\n");
            Close();


            int chislo_rashod = Int32.Parse(rashod_text);
            int chislo_dohod = Int32.Parse(dohod_text); 
            int[] dohod_massiv = new int[chislo_dohod];
            int[] rashod_massiv = new int[chislo_rashod];
        }
    }
}
