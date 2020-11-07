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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MonoRead
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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

        private void BookButton_MouseDown(object sender, RoutedEventArgs e)
        {
                PlayerWindow playerWindow = new PlayerWindow();
                playerWindow.TextToBeRead = InputBox.Text.Replace('\n', ' ');
                playerWindow.Show();
        }

        private void InputBox_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            InputBox.Text = "";
        }
    }
}
