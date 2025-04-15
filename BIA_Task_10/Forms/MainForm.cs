using BIA_Task_10.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIA_Task_10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private bool loggedOrNot = false;
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void loginStrip_Click(object sender, EventArgs e)
        {
            // Открываем форму авторизации
            AuthForm authForm = new AuthForm();
            if (authForm.ShowDialog() == DialogResult.OK)
            {
                // Если авторизация успешна, устанавливаем loggedOrNot в true
                loggedOrNot = true;
                // даем доступ к продажам
                salesStrip.Enabled = true;
                salesStrip.Visible = true;
                // даем доступ к выходу 
                logoutStrip.Enabled = true;
                logoutStrip.Visible = true;
                // убираем доступ к авторизации
                loginStrip.Enabled = false;
                loginStrip.Visible = false;

                MessageBox.Show("Добро пожаловать!", "Успешный вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void logoutStrip_Click(object sender, EventArgs e)
        {
            loggedOrNot = false;
            // убираем доступ к продажам
            salesStrip.Enabled = false;
            salesStrip.Visible = false;
            // убираем доступ к выходу 
            logoutStrip.Enabled = false;
            logoutStrip.Visible = false;
            // даем доступ к авторизации
            loginStrip.Enabled = true;
            loginStrip.Visible = true;


            MessageBox.Show("Вы вышли с режима администратора", "Выход", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void itemStrip_Click(object sender, EventArgs e)
        {
            // Открываем форму Предметов
            ItemForm itemForm = new ItemForm();
            itemForm.Show();
        }

        private void contactsStrip_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.Show();
        }

        private void salesStrip_Click(object sender, EventArgs e)
        {
            SalesForms salesForms = new SalesForms();
            salesForms.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
                
        }
    }
}
