using System;

namespace Tyuiu.KropchevSR.Sprint6.Task5.V9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxUslovie_SKR = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_SKR = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxInv_SKR = new System.Windows.Forms.GroupBox();
            this.buttonHelp_SKR = new System.Windows.Forms.Button();
            this.buttonSave_SKR = new System.Windows.Forms.Button();
            this.buttonDone_SKR = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxOutput_SKR = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_SKR = new System.Windows.Forms.TextBox();
            this.chartResult_SKR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridviewSums_SKR = new System.Windows.Forms.DataGridView();
            this.groupBoxUslovie_SKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxInv_SKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxOutput_SKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SKR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewSums_SKR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_SKR
            // 
            this.groupBoxUslovie_SKR.Controls.Add(this.textBoxUslovie_SKR);
            this.groupBoxUslovie_SKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUslovie_SKR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUslovie_SKR.Name = "groupBoxUslovie_SKR";
            this.groupBoxUslovie_SKR.Size = new System.Drawing.Size(243, 107);
            this.groupBoxUslovie_SKR.TabIndex = 3;
            this.groupBoxUslovie_SKR.TabStop = false;
            this.groupBoxUslovie_SKR.Text = "Условие";
            // 
            // textBoxUslovie_SKR
            // 
            this.textBoxUslovie_SKR.Location = new System.Drawing.Point(3, 14);
            this.textBoxUslovie_SKR.Multiline = true;
            this.textBoxUslovie_SKR.Name = "textBoxUslovie_SKR";
            this.textBoxUslovie_SKR.ReadOnly = true;
            this.textBoxUslovie_SKR.Size = new System.Drawing.Size(230, 60);
            this.textBoxUslovie_SKR.TabIndex = 0;
            this.textBoxUslovie_SKR.Text = resources.GetString("textBoxUslovie_SKR.Text");
            this.textBoxUslovie_SKR.TextChanged += new System.EventHandler(this.textBoxUslovie_SKR_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxUslovie_SKR);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxInv_SKR);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(729, 107);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 4;
            // 
            // groupBoxInv_SKR
            // 
            this.groupBoxInv_SKR.Controls.Add(this.buttonHelp_SKR);
            this.groupBoxInv_SKR.Controls.Add(this.buttonSave_SKR);
            this.groupBoxInv_SKR.Controls.Add(this.buttonDone_SKR);
            this.groupBoxInv_SKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInv_SKR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInv_SKR.Name = "groupBoxInv_SKR";
            this.groupBoxInv_SKR.Size = new System.Drawing.Size(482, 107);
            this.groupBoxInv_SKR.TabIndex = 11;
            this.groupBoxInv_SKR.TabStop = false;
            this.groupBoxInv_SKR.Text = "groupBox1_SKR";
            this.groupBoxInv_SKR.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonHelp_SKR
            // 
            this.buttonHelp_SKR.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_SKR.Location = new System.Drawing.Point(189, 19);
            this.buttonHelp_SKR.Name = "buttonHelp_SKR";
            this.buttonHelp_SKR.Size = new System.Drawing.Size(100, 58);
            this.buttonHelp_SKR.TabIndex = 10;
            this.buttonHelp_SKR.Text = "Справка";
            this.buttonHelp_SKR.UseVisualStyleBackColor = false;
            this.buttonHelp_SKR.Click += new System.EventHandler(this.buttonHelp_SKR_Click);
            // 
            // buttonSave_SKR
            // 
            this.buttonSave_SKR.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSave_SKR.Location = new System.Drawing.Point(98, 19);
            this.buttonSave_SKR.Name = "buttonSave_SKR";
            this.buttonSave_SKR.Size = new System.Drawing.Size(100, 58);
            this.buttonSave_SKR.TabIndex = 9;
            this.buttonSave_SKR.Text = "Открыть файл";
            this.buttonSave_SKR.UseVisualStyleBackColor = false;
            this.buttonSave_SKR.Click += new System.EventHandler(this.buttonSave_SKR_Click);
            // 
            // buttonDone_SKR
            // 
            this.buttonDone_SKR.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonDone_SKR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.buttonDone_SKR.Location = new System.Drawing.Point(1, 19);
            this.buttonDone_SKR.Name = "buttonDone_SKR";
            this.buttonDone_SKR.Size = new System.Drawing.Size(100, 58);
            this.buttonDone_SKR.TabIndex = 8;
            this.buttonDone_SKR.Text = "Выполнить";
            this.buttonDone_SKR.UseVisualStyleBackColor = false;
            this.buttonDone_SKR.Click += new System.EventHandler(this.buttonDone_SKR_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(3, 112);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxOutput_SKR);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chartResult_SKR);
            this.splitContainer2.Size = new System.Drawing.Size(727, 301);
            this.splitContainer2.SplitterDistance = 242;
            this.splitContainer2.TabIndex = 5;
            // 
            // groupBoxOutput_SKR
            // 
            this.groupBoxOutput_SKR.Controls.Add(this.dataGridviewSums_SKR);
            this.groupBoxOutput_SKR.Controls.Add(this.textBoxOutput_SKR);
            this.groupBoxOutput_SKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_SKR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_SKR.Name = "groupBoxOutput_SKR";
            this.groupBoxOutput_SKR.Size = new System.Drawing.Size(242, 301);
            this.groupBoxOutput_SKR.TabIndex = 0;
            this.groupBoxOutput_SKR.TabStop = false;
            this.groupBoxOutput_SKR.Text = "Вывод:";
            this.groupBoxOutput_SKR.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // textBoxOutput_SKR
            // 
            this.textBoxOutput_SKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput_SKR.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutput_SKR.Multiline = true;
            this.textBoxOutput_SKR.Name = "textBoxOutput_SKR";
            this.textBoxOutput_SKR.ReadOnly = true;
            this.textBoxOutput_SKR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_SKR.Size = new System.Drawing.Size(236, 282);
            this.textBoxOutput_SKR.TabIndex = 5;
            this.textBoxOutput_SKR.TextChanged += new System.EventHandler(this.textBoxOutput_SKR_TextChanged);
            // 
            // chartResult_SKR
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult_SKR.ChartAreas.Add(chartArea2);
            this.chartResult_SKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartResult_SKR.Location = new System.Drawing.Point(0, 0);
            this.chartResult_SKR.Name = "chartResult_SKR";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartResult_SKR.Series.Add(series2);
            this.chartResult_SKR.Size = new System.Drawing.Size(481, 301);
            this.chartResult_SKR.TabIndex = 1;
            this.chartResult_SKR.Text = "chartResult_SKR";
            this.chartResult_SKR.Click += new System.EventHandler(this.chartResult_SKR_Click);
            // 
            // dataGridviewSums_SKR
            // 
            this.dataGridviewSums_SKR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridviewSums_SKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridviewSums_SKR.Location = new System.Drawing.Point(3, 16);
            this.dataGridviewSums_SKR.Name = "dataGridviewSums_SKR";
            this.dataGridviewSums_SKR.Size = new System.Drawing.Size(236, 282);
            this.dataGridviewSums_SKR.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(850, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 9 | Кропчев С.Р.";
            this.groupBoxUslovie_SKR.ResumeLayout(false);
            this.groupBoxUslovie_SKR.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxInv_SKR.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxOutput_SKR.ResumeLayout(false);
            this.groupBoxOutput_SKR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SKR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewSums_SKR)).EndInit();
            this.ResumeLayout(false);

        }

        private void chartResult_SKR_Click(object sender, EventArgs e)
        {}

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_SKR;
        private System.Windows.Forms.TextBox textBoxUslovie_SKR;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxInv_SKR;
        private System.Windows.Forms.Button buttonHelp_SKR;
        private System.Windows.Forms.Button buttonSave_SKR;
        private System.Windows.Forms.Button buttonDone_SKR;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBoxOutput_SKR;
        private System.Windows.Forms.TextBox textBoxOutput_SKR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SKR;
        private System.Windows.Forms.DataGridView dataGridviewSums_SKR;
    }
}

