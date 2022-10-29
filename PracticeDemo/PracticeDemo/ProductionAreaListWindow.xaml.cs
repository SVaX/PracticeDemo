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
    /// Логика взаимодействия для ProductionAreaListWindow.xaml
    /// </summary>
    public partial class ProductionAreaListWindow : Window
    {
        public static PracticeFiveEntities _context = new PracticeFiveEntities();
        public ProductionAreaListWindow()
        {
            InitializeComponent();
            DataGridProdArea.ItemsSource = _context.ProductionArea.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuWindow window = new MainMenuWindow();
            window.Show();
            this.Close();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var neededAreas = _context.ProductionArea.ToList();
            neededAreas = neededAreas.Where(emp => emp.Area_name.ToLower().Contains(SearchTextBox.Text.ToLower())).ToList();
            DataGridProdArea.ItemsSource = neededAreas.ToList();
        }
    }
}
