using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Threading;

namespace MonoRead
{
    /// <summary>
    /// Interaction logic for PlayerWindow.xaml
    /// </summary>
    public partial class PlayerWindow : Window
    {

        private uint Position = 0;

        private bool paused = true; 

        public PlayerWindow()
        {
            InitializeComponent();
        }

        private string textToBeRead;

        public string TextToBeRead
        {
            get { return textToBeRead; }
            set { textToBeRead = value; }
        }

        private int delay = 300;

        public int Delay
        {
            get { return delay; }
            set
            {
                if (value > 0)
                {
                    delay = 0;
                    double _1 = 60d / value;
                    delay = Convert.ToInt32(_1 * 1000);
                };
            }
        }

        private void Reset()
        {
            Position = 0;
            PositionSlider.Value = 0;
            PlayPause.Source = new BitmapImage(new Uri("PlayIcon.png", UriKind.Relative));
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimiseButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void RateSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
            {
                RateLabel.Content = RateSlider.Value;
                Delay = (int)RateSlider.Value;
            }
        }

        private void PositionSlider_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            paused = true;
        }

        private void PositionSlider_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Position = (uint)PositionSlider.Value;
            paused = false;
        }

        private void PositionSlider_GotMouseCapture(object sender, MouseEventArgs e)
        {
            paused = true;
        }

        private void PositionSlider_LostMouseCapture(object sender, MouseEventArgs e)
        {
            Position = (uint)PositionSlider.Value;
            paused = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PositionSlider.Maximum = textToBeRead.Split(' ').Length - 1;
        }

        async private void PlayPause_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (paused)
            {
                paused = false;
                PlayPause.Source = new BitmapImage(new Uri("PauseIcon.png", UriKind.Relative));
            }
            else if (!paused)
            {
                PlayPause.Source = new BitmapImage(new Uri("PlayIcon.png", UriKind.Relative));
                paused = true;
            }
            while (Position <= textToBeRead.Split(' ').Length - 1 && paused == false)
            {
                DisplayLabel.Content = textToBeRead.Split(' ')[Position];
                await Task.Delay(delay);
                Position++;
                PositionSlider.Value = Position;
                if (paused) { break; }
            }
            if (Position == textToBeRead.Split(' ').Length) { Reset(); }
        }
    }
}
