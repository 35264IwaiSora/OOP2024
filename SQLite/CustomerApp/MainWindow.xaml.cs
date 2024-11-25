using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CustomerApp {
    public partial class MainWindow : Window {
        List<Customer> _customers;
        string picPath = ""; // 画像ファイルのパスを保持

        public MainWindow() {
            InitializeComponent();
            ReadDataBase();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                Picture = ImageToByteArray(CustomerImage) // ImageToByteArray メソッドで画像をバイト配列に変換
            };

            if (!string.IsNullOrEmpty(customer.Name)) {
                using (var connection = new SQLiteConnection(App.databasePass)) {
                    connection.CreateTable<Customer>(); // 顧客テーブルを作成
                    connection.Insert(customer); // 顧客情報をデータベースに挿入
                }

                TextBox_Clear();
                ReadDataBase(); // ListView を再読み込み
            } else {
                MessageBox.Show("名前を入力してください"); // 名前が空の場合は警告
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item != null) {
                item.Name = NameTextBox.Text;
                item.Phone = PhoneTextBox.Text;
                item.Address = AddressTextBox.Text;
                item.Picture = ImageToByteArray(CustomerImage); // 更新した画像をバイト配列に変換

                if (!string.IsNullOrEmpty(item.Name)) {
                    using (var connection = new SQLiteConnection(App.databasePass)) {
                        connection.CreateTable<Customer>();
                        connection.Update(item); // 顧客情報を更新
                    }
                } else {
                    MessageBox.Show("名前を入力してください"); // 名前が空の場合は警告
                }
            }

            TextBox_Clear();
            ReadDataBase(); // ListView を再読み込み
        }

        // データベースから顧客データを読み込んで ListView に表示
        private void ReadDataBase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>(); // 顧客テーブルを作成
                _customers = connection.Table<Customer>().ToList(); // 顧客リストを取得

                CustomerListView.ItemsSource = _customers; // ListView にデータを設定
            }
        }

        // 検索ボックスの文字が変更された際にフィルタリングを実行
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x => x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }

        // 顧客データを削除
        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item == null) {
                MessageBox.Show("削除する行を選択してください"); // 削除する顧客が選択されていない場合
                return;
            }

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>(); // 顧客テーブルを作成
                connection.Delete(item); // 顧客情報を削除
                TextBox_Clear();
                ReadDataBase(); // ListView を再読み込み
            }
        }

        // ListView の選択された顧客情報を TextBox に表示
        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item != null) {
                NameTextBox.Text = item.Name;
                PhoneTextBox.Text = item.Phone;
                AddressTextBox.Text = item.Address;
                if (item.Picture != null && item.Picture.Length > 0) {
                    // バイト配列から画像に変換して表示
                    CustomerImage.Source = ByteArrayToImage(item.Picture);
                }
            }
        }

        // 画像ファイルを選択し、表示
        private void AddPicButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) {
                picPath = openFileDialog.FileName; // 画像ファイルのパスを保持
                CustomerImage.Source = new BitmapImage(new Uri(picPath)); // 画像を表示
            }
        }

        // 画像を削除
        private void DeletePicButton_Click(object sender, RoutedEventArgs e) {
            CustomerImage.Source = null; // 画像をクリア
        }

        // TextBox をクリア
        private void TextBox_Clear() {
            NameTextBox.Text = "";
            PhoneTextBox.Text = "";
            AddressTextBox.Text = "";
        }

        // バイト配列を ImageSource に変換するメソッド
        public static ImageSource ByteArrayToImage(byte[] byteArray) {
            using (var ms = new MemoryStream(byteArray)) {
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = ms;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                return bitmapImage; // バイト配列を BitmapImage に変換して返す
            }
        }

        // BitmapImage をバイト配列に変換するメソッド
        public static byte[] ImageToByteArray(Image image) {
            if (image.Source is BitmapImage bitmapImage) {
                using (var ms = new MemoryStream()) {
                    BitmapEncoder encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                    encoder.Save(ms); // BitmapImage を JPEG に変換して MemoryStream に保存
                    return ms.ToArray(); // バイト配列として返す
                }
            }
            return null;
        }
    }
}
