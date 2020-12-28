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
    /// StuInfroPage.xaml 的交互逻辑
    /// </summary>
    public partial class StuInfroPage : Window
    {

        //定义数据库将学生信息返回至查看学生信息界面的方法 reStuInfro()
        public void reStuInfro()
        {
            //将需要查询的学号设为登录界面输入的学号
            string stuxuehao = LoginPage.studentID;

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

            //开启连接
            con.Open();

            //创建查询命令语句strcmd
            string strcmd = "select Sno, Sname, Ssex, Smajor, Sdorm from student where Sno=";
            strcmd = strcmd + stuxuehao;//strcmd后加上需要查询的学号

            //在定义的con对象上执行查询命令strcmd
            MySqlCommand sqlcmd = new MySqlCommand(strcmd, con);

            //用DataReader定义一个读对象reader，来读数据库中的数据
            MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {
                /*
                  在reader读的过程中，
                   若找到学号相同的数据，则将学号及学号对应的姓名、性别、
                  专业、宿舍返回到查看学生信息界面
                  */
                姓名.Content = reader["Sname"].ToString();
                性别.Content = reader["Ssex"].ToString();
                学号.Content = reader["Sno"].ToString();
                专业.Content = reader["Smajor"].ToString();
                宿舍.Content = reader["Sdorm"].ToString();
            }

            con.Close();//关闭连接
            reader.Close(); //关闭读对象reader
        }

        //定义学生信息界面将学生信息返回给学生的方法StuInfroResult()
        public void StuInfroResult()
        {
            reStuInfro();
        }

        //定义查看学生信息界面中确认按钮的方法
        private void Return_Mainpage(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        public StuInfroPage()
        {
            InitializeComponent();
            StuInfroResult();//界面显示学生信息
        }
    }
}
