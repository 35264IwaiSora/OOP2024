using CustomerApp.Objects;
using Microsoft.Win32;
using SQLite;
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

namespace CustomerApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        List<Customer> _customers;
        public MainWindow() {
            InitializeComponent();
            ReadDataBase();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) {
            var customer = new Customer() {
                Name = NameTextBox.Text,
                Phone = PhoneTextBox.Text,
                Address = AddressTextBox.Text,
                IamgePass = CustomerImage.Source !=  null ? (CustomerImage.Source as BitmapImage)?.UriSource.AbsolutePath : null,
            };

            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Insert(customer);
            }
            ReadDataBase(); //ListView表示
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if (item != null) {
                item.Name = NameTextBox.Text;
                item.Phone = PhoneTextBox.Text;
                item.Address = AddressTextBox.Text;
                using (var connection = new SQLiteConnection(App.databasePass)) {
                    connection.CreateTable<Customer>();
                    connection.Update(item);
                }
            }

            ReadDataBase();
        }
        //ListView表示
        private void ReadDataBase() {
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                _customers = connection.Table<Customer>().ToList();

                CustomerListView.ItemsSource = _customers;
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            var filterList = _customers.Where(x=>x.Name.Contains(SearchTextBox.Text)).ToList();
            CustomerListView.ItemsSource = filterList;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if(item == null) {
                MessageBox.Show("削除する行を選択してください");
                return;
            }
            using (var connection = new SQLiteConnection(App.databasePass)) {
                connection.CreateTable<Customer>();
                connection.Delete(item);

                ReadDataBase(); //ListView表示
            }
        }

        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var item = CustomerListView.SelectedItem as Customer;
            if(item != null) {
                NameTextBox.Text = item.Name;
                PhoneTextBox.Text = item.Phone;
                AddressTextBox.Text = item.Address;
                if (!string.IsNullOrEmpty(item.IamgePass)) {
                    CustomerImage.Source = new BitmapImage(new Uri(item.IamgePass));
                }
            }
            
        }

        private void AddPicButton_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "画像ファイル(*.jpg;*.jpeg:*.png;)|*.jpg;*jpeg;*.png";

            if(openFileDialog.ShowDialog() == true) {
                string filepath = openFileDialog.FileName;
                CustomerImage.Source = new BitmapImage(new Uri(filepath));

            }
                
        }

        private void DeletePicPButton_Click(object sender, RoutedEventArgs e) {
            CustomerImage.Source = null;
        }
    }
}
