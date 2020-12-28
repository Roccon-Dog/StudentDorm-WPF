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
    /// LoginPage.xaml 的交互逻辑
    /// </summary>
    public partial class LoginPage : Window
    {
        public static string studentID;

        public LoginPage()
        {
            InitializeComponent();
        }

        //设置一个变量flag,以便后面对登录成功或失败两种情况分类
        int flag = 0;

        //定义返回选择登录注册界面的方法
        private void Return_Mainwindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        //定义登录的方法
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            studentID = StuID.Text;
            onStudentLogin();
            
            //若flag等于1，则关闭此窗口
            if (flag == 1)
            {
                this.Close();
            }
        }

        //定义数据库检查学号密码是否错误的方法Check()
        public void Check()
        {
            /*
            Server 是连接的数据库服务器，localhost 为本机
            User Id 是登录数据源的用户名
            Password 是登录数据源的密码
            Database studorm   连接的数据库名为studorm
            */
            string str = "Server=localhost;" +
                "User ID=root;" +
                "Password=;" +
                "Database=studorm;";

            //定义con对象，实例化链接
            MySqlConnection con = new MySqlConnection(str);

            try
            {
                //开启连接
                con.Open();

                //创建查询命令语句strcmd
                string strcmd = "select Sno, Upassword from student";

                //在定义的con对象上执行查询命令strcmd
                MySqlCommand sqlcmd = new MySqlCommand(strcmd, con);

                //用DataReader定义一个读对象reader，来读数据库中的数据
                MySqlDataReader reader = sqlcmd.ExecuteReader();

                while (reader.Read())
                {
                    /*
                      在reader读的过程中，
                      若发现数据库中有与注册的学生信息中学号和密码相同的数据，则弹出"登录成功！",将flag置为1
                        并弹出主界面
                      若没有相同的数据，则将flag置为0
                      */
                    if (reader["Sno"].ToString() == StuID.Text
                        &&
                        reader["Upassword"].ToString() == psw.Password)
                    {
                        MessageBox.Show("登录成功！", "确定");
                        flag = 1;
                        popMainPage();//弹出主界面
                    }
                    else
                    {        
                    }
                }
                reader.Close();//关闭读对象reader
            }
            catch
            {
                con.Close();//关闭连接
            }
            con.Close();//关闭连接       
        }

        //定义登录界面弹出密码错误提示的方法_Show()
        public void _Show()
        {

            //若flag等于0，则弹出提示
            if (flag == 0)
            {
                MessageBox.Show("学号或密码错误！", "确定");
            }

        }

        //定义登录界面弹出主界面的方法popMainPage()
        public void popMainPage()
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        //定义学生输入登录信息的方法 onStudentLogin()
        public void onStudentLogin()
        {
            //系统通过查询数据库检查学号或密码是否错误
            Check();

            //若密码错误，则弹出提示
            _Show();

        }
    }
}
