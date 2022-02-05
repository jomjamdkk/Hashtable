using System.Collections;
using System.Windows;
using System.Windows.Media;

namespace hashTable_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICollection collection;
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Add(Key_TxtBox.Text.ToString(), Value_TxtBox.Text.ToString()) ;
        }
        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(Key_TxtBox.Text.ToString());
        }
        private void ShowAllBtn_Click(object sender, RoutedEventArgs e)
        {
            ICollection collection = hashtable.Keys;
            string allValue = "All Value :\n";
            foreach (string key in collection) {
                allValue = allValue+"  "+hashtable[key]+"\n";
            }
            MessageBox.Show(allValue);
        }






        private void Key_gotFocus(object sender, RoutedEventArgs e)
        {
            if (Key_TxtBox.Text=="Key") {
                Key_TxtBox.Text = ""; 
            }
            Key_TxtBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF434343"));
        }

        private void Key_lostFocus(object sender, RoutedEventArgs e)
        {
            if (Key_TxtBox.Text == "") {
                Key_TxtBox.Text = "Key";
                Key_TxtBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD3D3D3"));

            }
        }


        private void Value_gotFocus(object sender, RoutedEventArgs e)
        {
            if (Value_TxtBox.Text == "Value")
            {
                Value_TxtBox.Text = "";
            }
            Value_TxtBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF434343"));
        }

        private void Value_lostFocus(object sender, RoutedEventArgs e)
        {
            if (Value_TxtBox.Text == "")
            {
                Value_TxtBox.Text = "Value";
                Value_TxtBox.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD3D3D3"));

            }
        }


    }
}
