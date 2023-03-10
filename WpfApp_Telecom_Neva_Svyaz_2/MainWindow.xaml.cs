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

            FrameClass.MainFrame = fMain;
            FrameClass.MainFrame.Navigate(new WorkingPage());
        }
    }
}
