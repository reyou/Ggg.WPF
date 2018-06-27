using System.Windows.Controls;

namespace GggWpfApp.FirstWPF
{
    /// <summary>
    /// Interaction logic for ExpenseReportPage.xaml
    /// </summary>
    public partial class ExpenseReportPage : Page
    {
        public ExpenseReportPage()
        {
            InitializeComponent();
        }
        // Custom constructor to pass expense report data
        public ExpenseReportPage(object data) : this()
        {
            // Bind to expense report data.
            DataContext = data;
        }
    }
}
