namespace BIA_Task_10
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.salesStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.loginStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BIA_Task_10.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Yellow;
            this.labelName.Location = new System.Drawing.Point(148, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(451, 41);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Аукцион Драгоценностей";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemStrip,
            this.salesStrip,
            this.contactsStrip,
            this.logoutStrip,
            this.loginStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemStrip
            // 
            this.itemStrip.Name = "itemStrip";
            this.itemStrip.Size = new System.Drawing.Size(76, 20);
            this.itemStrip.Text = "Предметы";
            this.itemStrip.Click += new System.EventHandler(this.itemStrip_Click);
            // 
            // salesStrip
            // 
            this.salesStrip.Enabled = false;
            this.salesStrip.Name = "salesStrip";
            this.salesStrip.Size = new System.Drawing.Size(70, 20);
            this.salesStrip.Text = "Продажи";
            this.salesStrip.Visible = false;
            this.salesStrip.Click += new System.EventHandler(this.salesStrip_Click);
            // 
            // contactsStrip
            // 
            this.contactsStrip.Name = "contactsStrip";
            this.contactsStrip.Size = new System.Drawing.Size(71, 20);
            this.contactsStrip.Text = "Контакты";
            this.contactsStrip.Click += new System.EventHandler(this.contactsStrip_Click);
            // 
            // logoutStrip
            // 
            this.logoutStrip.Enabled = false;
            this.logoutStrip.Name = "logoutStrip";
            this.logoutStrip.Size = new System.Drawing.Size(53, 20);
            this.logoutStrip.Text = "Выход";
            this.logoutStrip.Visible = false;
            this.logoutStrip.Click += new System.EventHandler(this.logoutStrip_Click);
            // 
            // loginStrip
            // 
            this.loginStrip.Name = "loginStrip";
            this.loginStrip.Size = new System.Drawing.Size(52, 20);
            this.loginStrip.Text = "Войти";
            this.loginStrip.Click += new System.EventHandler(this.loginStrip_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(96, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Система для ведения базы данных об аукционе.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(282, 385);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аукцион драгоценностей";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemStrip;
        private System.Windows.Forms.ToolStripMenuItem salesStrip;
        private System.Windows.Forms.ToolStripMenuItem contactsStrip;
        private System.Windows.Forms.ToolStripMenuItem logoutStrip;
        private System.Windows.Forms.ToolStripMenuItem loginStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClose;
    }
}

