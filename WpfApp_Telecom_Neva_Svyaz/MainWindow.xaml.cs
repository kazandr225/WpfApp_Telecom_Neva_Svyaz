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
using WpfApp_Telecom_Neva_Svyaz.Classes;
using WpfApp_Telecom_Neva_Svyaz.Pages;

namespace WpfApp_Telecom_Neva_Svyaz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //454566 - номер
        //221 - пароль
        public MainWindow()
        {
            InitializeComponent();

            BaseClass.EM = new EntitiesModel();
            FrameClass.MainFrame = fMain;
            FrameClass.MainFrame.Navigate(new AutorizationPage());
        }
    }
}
