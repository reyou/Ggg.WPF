using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace GggWpfApp.FirstWPF
{
    /// <summary>
    /// Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Page
    {
        public ExpenseItHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            ExpenseReportPage expenseReportPage = new ExpenseReportPage(peopleListBox.SelectedItem);
            NavigationService navigationService = NavigationService;
            if (navigationService != null)
            {
                navigationService.Navigate(expenseReportPage);
            }
        }
    }
}
