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

namespace Quiz
{
    /// <summary>
    /// QuizPage.xaml 的交互逻辑
    /// </summary>
    public partial class QuizPage : Window
    {
        private DispatcherTimer countdownTimer;
        private int remainingSeconds = 3; // 初始倒计时时间（秒）

        public QuizPage()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tt1.IsChecked == false && tt2.IsChecked == false && tt3.IsChecked == false && tt4.IsChecked == false)
            {
                MessageBox.Show("请选择套题", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                countdownText.Text = remainingSeconds.ToString();
                countdownTimer = new DispatcherTimer();
                countdownTimer.Interval = TimeSpan.FromSeconds(1);
                countdownTimer.Tick += CountdownTimer_Tick;
                countdownTimer.Start();
            }

        }
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {

            remainingSeconds--;

            if (remainingSeconds >= 0)
            {
                countdownText.Text = remainingSeconds.ToString();
            }
            else
            {
                countdownTimer.Stop();

                if (tt1.IsChecked == true)
                {
                    Quiz1 page = new Quiz1();
                    page.Show();
                    this.Close();
                }
                else if (tt2.IsChecked == true)
                {
                    Quiz2 page = new Quiz2();
                    page.Show();
                    this.Close();
                }
                else if (tt3.IsChecked == true)
                {
                    Quiz3 page = new Quiz3();
                    page.Show();
                    this.Close();

                }
                else
                {
                    Quiz4 page = new Quiz4();
                    page.Show();
                    this.Close();

                }
            }



        }
    }
}
