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

namespace Quiz
{
    /// <summary>
    /// Quiz1.xaml 的交互逻辑
    /// </summary>
    public partial class Quiz1 : Window
    {
        private MediaPlayer mediaPlayer;
        int i = 0;
        public Quiz1()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Open(new Uri("Resource/BGM.mp3", UriKind.Relative));
            mediaPlayer.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(R1_1.IsChecked == true)
            {
                i++;
            }
            if (R2_4.IsChecked == true)
            {
                i++;
            }
            if (R3_2.IsChecked == true)
            {
                i++;
            }
            if (R4_3.IsChecked == true)
            {
                i++;
            }
            if (R5_1.IsChecked == true)
            {
                i++;
            }
            if (R6_4.IsChecked == true)
            {
                i++;
            }
            if (R7_2.IsChecked == true)
            {
                i++;
            }
            if (R8_1.IsChecked == true)
            {
                i++;
            }
            if (R9_4.IsChecked == true)
            {
                i++;
            }
            if (R10_3.IsChecked == true)
            {
                i++;
            }
           
            Result page = new Result(i,1);
            page.Show();
            mediaPlayer.Stop();
            this.Close();
        }


        private void AnsV1(object sender, RoutedEventArgs e)
        {
            Ans1.Visibility=Visibility.Visible;
        }
        private void AnsV2(object sender, RoutedEventArgs e)
        {
            Ans2.Visibility = Visibility.Visible;
        }
        private void AnsV3(object sender, RoutedEventArgs e)
        {
            Ans3.Visibility = Visibility.Visible;
        }
        private void AnsV4(object sender, RoutedEventArgs e)
        {
            Ans4.Visibility = Visibility.Visible;
        }
        private void AnsV5(object sender, RoutedEventArgs e)
        {
            Ans5.Visibility = Visibility.Visible;
        }
        private void AnsV6(object sender, RoutedEventArgs e)
        {
            Ans6.Visibility = Visibility.Visible;
        }
        private void AnsV7(object sender, RoutedEventArgs e)
        {
            Ans7.Visibility = Visibility.Visible;
        }
        private void AnsV8(object sender, RoutedEventArgs e)
        {
            Ans8.Visibility = Visibility.Visible;
        }
        private void AnsV9(object sender, RoutedEventArgs e)
        {
            Ans9.Visibility = Visibility.Visible;
        }
        private void AnsV10(object sender, RoutedEventArgs e)
        {
            Ans10.Visibility = Visibility.Visible;
        }
    }
}
