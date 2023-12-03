namespace Tyuiu.KropchevSR.Sprint6.Task0.V14
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
            this.textBoxTask_KSR.Size = new System.Drawing.Size(639, 198);
            this.textBoxTask_KSR.TabIndex = 1;
            this.textBoxTask_KSR.Text = "Дано выражение вычислить его значение";
            // 
            // pictureBoxFormula_KSR
            // 
            this.pictureBoxFormula_KSR.Image = global::Tyuiu.KropchevSR.Sprint6.Task0.V14.Properties.Resources.Task0;
            this.pictureBoxFormula_KSR.ImageLocation = "";
            this.pictureBoxFormula_KSR.Location = new System.Drawing.Point(652, 19);
            this.pictureBoxFormula_KSR.Name = "pictureBoxFormula_KSR";
            this.pictureBoxFormula_KSR.Size = new System.Drawing.Size(129, 63);
            this.pictureBoxFormula_KSR.TabIndex = 0;
            this.pictureBoxFormula_KSR.TabStop = false;
            // 
            // groupBoxVars_KSR
            // 
            this.groupBoxVars_KSR.Controls.Add(this.labelVarX_KSR);
            this.groupBoxVars_KSR.Controls.Add(this.textBoxVarX_KSR);
            this.groupBoxVars_KSR.Location = new System.Drawing.Point(12, 280);
            this.groupBoxVars_KSR.Name = "groupBoxVars_KSR";
            this.groupBoxVars_KSR.Size = new System.Drawing.Size(506, 100);
            this.groupBoxVars_KSR.TabIndex = 3;
            this.groupBoxVars_KSR.TabStop = false;
            this.groupBoxVars_KSR.Text = "Ввод данных";
            // 
            // labelVarX_KSR
            // 
            this.labelVarX_KSR.AutoSize = true;
            this.labelVarX_KSR.Location = new System.Drawing.Point(6, 31);
            this.labelVarX_KSR.Name = "labelVarX_KSR";
            this.labelVarX_KSR.Size = new System.Drawing.Size(81, 13);
            this.labelVarX_KSR.TabIndex = 1;
            this.labelVarX_KSR.Text = "Переменная Х";
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
            this.groupBoxResult_KSR.Location = new System.Drawing.Point(525, 280);
            this.groupBoxResult_KSR.Name = "groupBoxResult_KSR";
            this.groupBoxResult_KSR.Size = new System.Drawing.Size(263, 101);
            this.groupBoxResult_KSR.TabIndex = 4;
            this.groupBoxResult_KSR.TabStop = false;
            this.groupBoxResult_KSR.Text = "Вывод данных";
            // 
            // labelResult_KSR
            // 
            this.labelResult_KSR.AutoSize = true;
            this.labelResult_KSR.Location = new System.Drawing.Point(33, 31);
            this.labelResult_KSR.Name = "labelResult_KSR";
            this.labelResult_KSR.Size = new System.Drawing.Size(59, 13);
            this.labelResult_KSR.TabIndex = 1;
            this.labelResult_KSR.Text = "Результат";
            // 
            // textBoxResult_KSR
            // 
            this.textBoxResult_KSR.Location = new System.Drawing.Point(36, 47);
            this.textBoxResult_KSR.Name = "textBoxResult_KSR";
            this.textBoxResult_KSR.ReadOnly = true;
            this.textBoxResult_KSR.Size = new System.Drawing.Size(194, 20);
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
    }
}

