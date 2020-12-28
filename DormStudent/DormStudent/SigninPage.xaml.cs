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
    /// SigninPage.xaml 的交互逻辑
    /// </summary>
    public partial class SigninPage : Window
    {
        public SigninPage()
        {
            InitializeComponent();
        }

        //设置变量flag，banner，以便后面对注册成功或失败两种情况分类
        int flag = 1;
        int banner = 1;


        //定义学生填写注册信息的方法 onStudentSignin()
        public void onStudentSignin()
        {
            //如果有未填写的信息，则弹出提示,并将flag和banner置为0
            if (StudentID.Text == "" || StudentPassword.Text == "" || StudentPasswordAgain.Text == ""
                || StudentName.Text == "" || StudentGender.Text == "" || StudentMajor.Text == "" || StudentDorm.Text == "")
            {
                MessageBox.Show("请填写完整信息", "确定");
                flag = 0;
                banner = 0;
            }

            //如果两次输入的密码不一致，则弹出提示,并将flag置为0
            else if (StudentPassword.Text != StudentPasswordAgain.Text)
            {
                MessageBox.Show("两次输入密码不一致，请重新输入", "确定");
                flag = 0;
                banner = 0;
            }
            else
            {
                flag = 1;
                banner = 1;
            }
        }

        //定义注册界面将注册信息转化成注册的学生信息的方法 SetStudent()
        public void SetStudent()
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

            /*
             若banner等于1，则可以进行下一步操作
             检测数据库中有无与注册的学生信息中学号相同的数据
             */
            if (banner == 1)
            {
                try
                {
                    //开启连接
                    con.Open();

                    //创建查询命令语句
                    string strcmd = "select Sno from student";

                    //在定义的con对象上执行查询命令strcmd
                    MySqlCommand sqlcmd = new MySqlCommand(strcmd, con);

                    //用DataReader定义一个读对象reader，来读数据库中的数据
                    MySqlDataReader reader = sqlcmd.ExecuteReader();

                    while (reader.Read())
                    {
                        /*
                         在reader读的过程中，
                           若发现有与注册的学生信息中学号相同的数据，则弹出"此学号已被注册！",
                         将banner置为0,并跳出循环
                           若没有相同的数据，则将banner置为1
                         */
                        if (reader["Sno"].ToString() == StudentID.Text)
                        {
                            MessageBox.Show("此学号已被注册！", "确定");
                            banner = 0;
                            break;
                        }
                        else
                        {
                            banner = 1;
                        }
                    }
                    reader.Close();
                }
                catch
                {
                }
            }


            /*
             若flag和banner都等于1，则可以进行下一步操作
             若无与注册的学生信息中学号相同的数据，则可创建转化注册的学生信息的命令语句
             */
            if (flag == 1 && banner == 1)
            {
                try
                {
                    //创建插入命令语句
                    string strcmd2 = "insert into student values ('" 
                        + StudentID.Text.ToString() + "','" + StudentPassword.Text.ToString() + "','" 
                        + StudentName.Text.ToString() + "'," + "'" + StudentGender.Text.Trim() + "','" 
                        + StudentMajor.Text.ToString() + "','" + StudentDorm.Text.ToString() +
                        "')";

                    //在定义的con对象上执行插入命令sqlcmd2
                    MySqlCommand sqlcmd2 = new MySqlCommand(strcmd2, con);

                    //在定义的con对象上执行插入命令,若插入失败，则跳转至catch中
                    sqlcmd2.ExecuteNonQuery();

                    if (flag == 1)
                    {
                        MessageBox.Show("注册成功！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("注册失败！", "提示");
                    }
                   con.Close();//关闭连接

                }
                catch
                {
                    flag = 0;
                    con.Close();//关闭连接
                }
            }

        }

        //定义系统将注册的学生信息添加到数据库中的方法 addStudent()
        private void addStudent(object sender, RoutedEventArgs e)
        {
            onStudentSignin();
            SetStudent();           
        }

        //点击返回按钮，返回选择登录注册界面
        private void Return_Mainwindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
