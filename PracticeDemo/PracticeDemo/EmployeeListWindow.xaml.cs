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
using System.Windows.Shapes;

namespace PracticeDemo
{
    /// <summary>
    /// Логика взаимодействия для EmployeeListWindow.xaml
    /// </summary>
    public partial class EmployeeListWindow : Window
    {
        public static PracticeFiveEntities _context = new PracticeFiveEntities();
        public EmployeeListWindow()
        {
            InitializeComponent();
            DataGridEmployee.ItemsSource = _context.Employee.ToList();

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuWindow window = new MainMenuWindow();
            window.Show();
            this.Close();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var neededEmployees = _context.Employee.ToList();
            neededEmployees = neededEmployees.Where(emp => emp.Nsp.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList();
            DataGridEmployee.ItemsSource = neededEmployees.ToList();
        }
    }
}
