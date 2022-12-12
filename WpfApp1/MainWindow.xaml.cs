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

namespace WpfApp1
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
            Отель win1 = new Отель();
            win1.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Расходы win2 = new Расходы();
            win2.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Рейсы win3 = new Рейсы();
            win3.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Экскурсии win4 = new Экскурсии();
            win4.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Экскурсионные_агенства win5 = new Экскурсионные_агенства();
            win5.Show();
            Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Доходы win6 = new Доходы();
            win6.Show();
            Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Информация_о_туристе win7 = new Информация_о_туристе();
            win7.Show();
            Close();
        }
    }
}
