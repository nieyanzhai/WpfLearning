using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfDatabinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<int> Nums { get; set; }
        
        public MainWindow()
        {
            Nums = new ObservableCollection<int>();
            for(var i = 0; i < 10; i++)
            {
                Nums.Add(i);
            }
            
            InitializeComponent();
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            Nums.Add(1);
        }

        private void BtnRemove_OnClick(object sender, RoutedEventArgs e)
        {
            if (Nums.Count > 0)
            {
                Nums.RemoveAt(0);
            }
        }
    }
}