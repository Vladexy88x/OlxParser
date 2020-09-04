namespace OlxParser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressIndicator = new System.Windows.Forms.Label();
            this.getUrlParse = new System.Windows.Forms.Button();
            this.GlobalSectionList = new System.Windows.Forms.ListBox();
            this.DefaultSectionList = new System.Windows.Forms.ListBox();
            this.ProductSectionList = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IndividualProductSectionList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.RestartAndClear = new System.Windows.Forms.CheckBox();
            this.backGroundColorCheck = new System.Windows.Forms.CheckBox();
            this.colorDialogGridBackground = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 180);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 108);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(883, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 296);
            this.progressBar1.Maximum = 150;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(272, 17);
            this.progressBar1.TabIndex = 4;
            // 
            // progressIndicator
            // 
            this.progressIndicator.AutoSize = true;
            this.progressIndicator.Location = new System.Drawing.Point(119, 316);
            this.progressIndicator.Name = "progressIndicator";
            this.progressIndicator.Size = new System.Drawing.Size(57, 13);
            this.progressIndicator.TabIndex = 5;
            this.progressIndicator.Text = "Progress : ";
            // 
            // getUrlParse
            // 
            this.getUrlParse.Location = new System.Drawing.Point(883, 525);
            this.getUrlParse.Name = "getUrlParse";
            this.getUrlParse.Size = new System.Drawing.Size(75, 23);
            this.getUrlParse.TabIndex = 6;
            this.getUrlParse.Text = "TestStart";
            this.getUrlParse.UseVisualStyleBackColor = true;
            this.getUrlParse.Click += new System.EventHandler(this.getUrlParse_Click);
            // 
            // GlobalSectionList
            // 
            this.GlobalSectionList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GlobalSectionList.FormattingEnabled = true;
            this.GlobalSectionList.Location = new System.Drawing.Point(14, 27);
            this.GlobalSectionList.Name = "GlobalSectionList";
            this.GlobalSectionList.Size = new System.Drawing.Size(258, 147);
            this.GlobalSectionList.TabIndex = 8;
            // 
            // DefaultSectionList
            // 
            this.DefaultSectionList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefaultSectionList.FormattingEnabled = true;
            this.DefaultSectionList.Location = new System.Drawing.Point(278, 29);
            this.DefaultSectionList.Name = "DefaultSectionList";
            this.DefaultSectionList.Size = new System.Drawing.Size(203, 147);
            this.DefaultSectionList.TabIndex = 9;
            this.DefaultSectionList.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // ProductSectionList
            // 
            this.ProductSectionList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductSectionList.FormattingEnabled = true;
            this.ProductSectionList.Location = new System.Drawing.Point(487, 27);
            this.ProductSectionList.Name = "ProductSectionList";
            this.ProductSectionList.Size = new System.Drawing.Size(236, 147);
            this.ProductSectionList.TabIndex = 10;
            this.ProductSectionList.SelectedIndexChanged += new System.EventHandler(this.ProductSectionList_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(867, 457);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 347);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(830, 233);
            this.dataGridView1.TabIndex = 13;
            // 
            // IndividualProductSectionList
            // 
            this.IndividualProductSectionList.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IndividualProductSectionList.FormattingEnabled = true;
            this.IndividualProductSectionList.Location = new System.Drawing.Point(729, 27);
            this.IndividualProductSectionList.Name = "IndividualProductSectionList";
            this.IndividualProductSectionList.Size = new System.Drawing.Size(258, 147);
            this.IndividualProductSectionList.TabIndex = 14;
            this.IndividualProductSectionList.SelectedIndexChanged += new System.EventHandler(this.IndividualProductSectionList_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(867, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save and write to file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // RestartAndClear
            // 
            this.RestartAndClear.AutoSize = true;
            this.RestartAndClear.Location = new System.Drawing.Point(867, 395);
            this.RestartAndClear.Name = "RestartAndClear";
            this.RestartAndClear.Size = new System.Drawing.Size(130, 17);
            this.RestartAndClear.TabIndex = 16;
            this.RestartAndClear.Text = "Clear data before start";
            this.RestartAndClear.UseVisualStyleBackColor = true;
            // 
            // backGroundColorCheck
            // 
            this.backGroundColorCheck.AutoSize = true;
            this.backGroundColorCheck.Location = new System.Drawing.Point(867, 372);
            this.backGroundColorCheck.Name = "backGroundColorCheck";
            this.backGroundColorCheck.Size = new System.Drawing.Size(136, 17);
            this.backGroundColorCheck.TabIndex = 17;
            this.backGroundColorCheck.Text = "Grid Background Color ";
            this.backGroundColorCheck.UseVisualStyleBackColor = true;
            this.backGroundColorCheck.CheckedChanged += new System.EventHandler(this.BackGroundColorCheck_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 592);
            this.Controls.Add(this.backGroundColorCheck);
            this.Controls.Add(this.RestartAndClear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.IndividualProductSectionList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ProductSectionList);
            this.Controls.Add(this.DefaultSectionList);
            this.Controls.Add(this.GlobalSectionList);
            this.Controls.Add(this.getUrlParse);
            this.Controls.Add(this.progressIndicator);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "Olx parser";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressIndicator;
        private System.Windows.Forms.Button getUrlParse;
        private System.Windows.Forms.ListBox GlobalSectionList;
        private System.Windows.Forms.ListBox DefaultSectionList;
        private System.Windows.Forms.ListBox ProductSectionList;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox IndividualProductSectionList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox RestartAndClear;
        private System.Windows.Forms.CheckBox backGroundColorCheck;
        private System.Windows.Forms.ColorDialog colorDialogGridBackground;
    }
}

