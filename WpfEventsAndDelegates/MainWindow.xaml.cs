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

namespace WpfEventsAndDelegates
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

        private void MyValueUserControl_OnValueChanged(object sender, EventArgs e)
        {
            var tbValueText = (sender as ValueUserControl)?.TBValue.Text;
            if (string.IsNullOrEmpty(tbValueText)) return;
            var value = int.Parse(tbValueText);
            MyTextBlock.Text += $"Value is {value}\n";
        }
    }
}