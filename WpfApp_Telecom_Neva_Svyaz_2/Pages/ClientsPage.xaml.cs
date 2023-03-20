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
using WpfApp_Telecom_Neva_Svyaz_2.Classes;

namespace WpfApp_Telecom_Neva_Svyaz_2.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public ClientsPage()
        {
            InitializeComponent();
            dgSubscribers.ItemsSource = BaseClass.EM.Subscriber.ToList();
            cbActive.IsChecked = true; //вывод клиентов с активными договорами
        }

        private void cbActive_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cbNotActive_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
