using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Threading;
using PatternsLabSmart.Classes;

namespace PatternsLabSmart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static DispatcherTimer? timer;
        public byte num;
        public Smartphone smartphone;
        public MainWindow()
        {
            InitializeComponent();
            smartphone = new Smartphone(LabelStateNow);
        }
        void Tm_Tick(object sender, EventArgs e)
        {
            ++num;
        }
        void ResetTimer()
        {
            num = 0;
            timer?.Stop();
        }
        private void ButtonTurn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Tm_Tick;
            timer.Start();
        }

        private void ButtonTurn_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (num >= 1)
            {
                smartphone.PowerButtonClamp();
            }
            else if (num == 0)
            {
                smartphone.PowerButtonClick();
            }
            ResetTimer();
        }

        private void ButtonVolumeUp_Click(object sender, RoutedEventArgs e)
        {
            smartphone.VolumeUpClick();
        }

        private void ButtonVolumeDown_Click(object sender, RoutedEventArgs e)
        {
            smartphone.VolumeDownClick();
        }
    }
}