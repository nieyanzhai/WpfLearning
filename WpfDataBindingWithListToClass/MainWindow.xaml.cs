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

namespace WpfDataBindingWithListToClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> Persons  { get; set; }
        public MainWindow()
        {
            Persons = new ObservableCollection<Person>()
            {
                new Person(){Name = "John", Age = 20},
                new Person(){Name = "Mary", Age = 30},
                new Person(){Name = "Peter", Age = 40},
            };
            
            InitializeComponent();
        }
    }
}