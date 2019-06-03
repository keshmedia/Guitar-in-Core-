using Guitar.windows;
using System.Windows;
using System.Windows.Threading;

namespace Guitar
{
    public partial class MainWindow4 : Window
    {
        public MainWindow4()
        {
            InitializeComponent();
        }
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page1();
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page2();
        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page3();
        }
        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page4();
        }
        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page5();
        }
        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page6();
        }
        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page7();
        }
        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page8();
        }
        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page9();
        }
        private void Btn10_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page10();
        }
        private void Btn11_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page11();
        }
        private void Btn12_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page12();
        }
        private void Btn13_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page13();
        }
        private void Btn14_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page14();
        }
        private void Btn15_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new pages.Page15();
        }
        private void buttonGreen_Click(object sender, RoutedEventArgs e)
        {
            windows.Window1 sW = new windows.Window1();
            sW.Show();
        }
        private void buttonGray_Click(object sender, RoutedEventArgs e)
        {
            windows.Window2 sW = new windows.Window2();
            sW.Show();
        }
        private void buttonBlue_Click(object sender, RoutedEventArgs e)
        {
            Window3 sW = new Window3();
            sW.Show();
        }
        private void buttonRed_Click(object sender, RoutedEventArgs e)
        {
            Window4 sW = new Window4();
            sW.Show();
        }
    }
}

