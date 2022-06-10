namespace KhorunzhyyKP
{
    partial class MainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.PictureBox();
            this.CreateGraphs = new System.Windows.Forms.Button();
            this.FI1 = new System.Windows.Forms.RichTextBox();
            this.FI2 = new System.Windows.Forms.RichTextBox();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ExportFI = new System.Windows.Forms.Button();
            this.ImportFI = new System.Windows.Forms.Button();
            this.CompareGraphs = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 320);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Перший граф";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 301);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(328, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 320);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Другий граф";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 301);
            this.panel2.TabIndex = 0;
            this.panel2.TabStop = false;
            // 
            // CreateGraphs
            // 
            this.CreateGraphs.Location = new System.Drawing.Point(192, 447);
            this.CreateGraphs.Name = "CreateGraphs";
            this.CreateGraphs.Size = new System.Drawing.Size(124, 23);
            this.CreateGraphs.TabIndex = 4;
            this.CreateGraphs.Text = "Створити граф(и)";
            this.CreateGraphs.UseVisualStyleBackColor = true;
            this.CreateGraphs.Click += new System.EventHandler(this.CreateGraphs_Click);
            // 
            // FI1
            // 
            this.FI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FI1.Location = new System.Drawing.Point(3, 16);
            this.FI1.Name = "FI1";
            this.FI1.Size = new System.Drawing.Size(308, 90);
            this.FI1.TabIndex = 5;
            this.FI1.Text = "2 0 1 3 0 2 4 0 3 5 0 4 6 0 5 7 0 6 0";
            this.FI1.MouseEnter += new System.EventHandler(this.FI_MouseEnter);
            this.FI1.MouseLeave += new System.EventHandler(this.FI_MouseLeave);
            // 
            // FI2
            // 
            this.FI2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FI2.Location = new System.Drawing.Point(3, 16);
            this.FI2.Name = "FI2";
            this.FI2.Size = new System.Drawing.Size(314, 90);
            this.FI2.TabIndex = 6;
            this.FI2.Text = "2 7 0 1 3 0 2 4 0 3 5 0 4 6 0 5 7 0 1 6 0";
            this.FI2.MouseEnter += new System.EventHandler(this.FI_MouseEnter);
            this.FI2.MouseLeave += new System.EventHandler(this.FI_MouseLeave);
            // 
            // Result
            // 
            this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result.Location = new System.Drawing.Point(3, 16);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(637, 121);
            this.Result.TabIndex = 7;
            this.Result.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FI2);
            this.groupBox3.Location = new System.Drawing.Point(328, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 109);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "FI-представлення графу";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Result);
            this.groupBox4.Location = new System.Drawing.Point(5, 479);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(643, 140);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Результат порвняння";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FI1);
            this.groupBox5.Location = new System.Drawing.Point(5, 335);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 109);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "FI-представлення графу";
            // 
            // ExportFI
            // 
            this.ExportFI.Location = new System.Drawing.Point(521, 447);
            this.ExportFI.Name = "ExportFI";
            this.ExportFI.Size = new System.Drawing.Size(124, 23);
            this.ExportFI.TabIndex = 11;
            this.ExportFI.Text = "Експорт";
            this.ExportFI.UseVisualStyleBackColor = true;
            this.ExportFI.Click += new System.EventHandler(this.Export_Click);
            // 
            // ImportFI
            // 
            this.ImportFI.Location = new System.Drawing.Point(8, 447);
            this.ImportFI.Name = "ImportFI";
            this.ImportFI.Size = new System.Drawing.Size(124, 23);
            this.ImportFI.TabIndex = 12;
            this.ImportFI.Text = "Імпорт";
            this.ImportFI.UseVisualStyleBackColor = true;
            this.ImportFI.Click += new System.EventHandler(this.Import_Click);
            // 
            // CompareGraphs
            // 
            this.CompareGraphs.Location = new System.Drawing.Point(331, 447);
            this.CompareGraphs.Name = "CompareGraphs";
            this.CompareGraphs.Size = new System.Drawing.Size(124, 23);
            this.CompareGraphs.TabIndex = 8;
            this.CompareGraphs.Text = "Порівняти граф(и)";
            this.CompareGraphs.UseVisualStyleBackColor = true;
            this.CompareGraphs.Click += new System.EventHandler(this.CompareGraphs_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 626);
            this.Controls.Add(this.CompareGraphs);
            this.Controls.Add(this.ExportFI);
            this.Controls.Add(this.ImportFI);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CreateGraphs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(671, 665);
            this.MinimumSize = new System.Drawing.Size(671, 665);
            this.Name = "MainWindow";
            this.Text = "Хорунжий - двозв\'язаність графів";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CreateGraphs;
        private System.Windows.Forms.RichTextBox FI1;
        private System.Windows.Forms.RichTextBox FI2;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button ExportFI;
        private System.Windows.Forms.Button ImportFI;
        private System.Windows.Forms.Button CompareGraphs;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox panel1;
        private System.Windows.Forms.PictureBox panel2;
    }
}

