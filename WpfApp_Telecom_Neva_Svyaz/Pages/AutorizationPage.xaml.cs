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

namespace WpfApp_Telecom_Neva_Svyaz.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {

        public static string number; //поля для записи корректных данных
        public static string pass;

        public static string anum; //сгенерированный код

        public int sec = 10; //задаем требуемое для ожидание время
        public AutorizationPage()
        {
            InitializeComponent();

            //делаем необходимые элементы неактивными
            tbPassword.IsEnabled = false; 
            tbCode.IsEnabled = false;
            btnEnter.IsEnabled = false;
            btnReset.IsEnabled = false;
        }

        public AutorizationPage(int a) //сюда еще код передать чтоли?
        {
            InitializeComponent();

            tbPassword.Text = pass;
            tbNumber.Text = number;

            btnEnter.IsEnabled = true;

            tbCode.Focus(); //курсор в поле для кода
        }

        //Сделать таймер на отсчет лимита на введени сгенерированного кода

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

                btnEnter.IsEnabled = false;
                btnReset.IsEnabled = true;
            }
        }
         //можно удалить окно с введением кода, ведь оно уже есть на странице с авторизаций, в конструктор нужно закинуть таймер
         //требуется доработать генерацию на заданные по заданию символы
         //следует что-то сделать с конструктором, лучше всего будет просто обновить страницу с сохранением данных
        public void CodeGenerator() //генерация кода
        { 
            Random rnd = new Random();
            int num = rnd.Next(10000, 99999999); //случайное 8-ое число

            MessageBox.Show(num.ToString(), "Запомните одноразовый код", MessageBoxButton.OK); //вывод сообщения со сгенерированным значением //добавить событие на нажатие по кнопке ОК
             
            anum = num.ToString(); //записываем код для проверки //возможно придется поменять местами с месседж боксом
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
        }

        private void tbNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) //далее прописать метод для сверки значения из базы, можно через вложенное условие
            {
                if (tbNumber.Text == "1") //успешный ввод
                {
                    //MessageBox.Show("Добро пожаловать");

                    tbPassword.IsEnabled = true;
                    tbPassword.Focus();
                }
                else //допущена ошибка
                {
                    MessageBox.Show("Ну а чего ты хотел?");
                }
            }
        }

        private void tbPasswoed_KeyDown(object sender, KeyEventArgs e)
        {
            NumWindow NW = new NumWindow();

            if (e.Key == Key.Enter) //тут проверяем правильность пароля, если верный, то выводим окно со сгенерированным кодом. Если пароль неправильный, то выводим сообщение
            {
                if (tbPassword.Text == "2") //записываем данные при успешном вводе
                {
                    number = tbNumber.Text;
                    pass = tbPassword.Text;

                    MessageBox.Show("Верный пароль");

                    CodeGenerator();
                    //NW.Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль", "Повторите ввод", MessageBoxButton.OK);
                }
            }
        }
    }
}
