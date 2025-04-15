namespace BIA_Task_10.Forms
{
    partial class ItemForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCountItem = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelNameItem = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.textBoxNameItem = new System.Windows.Forms.TextBox();
            this.comboSort = new System.Windows.Forms.ComboBox();
            this.comboDirectory = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Yellow;
            this.labelName.Location = new System.Drawing.Point(210, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(194, 41);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Предметы";
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
            this.panel2.TabIndex = 9;
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
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(15, 199);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(609, 214);
            this.dataGridViewItems.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelCountItem);
            this.panel1.Controls.Add(this.labelCategory);
            this.panel1.Controls.Add(this.labelNameItem);
            this.panel1.Controls.Add(this.labelSort);
            this.panel1.Controls.Add(this.textBoxNameItem);
            this.panel1.Controls.Add(this.comboSort);
            this.panel1.Controls.Add(this.comboDirectory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 97);
            this.panel1.TabIndex = 10;
            // 
            // labelCountItem
            // 
            this.labelCountItem.AutoSize = true;
            this.labelCountItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountItem.Location = new System.Drawing.Point(9, 81);
            this.labelCountItem.Name = "labelCountItem";
            this.labelCountItem.Size = new System.Drawing.Size(117, 16);
            this.labelCountItem.TabIndex = 6;
            this.labelCountItem.Text = "Результат запроса";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(12, 41);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(130, 16);
            this.labelCategory.TabIndex = 5;
            this.labelCategory.Text = "Выберите категорию";
            // 
            // labelNameItem
            // 
            this.labelNameItem.AutoSize = true;
            this.labelNameItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameItem.Location = new System.Drawing.Point(12, 10);
            this.labelNameItem.Name = "labelNameItem";
            this.labelNameItem.Size = new System.Drawing.Size(266, 16);
            this.labelNameItem.TabIndex = 4;
            this.labelNameItem.Text = "Введите наименование  товара для поиска";
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSort.Location = new System.Drawing.Point(334, 39);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(94, 16);
            this.labelSort.TabIndex = 3;
            this.labelSort.Text = "Сортировка по";
            // 
            // textBoxNameItem
            // 
            this.textBoxNameItem.Location = new System.Drawing.Point(284, 9);
            this.textBoxNameItem.Name = "textBoxNameItem";
            this.textBoxNameItem.Size = new System.Drawing.Size(271, 20);
            this.textBoxNameItem.TabIndex = 2;
            this.textBoxNameItem.TextChanged += new System.EventHandler(this.textBoxNameItem_TextChanged);
            // 
            // comboSort
            // 
            this.comboSort.FormattingEnabled = true;
            this.comboSort.Items.AddRange(new object[] {
            "по возрастанию цены",
            "по убыванию цены",
            "по возрастанию названия",
            "по убыванию названия"});
            this.comboSort.Location = new System.Drawing.Point(434, 38);
            this.comboSort.Name = "comboSort";
            this.comboSort.Size = new System.Drawing.Size(121, 21);
            this.comboSort.TabIndex = 1;
            this.comboSort.SelectedIndexChanged += new System.EventHandler(this.comboSort_SelectedIndexChanged);
            // 
            // comboDirectory
            // 
            this.comboDirectory.FormattingEnabled = true;
            this.comboDirectory.Location = new System.Drawing.Point(144, 38);
            this.comboDirectory.Name = "comboDirectory";
            this.comboDirectory.Size = new System.Drawing.Size(121, 21);
            this.comboDirectory.TabIndex = 0;
            this.comboDirectory.SelectedIndexChanged += new System.EventHandler(this.comboDirectory_SelectedIndexChanged);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCountItem;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelNameItem;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.TextBox textBoxNameItem;
        private System.Windows.Forms.ComboBox comboSort;
        private System.Windows.Forms.ComboBox comboDirectory;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}