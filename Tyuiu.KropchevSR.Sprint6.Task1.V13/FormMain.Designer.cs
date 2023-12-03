namespace Tyuiu.KropchevSR.Sprint6.Task1.V13
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
            this.buttonDone_KSR = new System.Windows.Forms.Button();
            this.buttonInfo_KSR = new System.Windows.Forms.Button();
            this.groupBoxTask_KSR = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KSR = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_KSR = new System.Windows.Forms.PictureBox();
            this.groupBoxVars_KSR = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVarY_KSR = new System.Windows.Forms.TextBox();
            this.labelVarX_KSR = new System.Windows.Forms.Label();
            this.textBoxVarX_KSR = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KSR = new System.Windows.Forms.GroupBox();
            this.labelResult_KSR = new System.Windows.Forms.Label();
            this.textBoxResult_KSR = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KSR)).BeginInit();
            this.groupBoxVars_KSR.SuspendLayout();
            this.groupBoxResult_KSR.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_KSR
            // 
            this.buttonDone_KSR.Location = new System.Drawing.Point(664, 403);
            this.buttonDone_KSR.Name = "buttonDone_KSR";
            this.buttonDone_KSR.Size = new System.Drawing.Size(104, 35);
            this.buttonDone_KSR.TabIndex = 0;
            this.buttonDone_KSR.Text = "Выполнить";
            this.buttonDone_KSR.UseVisualStyleBackColor = true;
            this.buttonDone_KSR.Click += new System.EventHandler(this.buttonDone_KSR_Click);
            // 
            // buttonInfo_KSR
            // 
            this.buttonInfo_KSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_KSR.Location = new System.Drawing.Point(621, 403);
            this.buttonInfo_KSR.Name = "buttonInfo_KSR";
            this.buttonInfo_KSR.Size = new System.Drawing.Size(37, 35);
            this.buttonInfo_KSR.TabIndex = 1;
            this.buttonInfo_KSR.Text = "?";
            this.buttonInfo_KSR.UseVisualStyleBackColor = true;
            this.buttonInfo_KSR.Click += new System.EventHandler(this.buttonInfo_KSR_Click);
            // 
            // groupBoxTask_KSR
            // 
            this.groupBoxTask_KSR.Controls.Add(this.textBoxTask_KSR);
            this.groupBoxTask_KSR.Controls.Add(this.pictureBoxFormula_KSR);
            this.groupBoxTask_KSR.Location = new System.Drawing.Point(12, 51);
            this.groupBoxTask_KSR.Name = "groupBoxTask_KSR";
            this.groupBoxTask_KSR.Size = new System.Drawing.Size(776, 223);
            this.groupBoxTask_KSR.TabIndex = 2;
            this.groupBoxTask_KSR.TabStop = false;
            this.groupBoxTask_KSR.Text = "Условие";
            // 
            // textBoxTask_KSR
            // 
            this.textBoxTask_KSR.Location = new System.Drawing.Point(7, 19);
            this.textBoxTask_KSR.Multiline = true;
            this.textBoxTask_KSR.Name = "textBoxTask_KSR";
            this.textBoxTask_KSR.ReadOnly = true;
            this.textBoxTask_KSR.Size = new System.Drawing.Size(499, 198);
            this.textBoxTask_KSR.TabIndex = 1;
            this.textBoxTask_KSR.Text = "Вывести таблицу значений функции";
            // 
            // pictureBoxFormula_KSR
            // 
            this.pictureBoxFormula_KSR.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFormula_KSR.Name = "pictureBoxFormula_KSR";
            this.pictureBoxFormula_KSR.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxFormula_KSR.TabIndex = 2;
            this.pictureBoxFormula_KSR.TabStop = false;
            // 
            // groupBoxVars_KSR
            // 
            this.groupBoxVars_KSR.Controls.Add(this.label1);
            this.groupBoxVars_KSR.Controls.Add(this.textBoxVarY_KSR);
            this.groupBoxVars_KSR.Controls.Add(this.labelVarX_KSR);
            this.groupBoxVars_KSR.Controls.Add(this.textBoxVarX_KSR);
            this.groupBoxVars_KSR.Location = new System.Drawing.Point(12, 280);
            this.groupBoxVars_KSR.Name = "groupBoxVars_KSR";
            this.groupBoxVars_KSR.Size = new System.Drawing.Size(506, 100);
            this.groupBoxVars_KSR.TabIndex = 3;
            this.groupBoxVars_KSR.TabStop = false;
            this.groupBoxVars_KSR.Text = "Ввод данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Конец диапазона";
            // 
            // textBoxVarY_KSR
            // 
            this.textBoxVarY_KSR.AccessibleDescription = "";
            this.textBoxVarY_KSR.AccessibleName = "";
            this.textBoxVarY_KSR.Location = new System.Drawing.Point(157, 47);
            this.textBoxVarY_KSR.Name = "textBoxVarY_KSR";
            this.textBoxVarY_KSR.Size = new System.Drawing.Size(127, 20);
            this.textBoxVarY_KSR.TabIndex = 2;
            this.textBoxVarY_KSR.Tag = "";
            // 
            // labelVarX_KSR
            // 
            this.labelVarX_KSR.AutoSize = true;
            this.labelVarX_KSR.Location = new System.Drawing.Point(6, 31);
            this.labelVarX_KSR.Name = "labelVarX_KSR";
            this.labelVarX_KSR.Size = new System.Drawing.Size(101, 13);
            this.labelVarX_KSR.TabIndex = 1;
            this.labelVarX_KSR.Text = "Начало диапазона";
            this.labelVarX_KSR.Click += new System.EventHandler(this.labelVarX_KSR_Click);
            // 
            // textBoxVarX_KSR
            // 
            this.textBoxVarX_KSR.AccessibleDescription = "";
            this.textBoxVarX_KSR.AccessibleName = "";
            this.textBoxVarX_KSR.Location = new System.Drawing.Point(6, 47);
            this.textBoxVarX_KSR.Name = "textBoxVarX_KSR";
            this.textBoxVarX_KSR.Size = new System.Drawing.Size(127, 20);
            this.textBoxVarX_KSR.TabIndex = 0;
            this.textBoxVarX_KSR.Tag = "";
            this.textBoxVarX_KSR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KSR_KeyPress);
            // 
            // groupBoxResult_KSR
            // 
            this.groupBoxResult_KSR.Controls.Add(this.labelResult_KSR);
            this.groupBoxResult_KSR.Controls.Add(this.textBoxResult_KSR);
            this.groupBoxResult_KSR.Location = new System.Drawing.Point(525, 51);
            this.groupBoxResult_KSR.Name = "groupBoxResult_KSR";
            this.groupBoxResult_KSR.Size = new System.Drawing.Size(263, 330);
            this.groupBoxResult_KSR.TabIndex = 4;
            this.groupBoxResult_KSR.TabStop = false;
            this.groupBoxResult_KSR.Enter += new System.EventHandler(this.groupBoxResult_KSR_Enter);
            // 
            // labelResult_KSR
            // 
            this.labelResult_KSR.AutoSize = true;
            this.labelResult_KSR.Location = new System.Drawing.Point(-3, 0);
            this.labelResult_KSR.Name = "labelResult_KSR";
            this.labelResult_KSR.Size = new System.Drawing.Size(59, 13);
            this.labelResult_KSR.TabIndex = 1;
            this.labelResult_KSR.Text = "Результат";
            // 
            // textBoxResult_KSR
            // 
            this.textBoxResult_KSR.Location = new System.Drawing.Point(6, 19);
            this.textBoxResult_KSR.Multiline = true;
            this.textBoxResult_KSR.Name = "textBoxResult_KSR";
            this.textBoxResult_KSR.ReadOnly = true;
            this.textBoxResult_KSR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KSR.Size = new System.Drawing.Size(251, 305);
            this.textBoxResult_KSR.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxResult_KSR);
            this.Controls.Add(this.groupBoxVars_KSR);
            this.Controls.Add(this.groupBoxTask_KSR);
            this.Controls.Add(this.buttonInfo_KSR);
            this.Controls.Add(this.buttonDone_KSR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 14 | Кропчев С. Р.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_KSR.ResumeLayout(false);
            this.groupBoxTask_KSR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KSR)).EndInit();
            this.groupBoxVars_KSR.ResumeLayout(false);
            this.groupBoxVars_KSR.PerformLayout();
            this.groupBoxResult_KSR.ResumeLayout(false);
            this.groupBoxResult_KSR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_KSR;
        private System.Windows.Forms.Button buttonInfo_KSR;
        private System.Windows.Forms.GroupBox groupBoxTask_KSR;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KSR;
        private System.Windows.Forms.GroupBox groupBoxVars_KSR;
        private System.Windows.Forms.TextBox textBoxVarX_KSR;
        private System.Windows.Forms.GroupBox groupBoxResult_KSR;
        private System.Windows.Forms.TextBox textBoxResult_KSR;
        private System.Windows.Forms.TextBox textBoxTask_KSR;
        private System.Windows.Forms.Label labelVarX_KSR;
        private System.Windows.Forms.Label labelResult_KSR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVarY_KSR;
    }
}

