using BIA_Task_10.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIA_Task_10.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Пример проверки авторизации
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            try
            {
                List<User> users = Program.context.Users.ToList();
                User u = users.FirstOrDefault(p => p.UserLogin == username && p.UserPassword == password);
                if (u != null)
                {
                    // Если авторизация успешна, закрываем форму с результатом OK
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "" ;
           textBoxPassword.Text = "";
        }

        private void pictureBoxUnvisible_Click(object sender, EventArgs e)
        {
            pictureBoxUnvisible.Visible = false;
            pictureBoxVisible.Visible = true;

            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void pictureBoxVisible_Click(object sender, EventArgs e)
        {
            pictureBoxVisible.Visible = false;
            pictureBoxUnvisible.Visible = true;
            textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
