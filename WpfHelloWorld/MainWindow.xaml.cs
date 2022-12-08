using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace WpfHelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOpen_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                InitialDirectory = Environment.CurrentDirectory
            };
            if (openFileDialog.ShowDialog() != true) return;
            var fileName = openFileDialog.FileName;
            TB.Text = File.ReadAllText(fileName);
        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            var saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog() != true) return;
            var fileName = saveFileDialog.FileName;
            File.WriteAllText(fileName, TB.Text);
        }
    }
}