using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace wpf_binding
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public change_str OneWay_val { get; set; } = new change_str() { val= "OneWay_value" };
        public change_str TwoWay_val { get; set; } = new change_str() { val= "TwoWay_value" };
        public change_str OneWayToSource_val { get; set; } = new change_str() { val= "OneWayToSource_value" };
        public change_str OneTime_val { get; set; } = new change_str() { val= "OneTime_value" };
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void default_OneWay(object sender, RoutedEventArgs e)
        {
            OneWay_val.val = "OneWay_default";
        }
        private void default_TwoWay(object sender, RoutedEventArgs e)
        {
            TwoWay_val.val = "TwosWay_default";
        }
        private void default_OneWayToSource(object sender, RoutedEventArgs e)
        {
            OneWayToSource_val.val = "OneWayToSource_default";
        }
        private void default_OneTime(object sender, RoutedEventArgs e)
        {
            OneTime_val.val = "OneTime_default";
        }
    }
    public class change_str : INotifyPropertyChanged
    {
        public string _val;
        public string val {
            get
            {
                return _val;
            }
            set
            {
                _val = value;
                NotifyPropertyChanged("val");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
