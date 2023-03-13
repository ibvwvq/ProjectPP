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
using test.MVVM.Model;

namespace test
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Auth_Btn_Click(object sender, RoutedEventArgs e)
        {
            DbPracticContext context;
            context = new DbPracticContext();
            string loginUser = login.Text;
            string passwordUser = password.Password;


            try
            {
                User user = context.Users.Where((u) => u.Login == loginUser && u.Password == passwordUser).Single();
                MessageBox.Show("Успешно!", $"Привет, {user.Login}!");


                var MainWindow = new MainWindow();
                MainWindow.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка!", $"Неверный логин или пароль!");
            }
        }

        private void RegisterPage_Btn_Click(object sender, RoutedEventArgs e)
        {
            var RegisterWindow = new RegisterWindow();
            RegisterWindow.Show();
            this.Close();
        }
    }
}
