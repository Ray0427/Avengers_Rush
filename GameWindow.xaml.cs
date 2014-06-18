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
using System.Windows.Threading;
using WMPLib;

namespace 飛行遊戲
{
    /// <summary>
    /// GameWindow.xaml 的互動邏輯
    /// </summary>
    public partial class GameWindow : Window
    {

        internal DispatcherTimer timer = new DispatcherTimer();
        internal DispatcherTimer money = new DispatcherTimer();
        int time = 0, distance = 0, difficulty = 0, bossPosition;
        MediaPlayer player = new MediaPlayer();
        string place;
        //string role;

        public GameWindow(string s)
        {
            InitializeComponent();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            //bi3.UriSource = new Uri("man1.png", UriKind.Relative);
            bi3.UriSource = new Uri(s, UriKind.Relative);
            bi3.EndInit();
            background.Stretch = Stretch.Fill;
            /*background.Source = "man1.png";*/background.Source = bi3;
            if (s == "universal.jpg")
                distanceLabel.Foreground = Brushes.White;

            place = s;

            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = new TimeSpan(100000);

            money.Tick += new EventHandler(money_Tick);
            money.Interval = new TimeSpan(10000000);

        }
        int total = 0;
        private void money_Tick(object sender, EventArgs e)
        {

            distance++;

            distanceLabel.Content = "Time: " + distance.ToString();
            
            Image myImage3 = new Image();
            Random r = new Random(Guid.NewGuid().GetHashCode());

            //if (distance < 40 || distance >= 70)
                difficulty++;

            /*if (distance == 40)
            {
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();

                if (place == "universal.jpg")
                    bi3.UriSource = new Uri("180px-386Deoxys-Attacco.png", UriKind.Relative);
                else if (place == "grass.jpg")
                    bi3.UriSource = new Uri("boss-Scizor.png", UriKind.Relative);
                else if (place == "dessert.jpg")
                    bi3.UriSource = new Uri("180px-150Mewtwo.png", UriKind.Relative);                
                else
                    bi3.UriSource = new Uri("phonex.png", UriKind.Relative);

                myImage3.Width = 200;
                myImage3.Height = 200;
                bi3.EndInit();
                myImage3.Stretch = Stretch.Fill;
                myImage3.Source = bi3;

                Canvas.SetLeft(myImage3, 600);
                Canvas.SetTop(myImage3, 250);
                player.Pause();
                canvas.Children.Add(myImage3);



                player.Play();
                total++;
                bossPosition = total + 1;

            }
            else*/ if (distance == 70)
            {
                //Canvas.SetLeft(canvas.Children[bossPosition], -3000000);
               
               // for (int i = bossPosition ; i < total + 2; i++)
             //   {
                    Canvas.SetTop(canvas.Children[bossPosition], 3000000);
             //   }

            }

            //if (distance <= 70 && distance > 40)
            //{
            //    if (r.Next() % 1000 > 20)
            //    {
            //        BitmapImage bi3 = new BitmapImage();
            //        bi3.BeginInit();
            //        bi3.UriSource = new Uri("寶貝球.png", UriKind.Relative);
            //        myImage3.Width = 30;
            //        myImage3.Height = 30;
            //        bi3.EndInit();
            //        myImage3.Stretch = Stretch.Fill;
            //        myImage3.Source = bi3;

            //        Canvas.SetLeft(myImage3, 700);
            //        Canvas.SetTop(myImage3, Canvas.GetTop(canvas.Children[bossPosition])+100);
            //        player.Pause();
            //        canvas.Children.Add(myImage3);



            //        player.Play();
            //        total++;
            //    }


            //}


                   else if (r.Next() % 1000 > 800 - difficulty * 30 )//else if (r.Next() % 1000 > 800 - difficulty * 30 && (distance < 35 || distance >= 70))
            {

                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();

                if (place == "universal.jpg")
                {
                    BitmapImage role = new BitmapImage();
                    role.BeginInit();
                    role.UriSource = new Uri("man2.png", UriKind.Relative);
                    role.EndInit();
                    background.Stretch = Stretch.Fill;
                    background.Source = role;
                    switch (r.Next() % 5)
                    {
                        case 0:
                            bi3.UriSource = new Uri("180px-063Abra.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        case 1:
                            bi3.UriSource = new Uri("180px-079Slowpoke.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 2:
                            bi3.UriSource = new Uri("180px-093Haunter.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 3:
                            bi3.UriSource = new Uri("180px-151Mew.png", UriKind.Relative);
                            myImage3.Width = 151;
                            myImage3.Height = 155;
                            break;
                        case 4:
                            bi3.UriSource = new Uri("180px-201Unown.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }
                }
                else if (place == "grass.jpg")
                    switch (r.Next() % 5)
                    {
                        case 0:
                            bi3.UriSource = new Uri("Butterfree.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        case 1:
                            bi3.UriSource = new Uri("Ledian.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 2:
                            bi3.UriSource = new Uri("Shedinja.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 3:
                            bi3.UriSource = new Uri("Venomoth.png", UriKind.Relative);
                            myImage3.Width = 151;
                            myImage3.Height = 155;
                            break;
                        case 4:
                            bi3.UriSource = new Uri("Yanma.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }

                else if (place == "dessert.jpg")
                    switch (r.Next() % 5)
                    {
                        case 0:
                            bi3.UriSource = new Uri("180px-329Vibrava.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        case 1:
                            bi3.UriSource = new Uri("180px-344Claydol.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 2:
                            bi3.UriSource = new Uri("180px-375Metang.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 3:
                            bi3.UriSource = new Uri("180px-414Mothim.png", UriKind.Relative);
                            myImage3.Width = 151;
                            myImage3.Height = 155;
                            break;
                        case 4:
                            bi3.UriSource = new Uri("355Duskull.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }

                else
                    switch (r.Next() % 5)
                    {
                        case 0:
                            bi3.UriSource = new Uri("woobat.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        case 1:
                            bi3.UriSource = new Uri("swablu.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 2:
                            bi3.UriSource = new Uri("Pidgeotto.png", UriKind.Relative);
                            myImage3.Width = 156;
                            myImage3.Height = 155;
                            break;
                        case 3:
                            bi3.UriSource = new Uri("Golbat.png", UriKind.Relative);
                            myImage3.Width = 151;
                            myImage3.Height = 155;
                            break;
                        case 4:
                            bi3.UriSource = new Uri("Braviary.png", UriKind.Relative);
                            myImage3.Width = 155;
                            myImage3.Height = 155;
                            break;
                        default:
                            MessageBox.Show("ERROR");
                            break;
                    }

                bi3.EndInit();
                myImage3.Stretch = Stretch.Fill;
                myImage3.Source = bi3;

                Canvas.SetLeft(myImage3, 700);
                Canvas.SetTop(myImage3, r.Next()%3*220+50 );




                player.Pause();
                canvas.Children.Add(myImage3);
                 
                player.Play();

                total++;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {


            time++;
            background.Margin = new Thickness(background.Margin.Left - 0.5, background.Margin.Top, 0, 0);

            //if (distance >= 40 && distance < 50)
            //    for (int i = 2; i < total + 1; i++)
            //    {
            //        Canvas.SetLeft(canvas.Children[i - 1], -500);

            //        if (Canvas.GetLeft(image) + 70 > Canvas.GetLeft(canvas.Children[i]) && Canvas.GetLeft(canvas.Children[i]) > 30)
            //            if ((Canvas.GetTop(image) + image.Height >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) + image.Height <= Canvas.GetTop(canvas.Children[i]) + 155) || (Canvas.GetTop(image) >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) <= Canvas.GetTop(canvas.Children[i]) + 155))
            //            {
            //                player.Stop();
            //                money.Stop();
            //                timer.Stop();
            //                MessageBox.Show("飛行時間：" + distance + "秒");

            //                MainWindow mw = new MainWindow();
            //                this.Close();
            //                mw.Show();

            //            }
            //    }

            /*if ((distance <= 43 && distance > 40) || (distance <= 55 && distance > 49) || (distance <= 67 && distance > 61))
                Canvas.SetTop(canvas.Children[bossPosition], Canvas.GetTop(canvas.Children[bossPosition]) - 1.5);
            else if ((distance <= 49 && distance > 43) || (distance <= 61 && distance > 55) || (distance <= 70 && distance > 67))
                Canvas.SetTop(canvas.Children[bossPosition], Canvas.GetTop(canvas.Children[bossPosition]) + 1.5);
            */

            /*if (distance < 67 && distance > 40)
            {
                Random r = new Random(Guid.NewGuid().GetHashCode());
                if (r.Next() % 1000 > 950)
                {
                    Image myImage3 = new Image();
                    BitmapImage bi3 = new BitmapImage();
                    bi3.BeginInit();
                    bi3.UriSource = new Uri("寶貝球.png", UriKind.Relative);
                    myImage3.Width = 30;
                    myImage3.Height = 30;
                    bi3.EndInit();
                    myImage3.Stretch = Stretch.Fill;
                    myImage3.Source = bi3;

                    Canvas.SetLeft(myImage3, 700);
                    Canvas.SetTop(myImage3, Canvas.GetTop(canvas.Children[bossPosition]) + 100);
                    player.Pause();
                    canvas.Children.Add(myImage3);



                    player.Play();
                    total++;
                }


            }*/


            /*if (distance <= 70 && distance > 40)
                for (int i = bossPosition + 1; i < total + 2; i++)
                {
                    Canvas.SetLeft(canvas.Children[i], Canvas.GetBottom(canvas.Children[i]) +10);// Canvas.SetLeft(canvas.Children[i], Canvas.GetLeft(canvas.Children[i]) - 10);
                }
            */

            for (int i = 2; i < total + 2; i++)
            {

                /*if (distance < 40 || distance >= 70)
                {*/
                    //Canvas.SetTop(canvas.Children[i], Canvas.GetTop(canvas.Children[i]) - 6 + difficulty / 7);
                    Canvas.SetLeft(canvas.Children[i], Canvas.GetLeft(canvas.Children[i]) -6 - difficulty / 7);
                




                    /*if (Canvas.GetBottom(image) + 70 > Canvas.GetBottom(canvas.Children[i]) && Canvas.GetBottom(canvas.Children[i]) > 30)*/if (Canvas.GetLeft(image) + 70 > Canvas.GetLeft(canvas.Children[i]) && Canvas.GetLeft(canvas.Children[i]) > 30)//if (Canvas.GetLeft(image) + 70 > Canvas.GetLeft(canvas.Children[i]) && Canvas.GetLeft(canvas.Children[i]) > 30)//if (Canvas.GetLeft(image) + 70 > Canvas.GetLeft(canvas.Children[i]) && Canvas.GetLeft(canvas.Children[i]) > 30)
                        if ((Canvas.GetTop(image) + image.Height >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) + image.Height <= Canvas.GetTop(canvas.Children[i]) + 155) || (Canvas.GetTop(image) >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) <= Canvas.GetTop(canvas.Children[i]) + 155))
                        {
                            player.Stop();
                            money.Stop();
                            timer.Stop();
                            MessageBox.Show("飛行時間：" + distance + "秒");

                            MainWindow mw = new MainWindow();
                            this.Close();
                            mw.Show();

                        }
                /*}
                else
                {
                    if (Canvas.GetLeft(image) + 70 > Canvas.GetLeft(canvas.Children[i]) && Canvas.GetLeft(canvas.Children[i]) > 30)
                        if ((Canvas.GetTop(image) + image.Height >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) + image.Height <= Canvas.GetTop(canvas.Children[i]) + 25.5) || (Canvas.GetTop(image) >= Canvas.GetTop(canvas.Children[i]) && Canvas.GetTop(image) <= Canvas.GetTop(canvas.Children[i]) + 25.5))
                        {
                            player.Stop();
                            money.Stop();
                            timer.Stop();
                            MessageBox.Show("飛行時間：" + distance + "秒","遊戲結束");

                            MainWindow mw = new MainWindow();
                            this.Close();
                            mw.Show();

                        }
                }*/
            }




        }



        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {


            if (e.Key.Equals(Key.Left))
            {
                if (Canvas.GetTop(image) >= 100)
                    Canvas.SetTop(image, Canvas.GetTop(image) - 220);

            }
            else if (e.Key.Equals(Key.Right))
            {
                if (Canvas.GetTop(image) < 500)
                    Canvas.SetTop(image, Canvas.GetTop(image) + 220);

            }
            /*else if (e.Key.Equals(Key.Up))
            {
                if (Canvas.GetLeft(image) < 800)
                    Canvas.SetLeft(image, Canvas.GetLeft(image) + 100);

            }
            else if (e.Key.Equals(Key.Down))
            {
                if (Canvas.GetLeft(image) >= 0)
                    Canvas.SetLeft(image, Canvas.GetLeft(image) - 100);
            }*/
           /* else if (e.Key.Equals(Key.Space))
            {
                Image myImage3 = new Image();
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("寶貝球.png", UriKind.Relative);
                myImage3.Width = 30;
                myImage3.Height = 30;
                bi3.EndInit();
                myImage3.Stretch = Stretch.Fill;
                myImage3.Source = bi3;

                Canvas.SetLeft(myImage3, Canvas.GetLeft(image));
                Canvas.SetBottom(myImage3, Canvas.GetTop(image));

                player.Pause();
                canvas.Children.Add(myImage3);

                player.Play();
                total++;
            }*/
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //player.Stream = Properties.Resources.天空;
            //try
            //{
            //    //player.Load(); 
            //    player.Play();
            //}
            //catch (System.IO.FileNotFoundException err)
            //{
            //    MessageBox.Show("找不到音效檔" + err.FileName);
            //}
            //catch (InvalidOperationException err)
            //{
            //    MessageBox.Show("播放發生錯誤：" + err.Message);
            //}

            //try
            //{
            //    music.Source = new Uri("sky.mp3", UriKind.RelativeOrAbsolute);
            //    music.LoadedBehavior = MediaState.Play;
            //}
            //catch (Exception ex) { MessageBox.Show("媒體檔載入發生錯誤: " + ex.Message); }






            //music.Play();
             if(place == "universal.jpg")
                 player.Open(new Uri("太空戰鬥音樂.mp3", UriKind.Relative));
             else if (place == "grass.jpg")
                 player.Open(new Uri("戰鬥音樂 - 草地.mp3", UriKind.Relative));
             else if (place == "dessert.jpg")
                 player.Open(new Uri("進撃的巨人 - 紅蓮的弓矢.mp3", UriKind.Relative));
            else
            player.Open(new Uri("sky.mp3", UriKind.Relative));
            player.Play();

            timer.Start();
            money.Start();
        }
    }
}
