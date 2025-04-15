namespace BIA_Task_10.Forms
{
    partial class SalesForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCountItem = new System.Windows.Forms.Label();
            this.labelNameSaleItem = new System.Windows.Forms.Label();
            this.textBoxNameSaleItem = new System.Windows.Forms.TextBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.buttonExport = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 80);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BIA_Task_10.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(524, 35);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Назад";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Yellow;
            this.labelName.Location = new System.Drawing.Point(210, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(171, 41);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Продажи";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelCountItem);
            this.panel1.Controls.Add(this.labelNameSaleItem);
            this.panel1.Controls.Add(this.textBoxNameSaleItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 63);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelCountItem
            // 
            this.labelCountItem.AutoSize = true;
            this.labelCountItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountItem.Location = new System.Drawing.Point(12, 38);
            this.labelCountItem.Name = "labelCountItem";
            this.labelCountItem.Size = new System.Drawing.Size(117, 16);
            this.labelCountItem.TabIndex = 6;
            this.labelCountItem.Text = "Результат запроса";
            // 
            // labelNameSaleItem
            // 
            this.labelNameSaleItem.AutoSize = true;
            this.labelNameSaleItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameSaleItem.Location = new System.Drawing.Point(12, 10);
            this.labelNameSaleItem.Name = "labelNameSaleItem";
            this.labelNameSaleItem.Size = new System.Drawing.Size(266, 16);
            this.labelNameSaleItem.TabIndex = 4;
            this.labelNameSaleItem.Text = "Введите наименование  товара для поиска";
            // 
            // textBoxNameSaleItem
            // 
            this.textBoxNameSaleItem.Location = new System.Drawing.Point(284, 9);
            this.textBoxNameSaleItem.Name = "textBoxNameSaleItem";
            this.textBoxNameSaleItem.Size = new System.Drawing.Size(271, 20);
            this.textBoxNameSaleItem.TabIndex = 2;
            this.textBoxNameSaleItem.TextChanged += new System.EventHandler(this.textBoxNameSaleItem_TextChanged);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(3, 149);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(618, 253);
            this.dataGridViewItems.TabIndex = 13;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExport.ForeColor = System.Drawing.Color.Black;
            this.buttonExport.Location = new System.Drawing.Point(217, 408);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(173, 28);
            this.buttonExport.TabIndex = 14;
            this.buttonExport.Text = "Экспортировать в Excel";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // SalesForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SalesForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForms";
            this.Load += new System.EventHandler(this.SalesForms_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCountItem;
        private System.Windows.Forms.Label labelNameSaleItem;
        private System.Windows.Forms.TextBox textBoxNameSaleItem;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Button buttonExport;
    }
}