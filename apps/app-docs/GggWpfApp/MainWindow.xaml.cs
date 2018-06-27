using System;
using System.Windows;
using System.Windows.Controls.Ribbon;
using System.Windows.Navigation;
using GggWpfApp.ControlsSamples;
using GggWpfApp.FirstWPF;

namespace GggWpfApp
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


        private void Ribbon_OnClick(object sender, RoutedEventArgs e)
        {
            RibbonWindowSample window = new RibbonWindowSample();
            window.Show();
        }

        private void FirstWpf_OnClick(object sender, RoutedEventArgs e)
        {
            FirstWPF.MainWindow window = new FirstWPF.MainWindow();
            window.Show();
        }
    }
}
