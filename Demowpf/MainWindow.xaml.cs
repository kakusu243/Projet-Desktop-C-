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

namespace Demowpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rand;
        public MainWindow()
        {
            InitializeComponent();
            rand = new Random();
        }
        private byte[] GetRandomBytes(int n)
        {
            var randomBytes= new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }
        private void direbonjour_Click(object sender, RoutedEventArgs e)
        {
            byte[] rgb = GetRandomBytes(3);
            var randomColorBrush = new SolidColorBrush(Color.FromArgb(255, rgb[0], rgb[1], rgb[2]));
            textbox1.BorderBrush = randomColorBrush;
            textbox1.Foreground = randomColorBrush;

        }
    }
}
