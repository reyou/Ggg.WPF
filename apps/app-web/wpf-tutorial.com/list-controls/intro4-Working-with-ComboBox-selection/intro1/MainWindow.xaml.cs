using System.Reflection;
using System.Windows;
using System.Windows.Media;

namespace intro1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbColors.ItemsSource = typeof(Colors).GetProperties();

        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (cmbColors.SelectedIndex > 0)
            {
                cmbColors.SelectedIndex = cmbColors.SelectedIndex - 1;
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (cmbColors.SelectedIndex < cmbColors.Items.Count - 1)
            {
                cmbColors.SelectedIndex = cmbColors.SelectedIndex + 1;
            }
        }

        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            cmbColors.SelectedItem = typeof(Colors).GetProperty("Blue");
        }

        private void cmbColors_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (cmbColors.SelectedItem != null)
            {
                Color selectedColor = (Color)((PropertyInfo)cmbColors.SelectedItem)?.GetValue(null, null);
                this.Background = new SolidColorBrush(selectedColor);
            }
        }
    }
}
