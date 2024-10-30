using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        MyColor currentColor = new MyColor();
        public MainWindow() {
            InitializeComponent();
            //αチャンネルの初期値を設定
            currentColor.Color = Color.FromArgb(255, 0, 0, 0);
            colorComboBox.DataContext = GetColorList();
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        //スライドを動かすと呼ばれる
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            currentColor.Color = Color.FromRgb((byte)rSlider.Value, (byte)gSlider.Value, (byte)bSlider.Value);
            colorArea.Background = new SolidColorBrush(currentColor.Color);
            currentColor.Name = null;
        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {
            if (!stockList.Items.Contains(currentColor)) {
                stockList.Items.Insert(0, currentColor);
            } else {
                MessageBox.Show("既に登録済みです");
            }   
            
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if(stockList.SelectedIndex != -1) {
                colorArea.Background = new SolidColorBrush(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
                setSliderValue(((MyColor)stockList.Items[stockList.SelectedIndex]).Color);
            }
                
        }
        //各スライダーの値を設定
        private void setSliderValue(Color color) {
            rSlider.Value = color.R;
            gSlider.Value = color.G;
            bSlider.Value = color.B;
        }

        private void colorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if(colorComboBox.SelectedIndex != -1) {
                var tempcurrentColor = currentColor = (MyColor)((ComboBox)sender).SelectedItem;
                setSliderValue(currentColor.Color);
                currentColor.Name = tempcurrentColor.Name;
            }      
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e) {
            if (stockList.SelectedItem != null) {
                int index = stockList.SelectedIndex;
                stockList.Items.RemoveAt(index);
                currentColor.Color = Color.FromRgb(0, 0, 0);
                colorArea.Background = new SolidColorBrush(currentColor.Color);
                setSliderValue(currentColor.Color);
            }
            
        }
    }
}
