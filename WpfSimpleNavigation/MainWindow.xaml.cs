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

namespace WpfSimpleNavigation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Page1 _page1;
        private Page2 _page2;
        public MainWindow()
        {
            InitializeComponent();
            
            _page1 = new Page1();
            _page2 = new Page2();
        }

        private void BtnPage1_OnClick(object sender, RoutedEventArgs e)
        {
            FrmMain.Content = _page1;
        }

        private void BtnPage2_OnClick(object sender, RoutedEventArgs e)
        {
            FrmMain.Content = _page2;
        }
    }
}