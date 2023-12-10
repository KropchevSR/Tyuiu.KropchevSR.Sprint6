namespace Tyuiu.KropchevSR.Sprint6.Task4.V24
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxUslovie_SKR = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxUslovie_SKR = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_SKR = new System.Windows.Forms.GroupBox();
            this.buttonHelp_SKR = new System.Windows.Forms.Button();
            this.buttonSave_SKR = new System.Windows.Forms.Button();
            this.buttonDone_SKR = new System.Windows.Forms.Button();
            this.labelY_SKR = new System.Windows.Forms.Label();
            this.textBoxY_SKR = new System.Windows.Forms.TextBox();
            this.labelX_SKR = new System.Windows.Forms.Label();
            this.textBoxX_SKR = new System.Windows.Forms.TextBox();
            this.textBoxOutput_SKR = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_SKR = new System.Windows.Forms.GroupBox();
            this.chartResult_SKR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.groupBoxUslovie_SKR.SuspendLayout();
            this.groupBoxInput_SKR.SuspendLayout();
            this.groupBoxOutput_SKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SKR)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUslovie_SKR
            // 
            this.textBoxUslovie_SKR.Location = new System.Drawing.Point(9, 14);
            this.textBoxUslovie_SKR.Multiline = true;
            this.textBoxUslovie_SKR.Name = "textBoxUslovie_SKR";
            this.textBoxUslovie_SKR.ReadOnly = true;
            this.textBoxUslovie_SKR.Size = new System.Drawing.Size(273, 41);
            this.textBoxUslovie_SKR.TabIndex = 0;
            this.textBoxUslovie_SKR.Text = "Произвести табулирование F(x) = SIN(x)/(x+1,2) - SIN(x)*2 - 2*x на диапазоне [x,y] с шагом 1.";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxUslovie_SKR
            // 
            this.groupBoxUslovie_SKR.Controls.Add(this.textBoxUslovie_SKR);
            this.groupBoxUslovie_SKR.Location = new System.Drawing.Point(3, 3);
            this.groupBoxUslovie_SKR.Name = "groupBoxUslovie_SKR";
            this.groupBoxUslovie_SKR.Size = new System.Drawing.Size(290, 61);
            this.groupBoxUslovie_SKR.TabIndex = 2;
            this.groupBoxUslovie_SKR.TabStop = false;
            this.groupBoxUslovie_SKR.Text = "Условие";
            // 
            // groupBoxInput_SKR
            // 
            this.groupBoxInput_SKR.Controls.Add(this.buttonHelp_SKR);
            this.groupBoxInput_SKR.Controls.Add(this.buttonSave_SKR);
            this.groupBoxInput_SKR.Controls.Add(this.buttonDone_SKR);
            this.groupBoxInput_SKR.Controls.Add(this.labelY_SKR);
            this.groupBoxInput_SKR.Controls.Add(this.textBoxY_SKR);
            this.groupBoxInput_SKR.Controls.Add(this.labelX_SKR);
            this.groupBoxInput_SKR.Controls.Add(this.textBoxX_SKR);
            this.groupBoxInput_SKR.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxInput_SKR.Location = new System.Drawing.Point(350, 0);
            this.groupBoxInput_SKR.Name = "groupBoxInput_SKR";
            this.groupBoxInput_SKR.Size = new System.Drawing.Size(485, 471);
            this.groupBoxInput_SKR.TabIndex = 3;
            this.groupBoxInput_SKR.TabStop = false;
            this.groupBoxInput_SKR.Text = "Ввод данных";
            // 
            // buttonHelp_SKR
            // 
            this.buttonHelp_SKR.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_SKR.Location = new System.Drawing.Point(342, 3);
            this.buttonHelp_SKR.Name = "buttonHelp_SKR";
            this.buttonHelp_SKR.Size = new System.Drawing.Size(100, 58);
            this.buttonHelp_SKR.TabIndex = 9;
            this.buttonHelp_SKR.Text = "Справка";
            this.buttonHelp_SKR.UseVisualStyleBackColor = false;
            this.buttonHelp_SKR.Click += new System.EventHandler(this.buttonHelpClick);
            // 
            // buttonSave_SKR
            // 
            this.buttonSave_SKR.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSave_SKR.Location = new System.Drawing.Point(245, 3);
            this.buttonSave_SKR.Name = "buttonSave_SKR";
            this.buttonSave_SKR.Size = new System.Drawing.Size(100, 58);
            this.buttonSave_SKR.TabIndex = 8;
            this.buttonSave_SKR.Text = "Сохранить";
            this.buttonSave_SKR.UseVisualStyleBackColor = false;
            this.buttonSave_SKR.Click += new System.EventHandler(this.buttonSaveClick_SKR);
            // 
            // buttonDone_SKR
            // 
            this.buttonDone_SKR.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonDone_SKR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.buttonDone_SKR.Location = new System.Drawing.Point(148, 3);
            this.buttonDone_SKR.Name = "buttonDone_SKR";
            this.buttonDone_SKR.Size = new System.Drawing.Size(100, 58);
            this.buttonDone_SKR.TabIndex = 7;
            this.buttonDone_SKR.Text = "Выполнить";
            this.buttonDone_SKR.UseVisualStyleBackColor = false;
            this.buttonDone_SKR.Click += new System.EventHandler(this.buttonDone_SKR_Click);
            // 
            // labelY_SKR
            // 
            this.labelY_SKR.AutoSize = true;
            this.labelY_SKR.Location = new System.Drawing.Point(77, 14);
            this.labelY_SKR.Name = "labelY_SKR";
            this.labelY_SKR.Size = new System.Drawing.Size(65, 13);
            this.labelY_SKR.TabIndex = 6;
            this.labelY_SKR.Text = "Значение Y";
            // 
            // textBoxY_SKR
            // 
            this.textBoxY_SKR.Location = new System.Drawing.Point(77, 30);
            this.textBoxY_SKR.Name = "textBoxY_SKR";
            this.textBoxY_SKR.Size = new System.Drawing.Size(65, 20);
            this.textBoxY_SKR.TabIndex = 5;
            // 
            // labelX_SKR
            // 
            this.labelX_SKR.AutoSize = true;
            this.labelX_SKR.Location = new System.Drawing.Point(6, 14);
            this.labelX_SKR.Name = "labelX_SKR";
            this.labelX_SKR.Size = new System.Drawing.Size(65, 13);
            this.labelX_SKR.TabIndex = 4;
            this.labelX_SKR.Text = "Значение X";
            this.labelX_SKR.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxX_SKR
            // 
            this.textBoxX_SKR.Location = new System.Drawing.Point(6, 30);
            this.textBoxX_SKR.Name = "textBoxX_SKR";
            this.textBoxX_SKR.Size = new System.Drawing.Size(65, 20);
            this.textBoxX_SKR.TabIndex = 0;
            // 
            // textBoxOutput_SKR
            // 
            this.textBoxOutput_SKR.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxOutput_SKR.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutput_SKR.Multiline = true;
            this.textBoxOutput_SKR.Name = "textBoxOutput_SKR";
            this.textBoxOutput_SKR.ReadOnly = true;
            this.textBoxOutput_SKR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_SKR.Size = new System.Drawing.Size(273, 375);
            this.textBoxOutput_SKR.TabIndex = 4;
            this.textBoxOutput_SKR.TextChanged += new System.EventHandler(this.textBoxOutput_SKR_TextChanged);
            // 
            // groupBoxOutput_SKR
            // 
            this.groupBoxOutput_SKR.Controls.Add(this.splitter2);
            this.groupBoxOutput_SKR.Controls.Add(this.splitter1);
            this.groupBoxOutput_SKR.Controls.Add(this.textBoxOutput_SKR);
            this.groupBoxOutput_SKR.Location = new System.Drawing.Point(3, 64);
            this.groupBoxOutput_SKR.Name = "groupBoxOutput_SKR";
            this.groupBoxOutput_SKR.Size = new System.Drawing.Size(290, 394);
            this.groupBoxOutput_SKR.TabIndex = 5;
            this.groupBoxOutput_SKR.TabStop = false;
            this.groupBoxOutput_SKR.Text = "Вывод:";
            this.groupBoxOutput_SKR.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chartResult_SKR
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult_SKR.ChartAreas.Add(chartArea2);
            this.chartResult_SKR.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.chartResult_SKR.Location = new System.Drawing.Point(299, 83);
            this.chartResult_SKR.Name = "chartResult_SKR";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Name = "Series1";
            this.chartResult_SKR.Series.Add(series2);
            this.chartResult_SKR.Size = new System.Drawing.Size(559, 355);
            this.chartResult_SKR.TabIndex = 5;
            this.chartResult_SKR.Text = "chartFunction_SKR";
            this.chartResult_SKR.Click += new System.EventHandler(this.chartResult_SKR_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(276, 16);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(585, 375);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(861, 16);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(606, 375);
            this.splitter2.TabIndex = 6;
            this.splitter2.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 471);
            this.Controls.Add(this.chartResult_SKR);
            this.Controls.Add(this.groupBoxOutput_SKR);
            this.Controls.Add(this.groupBoxInput_SKR);
            this.Controls.Add(this.groupBoxUslovie_SKR);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 24 | Кропчев С.Р.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovie_SKR.ResumeLayout(false);
            this.groupBoxUslovie_SKR.PerformLayout();
            this.groupBoxInput_SKR.ResumeLayout(false);
            this.groupBoxInput_SKR.PerformLayout();
            this.groupBoxOutput_SKR.ResumeLayout(false);
            this.groupBoxOutput_SKR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SKR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUslovie_SKR;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBoxUslovie_SKR;
        private System.Windows.Forms.GroupBox groupBoxInput_SKR;
        private System.Windows.Forms.TextBox textBoxX_SKR;
        private System.Windows.Forms.Label labelX_SKR;
        private System.Windows.Forms.Label labelY_SKR;
        private System.Windows.Forms.TextBox textBoxY_SKR;
        private System.Windows.Forms.Button buttonSave_SKR;
        private System.Windows.Forms.Button buttonDone_SKR;
        private System.Windows.Forms.Button buttonHelp_SKR;
        private System.Windows.Forms.TextBox textBoxOutput_SKR;
        private System.Windows.Forms.GroupBox groupBoxOutput_SKR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SKR;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
    }
}

