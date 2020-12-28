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
    /// MainPage.xaml 的交互逻辑
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //定义弹出学生信息界面的方法
        public void popStuInfroPage()
        {
            StuInfroPage stuInfroPage = new StuInfroPage();
            stuInfroPage.Show();
        }

        //定义弹出水卡信息界面的方法
        public void popStuWaterPage()
        {
            StuWaterPage stuWaterPage = new StuWaterPage();
            stuWaterPage.Show();
        }

        //定义弹出报修记录界面的方法
        public void popStuRepairPage()
        {
            StuRepairPage stuRepairPage = new StuRepairPage();
            stuRepairPage.Show();
        }

        //定义弹出离寝返寝记录界面的方法
        public void popStuLFPage()
        {
            StuLFPage stuLFPage = new StuLFPage();
            stuLFPage.Show();
        }

        //定义返回选择注册登录界面的方法
        public void popMainWindow()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        //定义查看学生信息按钮的方法
        private void onStuInfro(object sender, RoutedEventArgs e)
        {
            popStuInfroPage();
        }

        //定义查看学生水卡信息按钮的方法
        private void onStuWater(object sender, RoutedEventArgs e)
        {
            popStuWaterPage();
        }

        //定义查看学生报修记录按钮的方法
        private void OnStuRepair(object sender, RoutedEventArgs e)
        {
            popStuRepairPage();
        }

        //定义查看学生离寝返寝记录按钮的方法
        private void OnStuLF(object sender, RoutedEventArgs e)
        {
            popStuLFPage();
        }
        
        //定义退出系统的方法
        private void CloseMain(object sender, RoutedEventArgs e)
        {
            popMainWindow();
            this.Close();
        }
    }
}
