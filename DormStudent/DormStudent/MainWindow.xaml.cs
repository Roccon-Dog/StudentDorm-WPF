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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace DormStudent
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //定义弹出注册界面的方法popSigninPage()
        public void popSigninPage()
        {
            SigninPage signinPage = new SigninPage();
            signinPage.Show();
        }

        //定义弹出登录界面的方法popLoginPage()
        public void popLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        //定义学生选择登录界面的方法onLogin()
        private void onLogin(object sender, RoutedEventArgs e)
        {          
            popLoginPage();
            this.Close();
        }

        //定义学生选择注册界面的方法onSignin()
        private void onSignin(object sender, RoutedEventArgs e)
        {
            popSigninPage();
            this.Close();
        }
    }
}
