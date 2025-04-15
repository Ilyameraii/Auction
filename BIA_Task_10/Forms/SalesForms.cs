using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace BIA_Task_10.Forms
{
    public partial class SalesForms: Form
    {
        private int _salecount = 0;
        public SalesForms()
        {
            InitializeComponent();
            LoadAndInitData();
        }
        private void LoadAndInitData()
        {
            // получаем текущие данные из бд
            var currentSales = Program.context.Sales.Join(Program.context.Items, p => p.ItemID, t => t.ItemID,
                (p, t) => new { p.SaleID, p.ItemID, t.ItemName, p.AuctionDate, p.StartPrice, p.LastPrice, p.SaleStatus, p.ClientFIO}).ToList();
            // В качестве источника данных присваиваем список данных

            dataGridViewItems.DataSource = currentSales;
            //заголовки столбцов

            dataGridViewItems.Columns[0].HeaderText = "ID продажи";
            dataGridViewItems.Columns[1].HeaderText = "ID предмета";
            dataGridViewItems.Columns[2].HeaderText = "Название предмета";
            dataGridViewItems.Columns[3].HeaderText = "Дата аукциона";
            dataGridViewItems.Columns[4].HeaderText = "Начальная цена";
            dataGridViewItems.Columns[5].HeaderText = "Последняя цена";
            dataGridViewItems.Columns[6].HeaderText = "Статус продажи";
            dataGridViewItems.Columns[7].HeaderText = "ФИО покпупателя";
            _salecount = dataGridViewItems.Rows.Count;
            labelCountItem.Text = $"Результат запроса:{currentSales.Count}" +
                $" записей из {_salecount}";
        }
        private void UpdateData()
        {
            // получаем текущие данные из бд
            var currentSales = Program.context.Sales.Join(Program.context.Items, p => p.ItemID, t => t.ItemID,
                (p, t) => new { p.SaleID, p.ItemID, t.ItemName, p.AuctionDate, p.StartPrice, p.LastPrice, p.SaleStatus, p.ClientFIO }).ToList();

            // выбор тех товаров, в названии которых есть поисковая строка
            currentSales = currentSales.Where(p => p.ItemName.ToLower().Contains(textBoxNameSaleItem.Text.ToLower())).ToList();

            // В качестве источника данных присваиваем список данных
            dataGridViewItems.DataSource = currentSales;
            // отображение количества записей
            labelCountItem.Text = $" Результат запроса: {currentSales.Count} записей из {_salecount}";

        }
        private void SalesForms_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxNameSaleItem_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            // создаем новую книгу Excel, указываем количество листов и добавляем рабочую книгу Workbook
            var application = new Excel.Application();
            application.SheetsInNewWorkbook = 1;
            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);
            
            // называем листы
            Excel.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "Справочник продаж";

            // добавляем название колонок
            for (int i = 0; i < 8; i++)
            {
                worksheet.Cells[1, i+1] = dataGridViewItems.Columns[i].HeaderCell.Value;
            }

            // добавляем информацию в таблицу
            for (int i = 0; i < 8; i++)
            {
                for (int j = 2; j < dataGridViewItems.Rows.Count; j++)
                {
                    worksheet.Cells[j, i + 1] = dataGridViewItems[i,j-2].Value;
                }
            }
            application.Visible = true;
        }
    }
}
