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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbRaw = new System.Windows.Forms.CheckBox();
            this.cbSmooth = new System.Windows.Forms.CheckBox();
            this.cbCubic = new System.Windows.Forms.CheckBox();
            this.cbQuartic = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(351, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1165, 639);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(333, 291);
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
            this.cbRaw.Location = new System.Drawing.Point(12, 309);
            this.cbRaw.Name = "cbRaw";
            this.cbRaw.Size = new System.Drawing.Size(134, 20);
            this.cbRaw.TabIndex = 2;
            this.cbRaw.Text = "Исходные точки";
            this.cbRaw.UseVisualStyleBackColor = true;
            this.cbRaw.CheckedChanged += new System.EventHandler(this.cbRaw_CheckedChanged);
            // 
            // cbSmooth
            // 
            this.cbSmooth.AutoSize = true;
            this.cbSmooth.Checked = true;
            this.cbSmooth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSmooth.Location = new System.Drawing.Point(12, 335);
            this.cbSmooth.Name = "cbSmooth";
            this.cbSmooth.Size = new System.Drawing.Size(166, 20);
            this.cbSmooth.TabIndex = 3;
            this.cbSmooth.Text = "Скользящее среднее";
            this.cbSmooth.UseVisualStyleBackColor = true;
            this.cbSmooth.CheckedChanged += new System.EventHandler(this.cbSmooth_CheckedChanged);
            // 
            // cbCubic
            // 
            this.cbCubic.AutoSize = true;
            this.cbCubic.Checked = true;
            this.cbCubic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCubic.Location = new System.Drawing.Point(12, 361);
            this.cbCubic.Name = "cbCubic";
            this.cbCubic.Size = new System.Drawing.Size(196, 20);
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
            this.cbQuartic.Location = new System.Drawing.Point(12, 387);
            this.cbQuartic.Name = "cbQuartic";
            this.cbQuartic.Size = new System.Drawing.Size(261, 20);
            this.cbQuartic.TabIndex = 5;
            this.cbQuartic.Text = "Глобальный многочлен 4-й степени";
            this.cbQuartic.UseVisualStyleBackColor = true;
            this.cbQuartic.CheckedChanged += new System.EventHandler(this.cbQuartic_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1686, 677);
            this.Controls.Add(this.cbQuartic);
            this.Controls.Add(this.cbCubic);
            this.Controls.Add(this.cbSmooth);
            this.Controls.Add(this.cbRaw);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
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
        private System.Windows.Forms.CheckBox cbSmooth;
        private System.Windows.Forms.CheckBox cbCubic;
        private System.Windows.Forms.CheckBox cbQuartic;
    }
}

