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
using 飛行遊戲.Properties;

namespace 飛行遊戲
{
    /// <summary>
    /// Statistics.xaml 的互動邏輯
    /// </summary>
   
    public partial class Statistics : Window
    {
        public string distance;
        public Statistics()
        {
            InitializeComponent();
             
                    }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void count(object sender, RoutedEventArgs e)
        {
            
            this.textBlock1.Text = "Time: " + distance.ToString();

        }






        }
    }


