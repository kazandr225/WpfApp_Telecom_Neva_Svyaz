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
using System.Windows.Shapes;
using WpfApp_Telecom_Neva_Svyaz.Classes;
using WpfApp_Telecom_Neva_Svyaz.Pages;

namespace WpfApp_Telecom_Neva_Svyaz
{
    /// <summary>
    /// Логика взаимодействия для NumWindow.xaml
    /// </summary>
    public partial class NumWindow : Window
    {


        public NumWindow()
        {
            InitializeComponent();
        }

        public NumWindow(string number, string pass)
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow MW = new MainWindow();
            AutorizationPage AP = new AutorizationPage();

            this.Hide();
            FrameClass.MainFrame.Navigate(new AutorizationPage(1));
            //MW.Show();
            
        }
    }
}
