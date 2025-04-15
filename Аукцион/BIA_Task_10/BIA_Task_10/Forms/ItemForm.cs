using BIA_Task_10.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIA_Task_10.Forms
{
    public partial class ItemForm : Form
    {
        private int _itemcount = 0;
        public ItemForm()
        {
            InitializeComponent();

            LoadAndInitData();

            var DirectoryType = Program.context.Directories.OrderBy(p => p.DirectoryName).ToList();
            DirectoryType.Insert(0, new Models.Directory
            {
                DirectoryName = "Все типы"
            }
            );
            comboDirectory.DataSource = DirectoryType;
            comboDirectory.DisplayMember = "DirectoryName";
            comboDirectory.ValueMember = "DirectoryID";
        }
        private void LoadAndInitData()
        {
            // получаем текущие данные из бд
            var currentItems = Program.context.Items.Join(Program.context.Directories, p => p.DirectoryID, t => t.DirectoryID,
                (p, t) => new { p.ItemID, p.ItemName, t.DirectoryName, p.ReleaseYear, p.OwnerName, p.AssessedValue, p.Descriptions, p.DirectoryID }).ToList();
            // В качестве источника данных присваиваем список данных

            dataGridViewItems.DataSource = currentItems;
            dataGridViewItems.Columns[7].Visible = false;
            //заголовки столбцов

            dataGridViewItems.Columns[0].HeaderText = "Артикул предмета";
            dataGridViewItems.Columns[1].HeaderText = "Название";
            dataGridViewItems.Columns[2].HeaderText = "Директория";
            dataGridViewItems.Columns[3].HeaderText = "Дата выпуска";
            dataGridViewItems.Columns[4].HeaderText = "Владелец";
            dataGridViewItems.Columns[5].HeaderText = "Оценочная стоимость";
            dataGridViewItems.Columns[6].HeaderText = "Описание";
            _itemcount = dataGridViewItems.Rows.Count;
            labelCountItem.Text = $"Результат запроса:{currentItems.Count}" +
                $" записей из {_itemcount}";
        }
        private void UpdateData()
        {
            // получаем текущие данные из бд
            var currentItems = Program.context.Items.Join(Program.context.Directories, p => p.DirectoryID, t => t.DirectoryID,
                (p, t) => new { p.ItemID, p.ItemName, t.DirectoryName, p.ReleaseYear, p.OwnerName, p.AssessedValue, p.Descriptions, p.DirectoryID }).ToList();

            // выбор только тех товаров, которые принадлежат данной категории
            if (comboDirectory.SelectedIndex > 0)
            {
                currentItems = currentItems.Where(y => y.DirectoryID == (comboDirectory.SelectedItem as Models.Directory).DirectoryID).ToList();
            }

            // выбор тех товаров, в названии которых есть поисковая строка
            currentItems = currentItems.Where(p => p.ItemName.ToLower().Contains(textBoxNameItem.Text.ToLower())).ToList();

            // Сортировка
            if (comboSort.SelectedIndex >= 0)
            {
                switch (comboSort.SelectedIndex)
                {
                    case 0: // Сортировка по возрастанию цены
                        currentItems = currentItems.OrderBy(p => p.AssessedValue).ToList();
                        break;
                    case 1: // Сортировка по убыванию цены
                        currentItems = currentItems.OrderByDescending(p => p.AssessedValue).ToList();
                        break;
                    case 2: // Сортировка по возрастанию названия
                        currentItems = currentItems.OrderBy(p => p.ItemName).ToList();
                        break;
                    case 3: // Сортировка по убыванию названия
                        currentItems = currentItems.OrderByDescending(p => p.ItemName).ToList();
                        break;
                }
            }
            // В качестве источника данных присваиваем список данных
            dataGridViewItems.DataSource = currentItems;
            // отображение количества записей
            labelCountItem.Text = $" Результат запроса: {currentItems.Count} записей из {_itemcount}";

        }
        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNameItem_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
