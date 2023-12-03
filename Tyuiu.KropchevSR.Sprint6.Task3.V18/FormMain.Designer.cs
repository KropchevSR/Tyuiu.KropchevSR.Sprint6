namespace Tyuiu.KropchevSR.Sprint6.Task3.V18
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
            this.groupBoxUslovie_SKR = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie_SKR = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_SKR = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_SKR = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_SKR = new System.Windows.Forms.DataGridView();
            this.buttonHelp_SKR = new System.Windows.Forms.Button();
            this.buttonDone_SKR = new System.Windows.Forms.Button();
            this.groupBoxUslovie_SKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SKR)).BeginInit();
            this.groupBoxResult_SKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SKR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_SKR
            // 
            this.groupBoxUslovie_SKR.Controls.Add(this.textBoxUslovie_SKR);
            this.groupBoxUslovie_SKR.Location = new System.Drawing.Point(13, 13);
            this.groupBoxUslovie_SKR.Name = "groupBoxUslovie_SKR";
            this.groupBoxUslovie_SKR.Size = new System.Drawing.Size(295, 176);
            this.groupBoxUslovie_SKR.TabIndex = 0;
            this.groupBoxUslovie_SKR.TabStop = false;
            this.groupBoxUslovie_SKR.Text = "Условие";
            // 
            // textBoxUslovie_SKR
            // 
            this.textBoxUslovie_SKR.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxUslovie_SKR.Location = new System.Drawing.Point(7, 20);
            this.textBoxUslovie_SKR.Multiline = true;
            this.textBoxUslovie_SKR.Name = "textBoxUslovie_SKR";
            this.textBoxUslovie_SKR.ReadOnly = true;
            this.textBoxUslovie_SKR.Size = new System.Drawing.Size(282, 149);
            this.textBoxUslovie_SKR.TabIndex = 0;
            this.textBoxUslovie_SKR.Text = "Дана матрица 5 на 5\r\n -19 -19   1  18   7\r\n 5   3  -4  -6 -12\r\n  -15   6   2   2 -14" +
    "\r\n-9 -10  15  -5  -6\r\n -13 -15  -9   7   1\r\nЗаменить четные значения в четвертой строке на 0";
            // 
            // dataGridViewMatrix_SKR
            // 
            this.dataGridViewMatrix_SKR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SKR.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_SKR.Location = new System.Drawing.Point(314, 33);
            this.dataGridViewMatrix_SKR.Name = "dataGridViewMatrix_SKR";
            this.dataGridViewMatrix_SKR.RowHeadersVisible = false;
            this.dataGridViewMatrix_SKR.Size = new System.Drawing.Size(150, 150);
            this.dataGridViewMatrix_SKR.TabIndex = 1;
            // 
            // groupBoxResult_SKR
            // 
            this.groupBoxResult_SKR.Controls.Add(this.dataGridViewResult_SKR);
            this.groupBoxResult_SKR.Location = new System.Drawing.Point(470, 13);
            this.groupBoxResult_SKR.Name = "groupBoxResult_SKR";
            this.groupBoxResult_SKR.Size = new System.Drawing.Size(162, 176);
            this.groupBoxResult_SKR.TabIndex = 2;
            this.groupBoxResult_SKR.TabStop = false;
            this.groupBoxResult_SKR.Text = "Вывод данных";
            this.groupBoxResult_SKR.Enter += new System.EventHandler(this.groupBoxResult_SKR_Enter);
            // 
            // dataGridViewResult_SKR
            // 
            this.dataGridViewResult_SKR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_SKR.ColumnHeadersVisible = false;
            this.dataGridViewResult_SKR.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResult_SKR.Name = "dataGridViewResult_SKR";
            this.dataGridViewResult_SKR.RowHeadersVisible = false;
            this.dataGridViewResult_SKR.Size = new System.Drawing.Size(150, 150);
            this.dataGridViewResult_SKR.TabIndex = 0;
            // 
            // buttonHelp_SKR
            // 
            this.buttonHelp_SKR.Location = new System.Drawing.Point(638, 153);
            this.buttonHelp_SKR.Name = "buttonHelp_SKR";
            this.buttonHelp_SKR.Size = new System.Drawing.Size(31, 30);
            this.buttonHelp_SKR.TabIndex = 3;
            this.buttonHelp_SKR.Text = "?";
            this.buttonHelp_SKR.UseVisualStyleBackColor = true;
            this.buttonHelp_SKR.Click += new System.EventHandler(this.buttonHelp_SKR_Click);
            // 
            // buttonDone_SKR
            // 
            this.buttonDone_SKR.Location = new System.Drawing.Point(675, 154);
            this.buttonDone_SKR.Name = "buttonDone_SKR";
            this.buttonDone_SKR.Size = new System.Drawing.Size(71, 29);
            this.buttonDone_SKR.TabIndex = 4;
            this.buttonDone_SKR.Text = "Выполнить";
            this.buttonDone_SKR.UseVisualStyleBackColor = true;
            this.buttonDone_SKR.Click += new System.EventHandler(this.buttonDone_SKR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 199);
            this.Controls.Add(this.buttonDone_SKR);
            this.Controls.Add(this.buttonHelp_SKR);
            this.Controls.Add(this.groupBoxResult_SKR);
            this.Controls.Add(this.dataGridViewMatrix_SKR);
            this.Controls.Add(this.groupBoxUslovie_SKR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 18 | Кропчев С.Р.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxUslovie_SKR.ResumeLayout(false);
            this.groupBoxUslovie_SKR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SKR)).EndInit();
            this.groupBoxResult_SKR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SKR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_SKR;
        private System.Windows.Forms.TextBox textBoxUslovie_SKR;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SKR;
        private System.Windows.Forms.GroupBox groupBoxResult_SKR;
        private System.Windows.Forms.DataGridView dataGridViewResult_SKR;
        private System.Windows.Forms.Button buttonHelp_SKR;
        private System.Windows.Forms.Button buttonDone_SKR;
    }
}

