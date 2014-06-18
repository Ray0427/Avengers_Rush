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

namespace 飛行遊戲
{
    /// <summary>
    /// OptionWindow.xaml 的互動邏輯
    /// </summary>
    public partial class OptionWindow : Window
    {

        public string place;
        public string role;
        public OptionWindow()
        {
            InitializeComponent();
            

        }

        private void Confirm(object sender, RoutedEventArgs e)
        {



            if (sky.IsChecked == true)
            {
                place = "skyyy.jpg";
                role = "man1.png";
            }

            else if (universe.IsChecked == true)
                place = "universal.jpg";
            else if (grass.IsChecked == true)
                place = "grass.jpg";
            else if (dessert.IsChecked == true)
                place = "dessert.jpg";


             
            this.DialogResult = true;

            this.Close();
           
    
           
           
        }
    }
}
