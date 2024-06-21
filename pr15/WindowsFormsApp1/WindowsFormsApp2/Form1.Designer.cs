namespace WindowsFormsApp2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисункиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунок1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунок2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунок3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисункиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.сохранитьToolStripMenuItem.Text = "Открыть";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // рисункиToolStripMenuItem
            // 
            this.рисункиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рисунок1ToolStripMenuItem,
            this.рисунок2ToolStripMenuItem,
            this.рисунок3ToolStripMenuItem});
            this.рисункиToolStripMenuItem.Name = "рисункиToolStripMenuItem";
            this.рисункиToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.рисункиToolStripMenuItem.Text = "Рисунки";
            // 
            // рисунок1ToolStripMenuItem
            // 
            this.рисунок1ToolStripMenuItem.Name = "рисунок1ToolStripMenuItem";
            this.рисунок1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рисунок1ToolStripMenuItem.Text = "Ris1";
            this.рисунок1ToolStripMenuItem.Click += new System.EventHandler(this.рисунок1ToolStripMenuItem_Click);
            // 
            // рисунок2ToolStripMenuItem
            // 
            this.рисунок2ToolStripMenuItem.Name = "рисунок2ToolStripMenuItem";
            this.рисунок2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рисунок2ToolStripMenuItem.Text = "Ris2";
            this.рисунок2ToolStripMenuItem.Click += new System.EventHandler(this.рисунок2ToolStripMenuItem_Click);
            // 
            // рисунок3ToolStripMenuItem
            // 
            this.рисунок3ToolStripMenuItem.Name = "рисунок3ToolStripMenuItem";
            this.рисунок3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.рисунок3ToolStripMenuItem.Text = "Ris3";
            this.рисунок3ToolStripMenuItem.Click += new System.EventHandler(this.рисунок3ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисункиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунок1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунок2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунок3ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

