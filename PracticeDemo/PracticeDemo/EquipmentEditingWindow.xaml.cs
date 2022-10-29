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
    /// Логика взаимодействия для EquipmentEditingWindow.xaml
    /// </summary>
    public partial class EquipmentEditingWindow : Window
    {
        public static PracticeFiveEntities _context = new PracticeFiveEntities();
        string chosenEquipName = "";
        private Equipment _editedEquipment = new Equipment();
        public EquipmentEditingWindow()
        {
            InitializeComponent();
            UpdateListBox();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenuWindow window = new MainMenuWindow();
            window.Show();
            this.Close();
        }
        private void UpdateListBox()
        {
            EquipmentListBox.Items.Clear();
            var neededEquipment = _context.Equipment.ToList();
            foreach (Equipment equip in neededEquipment)
            {
                EquipmentListBox.Items.Add(equip.Equipment_name);
            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var neededEquip = _context.Equipment.ToList();
            neededEquip = neededEquip.Where(prod => prod.Equipment_name.Contains(chosenEquipName)).ToList();
            if (String.IsNullOrEmpty(EquipNameTextBox.Text) || String.IsNullOrEmpty(EquipTypeTextBox.Text))
            {
                MessageBox.Show("Не все поля были заполнены");
                return;
            }
            var neededProdId = _context.ProductionArea.ToList();
            neededProdId = neededProdId.Where(prod => prod.Production_area_id.Equals(neededEquip[0].Id_production_area)).ToList();
            if (neededProdId.Count() == 0 || String.IsNullOrEmpty(EquipProdIdTextBox.Text))
            {
                MessageBox.Show("В поле номера участка введено неверное значение");
                return;
            }
            _editedEquipment.Equipment_name = EquipNameTextBox.Text;
            _editedEquipment.Type = EquipTypeTextBox.Text;
            _editedEquipment.Id_production_area = int.Parse(EquipProdIdTextBox.Text);
            _context.Equipment.Remove(neededEquip[0]);
            _context.Equipment.Add(_editedEquipment);
            _context.SaveChanges();
            MessageBox.Show("Оборудование успешно изменено!");
            EquipNameTextBox.Clear();
            EquipProdIdTextBox.Clear();
            EquipTypeTextBox.Clear();
            UpdateListBox();
        }

        private void EquipmentListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                chosenEquipName = EquipmentListBox.SelectedItem.ToString();
                var neededEquip = _context.Equipment.ToList();
                neededEquip = neededEquip.Where(prod => prod.Equipment_name.Contains(chosenEquipName)).ToList();
                EquipNameTextBox.Text = neededEquip[0].Equipment_name;
                EquipTypeTextBox.Text = neededEquip[0].Type;
                EquipProdIdTextBox.Text = neededEquip[0].Id_production_area.ToString();
            }
            catch
            {

            }
        }
    }
}
