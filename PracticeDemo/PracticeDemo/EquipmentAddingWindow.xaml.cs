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
    /// Логика взаимодействия для EquipmentAddingWindow.xaml
    /// </summary>
    public partial class EquipmentAddingWindow : Window
    {
        public static PracticeFiveEntities _context = new PracticeFiveEntities();
        private Equipment _newEquipment = new Equipment();
        public EquipmentAddingWindow()
        {
            InitializeComponent();
            DataContext = _newEquipment;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(EquipNameTextBox.Text) || String.IsNullOrEmpty(EquipTypeTextBox.Text))
            {
                MessageBox.Show("Не все поля были заполнены");
                return;
            }
            var neededProdId = _context.ProductionArea.ToList();
            neededProdId = neededProdId.Where(prod => prod.Production_area_id.Equals(_newEquipment.Id_production_area)).ToList();
            if (neededProdId.Count() == 0 || String.IsNullOrEmpty(EquipProdIdTextBox.Text))
            {
                MessageBox.Show("В поле номера участка введено неверное значение");
                return;
            }
            _context.Equipment.Add(_newEquipment);
            _context.SaveChanges();
            MessageBox.Show("Оборудование успешно добавлено!");
            EquipNameTextBox.Clear();
            EquipProdIdTextBox.Clear();
            EquipTypeTextBox.Clear();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuWindow window = new MainMenuWindow();
            window.Show();
            this.Close();
        }
    }
}
