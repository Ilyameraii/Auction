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
    public partial class ContactsForm: Form
    {
        public ContactsForm()
        {
            InitializeComponent();
            textBoxInfo.Text += "тел. +7(123)-45-678-90" + Environment.NewLine + "e-mail: auction.items@mail.com " + Environment.NewLine + "г. Санкт-Петербург, ул. Пушкина,  д. 8, кв. 25";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
