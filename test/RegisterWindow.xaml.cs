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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }
        private void Register_Btn_Click(object sender, RoutedEventArgs e)
        {
            string loginUser = login.Text;
            string passwordUser = password.Password;
            using (var context = new DbPracticContext())
            {
                User us = new User();
                us.Login = loginUser;
                us.Password = passwordUser;
                context.Users.Add(us);

                context.SaveChanges();

                var Main = new MainWindow();
                Main.Show();
                this.Close();
            }
        }
        private void AuthPage_Btn_Click(object sender, RoutedEventArgs e)
        {
            var Main = new MainWindow();
            Main.Show();
            this.Close();
        }
    }
}