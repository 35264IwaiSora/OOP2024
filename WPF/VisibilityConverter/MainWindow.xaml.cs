using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace VisibilityConverter {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Resources["ButtonBrashuKey"] = new SolidColorBrush(Colors.DarkGreen);
        }

        private void Button_Checked(object sender, RoutedEventArgs e) {
           if(rButton.IsChecked == true) {
               Resources["ButtonBrashuKey"] = new SolidColorBrush(Colors.Red);
            }
           if(bButton.IsChecked == true) {
               Resources["ButtonBrashuKey"] = new SolidColorBrush(Colors.Blue);
           }
           if (gButton.IsChecked == true) {
               Resources["ButtonBrashuKey"] = new SolidColorBrush(Colors.Green);
           }
        }
    }
}