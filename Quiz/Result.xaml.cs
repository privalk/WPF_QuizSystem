using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Result.xaml 的交互逻辑
    /// </summary>
    public class MyViewModel : INotifyPropertyChanged
    {

        private int _sum;
        private int _time;
        public int Sum
        {
            get { return _sum; }
            set
            {
                if (_sum != value)
                {
                    _sum = value;
                    OnPropertyChanged(nameof(Sum));
                }
            }
        }
        public int Time
        {
            get { return _time; }
            set
            {
                if (_time != value)
                {
                    _time = value;
                    OnPropertyChanged(nameof(Time));
                }
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public partial class Result : Window
    {
        int tt;
        private MediaPlayer mediaPlayer;
        private DispatcherTimer countdownTimer;
        private int remainingSeconds = 10; // 初始倒计时时间（秒）
        public Result(int i, int _tt)
        {

            SoundsPlay(i);

            
            countdownTimer = new DispatcherTimer();
            countdownTimer.Interval = TimeSpan.FromSeconds(1);
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();

            tt = _tt;
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            MyViewModel viewModel = new MyViewModel
            {
                Sum = i, Time = remainingSeconds
            };
            DataContext = viewModel;
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;

            if (remainingSeconds >= 0)
            {
                MyViewModel viewModel = new MyViewModel
                {
                    Time = remainingSeconds
                };
                DataContext = viewModel;
            }
            else
            {
                countdownTimer.Stop();
                QuizPage page = new QuizPage();
                page.Show();
                this.Close();
            }
        }
        private void SoundsPlay(int i)
        {
            if (i > 5)
            {
                mediaPlayer = new MediaPlayer();
                mediaPlayer.Open(new Uri("Resource/胜利.mp3", UriKind.Relative));
                mediaPlayer.Play();
            }
            else
            {
                mediaPlayer = new MediaPlayer();
                mediaPlayer.Open(new Uri("Resource/失败.mp3", UriKind.Relative));
                mediaPlayer.Play();
            }
        }

        public static implicit operator Result(QuizPage v)
        {
            throw new NotImplementedException();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            countdownTimer.Stop();
            QuizPage page = new QuizPage();
            page.Show();
            this.Close();
        }

        private void Retry(object sender, RoutedEventArgs e)
        {
            countdownTimer.Stop();
            if (tt == 1)
            {
                Quiz1 quiz1 = new Quiz1();
                quiz1.Show();
                this.Close();
            }
            else if (tt == 2)
            {
                Quiz2 quiz2 = new Quiz2();
                quiz2.Show();
                this.Close();
            }
            else if (tt == 3)
            {
                Quiz3 quiz3 = new Quiz3();
                quiz3.Show();
                this.Close();
            }
            else if (tt == 4)
            {
                Quiz4 quiz4 = new Quiz4();
                quiz4.Show();
                this.Close();
            }

        }
    }




}
