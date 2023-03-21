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
using WpfApp_Telecom_Neva_Svyaz_2.Pages;

namespace WpfApp_Telecom_Neva_Svyaz_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            BaseClass.ep = new EntitiesModel1();
            FrameClass.MainFrame = fMain;
            FrameClass.MainFrame.Navigate(new ClientsPage());
            cbEmp.ItemsSource = BaseClass.ep.Emploe.ToList();
            cbEmp.DisplayMemberPath = "Surname";
            cbEmp.SelectedValuePath = "IDEmploys";
            cbEmp.SelectedIndex = 0;
        }

        private void btnAbon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CRM_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
