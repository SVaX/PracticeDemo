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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Word = Microsoft.Office.Interop.Word;

namespace PracticeDemo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        private void EmployeeListButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeListWindow window = new EmployeeListWindow();
            window.Show();
            this.Close();
        }

        private void ProductionAreaListButton_Click(object sender, RoutedEventArgs e)
        {
            ProductionAreaListWindow window = new ProductionAreaListWindow();
            window.Show();
            this.Close();
        }

        

        private void EquipmentAddingButton_Click(object sender, RoutedEventArgs e)
        {
            EquipmentAddingWindow window = new EquipmentAddingWindow();
            window.Show();
            this.Close();
        }

        private void EquipmentEditingButton_Click(object sender, RoutedEventArgs e)
        {
            EquipmentEditingWindow window = new EquipmentEditingWindow();
            window.Show();
            this.Close();
        }

        private void EquipmentDeletingButton_Click(object sender, RoutedEventArgs e)
        {
            EquipmentDeletingWindow window = new EquipmentDeletingWindow();
            window.Show();
            this.Close();
        }
        private void WordEquipmentGettingButton_Click(object sender, RoutedEventArgs e)
        {
            List<Equipment> allEquipment;
            using (PracticeFiveEntities usersEntities = new PracticeFiveEntities())
            {
                var app = new Word.Application();
                Word.Document document = app.Documents.Add();

                allEquipment = usersEntities.Equipment.ToList();

                int startRowIndex = 1;
                Word.Paragraph paragraph = document.Paragraphs.Add();
                Word.Range range = paragraph.Range;

                range.Text = "Оборудование";
                paragraph.set_Style("Заголовок 1");
                range.InsertParagraphAfter();

                var tableParagraph = document.Paragraphs.Add();
                var tableRange = tableParagraph.Range;
                var clientTable = document.Tables.Add(tableRange, allEquipment.Count() + 1, 3);
                clientTable.Borders.InsideLineStyle = clientTable.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                clientTable.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                Word.Range cellRange;
                cellRange = clientTable.Cell(1, 1).Range;
                cellRange.Text = "Наименование оборудования";
                cellRange = clientTable.Cell(1, 2).Range;
                cellRange.Text = "Тип";
                cellRange = clientTable.Cell(1, 3).Range;
                cellRange.Text = "Номер производственного участка";
                clientTable.Rows[1].Range.Bold = 1;
                clientTable.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                startRowIndex++;
                foreach(Equipment equip in allEquipment)
                {
                    cellRange = clientTable.Cell(startRowIndex, 1).Range;
                    cellRange.Text = equip.Equipment_name.ToString();
                    cellRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = clientTable.Cell(startRowIndex, 2).Range;
                    cellRange.Text = equip.Type.ToString();
                    cellRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    cellRange = clientTable.Cell(startRowIndex, 3).Range;
                    cellRange.Text = equip.Id_production_area.ToString();
                    cellRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    startRowIndex++;
                }
                document.Words.Last.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdSectionBreakNextPage);

                app.Visible = true;
            }
        }

        private void EmployeeListButton_GotMouseCapture(object sender, MouseEventArgs e)
        {
            InfoTxtBlock.Text = "Переход к окну просмотра списка сотрудников";
        }

        private void ProductionAreaListButton_GotMouseCapture(object sender, MouseEventArgs e)
        {
            InfoTxtBlock.Text = "Переход к окну просмотра списка производственных участков";
        }

        private void WordEquipmentGettingButton_GotMouseCapture(object sender, MouseEventArgs e)
        {
            InfoTxtBlock.Text = "Генерирует Word документ с информацией о имеющемся в системе оборудовании";
        }

        private void EquipmentAddingButton_GotMouseCapture(object sender, MouseEventArgs e)
        {
            InfoTxtBlock.Text = "Переход к окну добавления нового оборудования";
        }

        private void EquipmentEditingButton_GotMouseCapture(object sender, MouseEventArgs e)
        {
            InfoTxtBlock.Text = "Переход к окну изменения уже существующего оборудования";
        }

        private void EquipmentDeletingButton_GotMouseCapture(object sender, MouseEventArgs e)
        {
            InfoTxtBlock.Text = "Переход к окну удаления оборудования";
        }
    }
}
