namespace Tyuiu.KropchevSR.Sprint6.Task2.V4
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslovie_SKR = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_SKR = new System.Windows.Forms.GroupBox();
            this.groupBoxValues_SKR = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_SKR = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_SKR = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_SKR = new System.Windows.Forms.TextBox();
            this.labelStartValue_SKR = new System.Windows.Forms.Label();
            this.labelStopValue_SKR = new System.Windows.Forms.Label();
            this.buttonHelp_SKR = new System.Windows.Forms.Button();
            this.buttonDone_SKR = new System.Windows.Forms.Button();
            this.dataGridViewResult_SKR = new System.Windows.Forms.DataGridView();
            this.chartResult_SKR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ColumnX_SKR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFX_SKR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxUslovie_SKR.SuspendLayout();
            this.groupBoxResult_SKR.SuspendLayout();
            this.groupBoxValues_SKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SKR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SKR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_SKR
            // 
            this.groupBoxUslovie_SKR.Controls.Add(this.textBoxUslovie_SKR);
            this.groupBoxUslovie_SKR.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUslovie_SKR.Name = "groupBoxUslovie_SKR";
            this.groupBoxUslovie_SKR.Size = new System.Drawing.Size(411, 236);
            this.groupBoxUslovie_SKR.TabIndex = 0;
            this.groupBoxUslovie_SKR.TabStop = false;
            this.groupBoxUslovie_SKR.Text = "Условие";
            // 
            // groupBoxResult_SKR
            // 
            this.groupBoxResult_SKR.Controls.Add(this.chartResult_SKR);
            this.groupBoxResult_SKR.Controls.Add(this.dataGridViewResult_SKR);
            this.groupBoxResult_SKR.Location = new System.Drawing.Point(431, 13);
            this.groupBoxResult_SKR.Name = "groupBoxResult_SKR";
            this.groupBoxResult_SKR.Size = new System.Drawing.Size(504, 316);
            this.groupBoxResult_SKR.TabIndex = 1;
            this.groupBoxResult_SKR.TabStop = false;
            this.groupBoxResult_SKR.Text = "Вывод данных";
            // 
            // groupBoxValues_SKR
            // 
            this.groupBoxValues_SKR.Controls.Add(this.labelStopValue_SKR);
            this.groupBoxValues_SKR.Controls.Add(this.labelStartValue_SKR);
            this.groupBoxValues_SKR.Controls.Add(this.textBoxStopValue_SKR);
            this.groupBoxValues_SKR.Controls.Add(this.textBoxStartValue_SKR);
            this.groupBoxValues_SKR.Location = new System.Drawing.Point(13, 255);
            this.groupBoxValues_SKR.Name = "groupBoxValues_SKR";
            this.groupBoxValues_SKR.Size = new System.Drawing.Size(223, 74);
            this.groupBoxValues_SKR.TabIndex = 2;
            this.groupBoxValues_SKR.TabStop = false;
            this.groupBoxValues_SKR.Text = "Ввод данных";
            // 
            // textBoxUslovie_SKR
            // 
            this.textBoxUslovie_SKR.Location = new System.Drawing.Point(7, 19);
            this.textBoxUslovie_SKR.Multiline = true;
            this.textBoxUslovie_SKR.Name = "textBoxUslovie_SKR";
            this.textBoxUslovie_SKR.ReadOnly = true;
            this.textBoxUslovie_SKR.Size = new System.Drawing.Size(398, 210);
            this.textBoxUslovie_SKR.TabIndex = 0;
            this.textBoxUslovie_SKR.Text = "(5x+2.5)/(sin(x)+2)+2x + 2 на диапазоне.\r\nРезультат выв" +
    "ести в DataGridView и построить график функции.";
            // 
            // textBoxStartValue_SKR
            // 
            this.textBoxStartValue_SKR.Location = new System.Drawing.Point(6, 48);
            this.textBoxStartValue_SKR.Name = "textBoxStartValue_SKR";
            this.textBoxStartValue_SKR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartValue_SKR.TabIndex = 0;
            // 
            // textBoxStopValue_SKR
            // 
            this.textBoxStopValue_SKR.Location = new System.Drawing.Point(117, 48);
            this.textBoxStopValue_SKR.Name = "textBoxStopValue_SKR";
            this.textBoxStopValue_SKR.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopValue_SKR.TabIndex = 1;
            // 
            // labelStartValue_SKR
            // 
            this.labelStartValue_SKR.AutoSize = true;
            this.labelStartValue_SKR.Location = new System.Drawing.Point(6, 32);
            this.labelStartValue_SKR.Name = "labelStartValue_SKR";
            this.labelStartValue_SKR.Size = new System.Drawing.Size(67, 13);
            this.labelStartValue_SKR.TabIndex = 2;
            this.labelStartValue_SKR.Text = "Старт шага:";
            // 
            // labelStopValue_SKR
            // 
            this.labelStopValue_SKR.AutoSize = true;
            this.labelStopValue_SKR.Location = new System.Drawing.Point(114, 32);
            this.labelStopValue_SKR.Name = "labelStopValue_SKR";
            this.labelStopValue_SKR.Size = new System.Drawing.Size(69, 13);
            this.labelStopValue_SKR.TabIndex = 3;
            this.labelStopValue_SKR.Text = "Конец шага:";
            // 
            // buttonHelp_SKR
            // 
            this.buttonHelp_SKR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SKR.Location = new System.Drawing.Point(243, 256);
            this.buttonHelp_SKR.Name = "buttonHelp_SKR";
            this.buttonHelp_SKR.Size = new System.Drawing.Size(75, 73);
            this.buttonHelp_SKR.TabIndex = 3;
            this.buttonHelp_SKR.Text = "Справка";
            this.buttonHelp_SKR.UseVisualStyleBackColor = false;
            this.buttonHelp_SKR.Click += new System.EventHandler(this.buttonHelp_SKR_Click);
            // 
            // buttonDone_SKR
            // 
            this.buttonDone_SKR.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonDone_SKR.Location = new System.Drawing.Point(325, 256);
            this.buttonDone_SKR.Name = "buttonDone_SKR";
            this.buttonDone_SKR.Size = new System.Drawing.Size(99, 73);
            this.buttonDone_SKR.TabIndex = 4;
            this.buttonDone_SKR.Text = "Выполнить";
            this.buttonDone_SKR.UseVisualStyleBackColor = false;
            this.buttonDone_SKR.Click += new System.EventHandler(this.buttonDone_SKR_Click);
            this.buttonDone_SKR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SKR_MouseDown);
            this.buttonDone_SKR.MouseEnter += new System.EventHandler(this.buttonDone_SKR_MouseEnter);
            this.buttonDone_SKR.MouseLeave += new System.EventHandler(this.buttonDone_SKR_MouseLeave);
            // 
            // dataGridViewResult_SKR
            // 
            this.dataGridViewResult_SKR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SKR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_SKR,
            this.ColumnFX_SKR});
            this.dataGridViewResult_SKR.Location = new System.Drawing.Point(8, 19);
            this.dataGridViewResult_SKR.Name = "dataGridViewResult_SKR";
            this.dataGridViewResult_SKR.RowHeadersVisible = false;
            this.dataGridViewResult_SKR.Size = new System.Drawing.Size(121, 291);
            this.dataGridViewResult_SKR.TabIndex = 0;
            // 
            // chartResult_SKR
            // 
            chartArea7.Name = "ChartArea1";
            this.chartResult_SKR.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartResult_SKR.Legends.Add(legend7);
            this.chartResult_SKR.Location = new System.Drawing.Point(135, 20);
            this.chartResult_SKR.Name = "chartResult_SKR";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartResult_SKR.Series.Add(series7);
            this.chartResult_SKR.Size = new System.Drawing.Size(363, 290);
            this.chartResult_SKR.TabIndex = 1;
            this.chartResult_SKR.Text = "chart1";
            // 
            // ColumnX_SKR
            // 
            this.ColumnX_SKR.HeaderText = "X";
            this.ColumnX_SKR.Name = "ColumnX_SKR";
            this.ColumnX_SKR.Width = 50;
            // 
            // ColumnFX_SKR
            // 
            this.ColumnFX_SKR.HeaderText = "F(X)";
            this.ColumnFX_SKR.Name = "ColumnFX_SKR";
            this.ColumnFX_SKR.ReadOnly = true;
            this.ColumnFX_SKR.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 341);
            this.Controls.Add(this.buttonDone_SKR);
            this.Controls.Add(this.buttonHelp_SKR);
            this.Controls.Add(this.groupBoxValues_SKR);
            this.Controls.Add(this.groupBoxResult_SKR);
            this.Controls.Add(this.groupBoxUslovie_SKR);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 4 | Кропчев Степан Романович";
            this.groupBoxUslovie_SKR.ResumeLayout(false);
            this.groupBoxUslovie_SKR.PerformLayout();
            this.groupBoxResult_SKR.ResumeLayout(false);
            this.groupBoxValues_SKR.ResumeLayout(false);
            this.groupBoxValues_SKR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SKR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SKR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_SKR;
        private System.Windows.Forms.TextBox textBoxUslovie_SKR;
        private System.Windows.Forms.GroupBox groupBoxResult_SKR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SKR;
        private System.Windows.Forms.DataGridView dataGridViewResult_SKR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_SKR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFX_SKR;
        private System.Windows.Forms.GroupBox groupBoxValues_SKR;
        private System.Windows.Forms.Label labelStopValue_SKR;
        private System.Windows.Forms.Label labelStartValue_SKR;
        private System.Windows.Forms.TextBox textBoxStopValue_SKR;
        private System.Windows.Forms.TextBox textBoxStartValue_SKR;
        private System.Windows.Forms.Button buttonHelp_SKR;
        private System.Windows.Forms.Button buttonDone_SKR;
    }
}

