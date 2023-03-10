using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Windows.Threading;
using WpfApp_Telecom_Neva_Svyaz.Classes;

namespace WpfApp_Telecom_Neva_Svyaz.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {

        DispatcherTimer timercode = new DispatcherTimer(); //таймер для введения кода

        public static string number; //поля для записи корректных данных
        public static string pass;

        public static string anum; //сгенерированный код

        public AutorizationPage()
        {
            InitializeComponent();

            //делаем необходимые элементы неактивными
            tbPassword.IsEnabled = false; 
            tbCode.IsEnabled = false;
            btnEnter.IsEnabled = false;
            btnReset.IsEnabled = false;
        }

        public AutorizationPage(int a) 
        {
            InitializeComponent();

            tbPassword.Text = pass;
            tbNumber.Text = number;

            btnEnter.IsEnabled = true;

            CodeGenerator();

            //таймер на введение кода
            timercode.Interval = new TimeSpan(0,0,10); 
            timercode.Start();
            timercode.Tick += new EventHandler(again);    
        }

        public void again(object sender, EventArgs e) //выводит сообщение и разблокирует кнопку обновления пароля
        {
            if (tbCode.Text == anum)
            {
                
            }

            else
            {
                MessageBox.Show("Сгенерируйте новый код", "Время истекло", MessageBoxButton.OK);
                
                tbCode.Text = "";

                btnEnter.IsEnabled = false;
                btnReset.IsEnabled = true;
            }
            timercode.Stop();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e) //событие на кнопку входа
        {
            

            if (tbCode.Text == "3") //сравнивам со сгенерированным кодом 
            {
                MessageBox.Show("Вы вошли!");
            }
            else
            { 
               
                if (tbCode.Text == " ") //пустое значение
                {
                    MessageBox.Show("Вы не ввели код, сгенерируйте новый");
                }
                
                if (tbCode.Text != "3" || tbCode.Text != " ") //неверный код, подставить сгенерированный код
                {
                    MessageBox.Show("Ошибка ввода");
                }

                tbCode.IsEnabled = false;
                btnEnter.IsEnabled = false;
                btnReset.IsEnabled = true;
            }
            
            timercode.Stop();
        }
         
        public void CodeGenerator() //генерация кода
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
            var char2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var nums = "1234567890";
            var symbs = "!@#$%^&*";

            Random random = new Random();
            var stringChars = new char[8];

            for (int i = 0; i <= 1; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            for (int i = 2; i <= 3; i++)
            {
                stringChars[i] = char2[random.Next(char2.Length)];
            }

            for (int i = 4; i <= 5; i++)
            {
                stringChars[i] = nums[random.Next(nums.Length)];
            }

            for (int i = 6; i <= 7; i++)
            {
                stringChars[i] = symbs[random.Next(symbs.Length)];
            }

            anum = new String(stringChars);
            MessageBox.Show(anum, "Запомните одноразовый код", MessageBoxButton.OK); //вывод сообщения со сгенерированным значением 
            tbCode.Focus(); //курсор в поле для кода
        }

        private void btnCancle_Click(object sender, RoutedEventArgs e) //очистка значений
        {
            tbCode.Text = "";
            tbNumber.Text = "";
            tbPassword.Text = "";
        }

        private void btnReset_Click(object sender, RoutedEventArgs e) //сгенерировать новый пароль
        {
            MessageBox.Show("Вывел");
            tbCode.Text = "";
            
            tbCode.IsEnabled = true;
            
            btnEnter.IsEnabled = true;
            btnReset.IsEnabled = false;

            CodeGenerator();
        }

        private void tbNumber_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.Key == Key.Enter)
            {
                if (tbNumber.Text == "" || tbNumber.Text == " ") //допущена ошибка
                {
                    MessageBox.Show("Ну а чего ты хотел?");
                }        
                    Users autoUser = BaseClass.EM.Users.FirstOrDefault(x => x.Phone == tbNumber.Text);

                    if (autoUser == null)
                    {
                        MessageBox.Show("Пользователь с таким номером не найден");
                    }
                    else 
                    {
                        tbPassword.IsEnabled = true;
                        tbPassword.Focus();
                    }
            }
        }

        private void tbPasswoed_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter) //тут проверяем правильность пароля, если верный, то выводим окно со сгенерированным кодом. Если пароль неправильный - то выводим сообщение
            {
                if (tbPassword.Text == "2") //записываем данные при успешном вводе
                {
                    number = tbNumber.Text;
                    pass = tbPassword.Text;

                    MessageBox.Show("Верный пароль");
                    FrameClass.MainFrame.Navigate(new AutorizationPage(1));
                }
                else
                {
                    MessageBox.Show("Неверный пароль", "Повторите ввод", MessageBoxButton.OK);
                }
            }
        }
    }
}
