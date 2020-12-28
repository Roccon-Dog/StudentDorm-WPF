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
    /// StuWaterPage.xaml 的交互逻辑
    /// </summary>
    public partial class StuWaterPage : Window
    {

        //定义数据库将学生水卡信息返回至查看学生水卡信息界面的方法 reStuWater()
        public void reStuWater()
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
            string strcmd = "select WID as '水卡号', Wmon as '水卡余额' from water where Sno=";
            strcmd = strcmd + stuxuehao;//strcmd后加上需要查询的学号

            //新建一个SqlCommand实例cmd，其要执的SQL语句为strcmd，连接对象为con
            MySqlCommand cmd = new MySqlCommand(strcmd, con);

            //建立一个DataAdapter对象sda，来读数据库中的数据
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

            //建立DataTable对象dt
            DataTable dt = new DataTable();

            //将sda的查询结果填充到dt中
            sda.Fill(dt);

            //查看学生水卡信息界面中的表格名为WaterData，
            //此处命令代表将dt中的查询结果输入到WaterData中
            WaterData.ItemsSource = dt.DefaultView;

            con.Close();//关闭连接
        }


        //定义查看学生水卡信息界面将学生水卡信息返回给学生的方法 StuWaterResult()
        public void StuWaterResult()
        {
            reStuWater();
        }


        public StuWaterPage()
        {
            InitializeComponent();
            StuWaterResult();//界面显示学生水卡信息

        }
    }
}
