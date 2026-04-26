namespace lb5_Vich.Mat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbRaw = new System.Windows.Forms.CheckBox();
            this.cbCubic = new System.Windows.Forms.CheckBox();
            this.cbQuartic = new System.Windows.Forms.CheckBox();
            this.cbSmooth7 = new System.Windows.Forms.CheckBox();
            this.cbSmooth11 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(317, 10);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(990, 519);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colX,
            this.colY});
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(304, 412);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colX
            // 
            this.colX.HeaderText = "X";
            this.colX.MinimumWidth = 6;
            this.colX.Name = "colX";
            this.colX.Width = 125;
            // 
            // colY
            // 
            this.colY.HeaderText = "Y";
            this.colY.MinimumWidth = 6;
            this.colY.Name = "colY";
            this.colY.Width = 125;
            // 
            // cbRaw
            // 
            this.cbRaw.AutoSize = true;
            this.cbRaw.Checked = true;
            this.cbRaw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRaw.Location = new System.Drawing.Point(10, 426);
            this.cbRaw.Margin = new System.Windows.Forms.Padding(2);
            this.cbRaw.Name = "cbRaw";
            this.cbRaw.Size = new System.Drawing.Size(108, 17);
            this.cbRaw.TabIndex = 2;
            this.cbRaw.Text = "Исходные точки";
            this.cbRaw.UseVisualStyleBackColor = true;
            this.cbRaw.CheckedChanged += new System.EventHandler(this.cbRaw_CheckedChanged);
            // 
            // cbCubic
            // 
            this.cbCubic.AutoSize = true;
            this.cbCubic.Checked = true;
            this.cbCubic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCubic.Location = new System.Drawing.Point(10, 491);
            this.cbCubic.Margin = new System.Windows.Forms.Padding(2);
            this.cbCubic.Name = "cbCubic";
            this.cbCubic.Size = new System.Drawing.Size(155, 17);
            this.cbCubic.TabIndex = 4;
            this.cbCubic.Text = "Кубическое сглаживание";
            this.cbCubic.UseVisualStyleBackColor = true;
            this.cbCubic.CheckedChanged += new System.EventHandler(this.cbCubic_CheckedChanged);
            // 
            // cbQuartic
            // 
            this.cbQuartic.AutoSize = true;
            this.cbQuartic.Checked = true;
            this.cbQuartic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbQuartic.Location = new System.Drawing.Point(10, 512);
            this.cbQuartic.Margin = new System.Windows.Forms.Padding(2);
            this.cbQuartic.Name = "cbQuartic";
            this.cbQuartic.Size = new System.Drawing.Size(207, 17);
            this.cbQuartic.TabIndex = 5;
            this.cbQuartic.Text = "Глобальный многочлен 4-й степени";
            this.cbQuartic.UseVisualStyleBackColor = true;
            this.cbQuartic.CheckedChanged += new System.EventHandler(this.cbQuartic_CheckedChanged);
            // 
            // cbSmooth7
            // 
            this.cbSmooth7.AutoSize = true;
            this.cbSmooth7.Checked = true;
            this.cbSmooth7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSmooth7.Location = new System.Drawing.Point(10, 446);
            this.cbSmooth7.Name = "cbSmooth7";
            this.cbSmooth7.Size = new System.Drawing.Size(150, 17);
            this.cbSmooth7.TabIndex = 6;
            this.cbSmooth7.Text = "Скользящее среднее (7)";
            this.cbSmooth7.UseVisualStyleBackColor = true;
            this.cbSmooth7.CheckedChanged += new System.EventHandler(this.cbSmooth7_CheckedChanged);
            // 
            // cbSmooth11
            // 
            this.cbSmooth11.AutoSize = true;
            this.cbSmooth11.Checked = true;
            this.cbSmooth11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSmooth11.Location = new System.Drawing.Point(9, 469);
            this.cbSmooth11.Name = "cbSmooth11";
            this.cbSmooth11.Size = new System.Drawing.Size(156, 17);
            this.cbSmooth11.TabIndex = 7;
            this.cbSmooth11.Text = "Скользящее среднее (11)";
            this.cbSmooth11.UseVisualStyleBackColor = true;
            this.cbSmooth11.CheckedChanged += new System.EventHandler(this.cbSmooth11_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 752);
            this.Controls.Add(this.cbSmooth11);
            this.Controls.Add(this.cbSmooth7);
            this.Controls.Add(this.cbQuartic);
            this.Controls.Add(this.cbCubic);
            this.Controls.Add(this.cbRaw);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colY;
        private System.Windows.Forms.CheckBox cbRaw;
        private System.Windows.Forms.CheckBox cbCubic;
        private System.Windows.Forms.CheckBox cbQuartic;
        private System.Windows.Forms.CheckBox cbSmooth7;
        private System.Windows.Forms.CheckBox cbSmooth11;
    }
}

