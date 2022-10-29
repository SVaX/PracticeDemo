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
    /// Логика взаимодействия для EquipmentDeletingWindow.xaml
    /// </summary>
    public partial class EquipmentDeletingWindow : Window
    {
        public static PracticeFiveEntities _context = new PracticeFiveEntities();
        string chosenEquipName = "";
        public EquipmentDeletingWindow()
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
            if (MessageBox.Show($"Вы точно хотите удалить оборудование '{neededEquip[0].Equipment_name}'?", "Attention!",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                _context.Equipment.Remove(neededEquip[0]);
                _context.SaveChanges();
                MessageBox.Show("Оборудование успешно удалено!");
                EquipNameTextBox.Clear();
                EquipProdIdTextBox.Clear();
                EquipTypeTextBox.Clear();
                UpdateListBox();
            }
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
