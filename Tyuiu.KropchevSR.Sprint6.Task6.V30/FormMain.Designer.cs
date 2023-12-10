namespace Tyuiu.KropchevSR.Sprint6.Task6.V30
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxUslovie_SKR = new System.Windows.Forms.TextBox();
            this.groupBoxUslovie = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxInput_SKR = new System.Windows.Forms.GroupBox();
            this.textBoxInput_SKR = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_SKR = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_SKR = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_SKR = new System.Windows.Forms.ToolTip(this.components);
            this.buttonFileSelect_SKR = new System.Windows.Forms.Button();
            this.buttonFirst_SKR = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxUslovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxInput_SKR.SuspendLayout();
            this.groupBoxOutput_SKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUslovie_SKR
            // 
            this.textBoxUslovie_SKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUslovie_SKR.Location = new System.Drawing.Point(3, 16);
            this.textBoxUslovie_SKR.Multiline = true;
            this.textBoxUslovie_SKR.Name = "textBoxUslovie_SKR";
            this.textBoxUslovie_SKR.Size = new System.Drawing.Size(803, 100);
            this.textBoxUslovie_SKR.TabIndex = 0;
            this.textBoxUslovie_SKR.Text = resources.GetString("textBoxUslovie_SKR.Text");
            this.textBoxUslovie_SKR.TextChanged += new System.EventHandler(this.textBoxUslovie_SKR_TextChanged);
            // 
            // groupBoxUslovie
            // 
            this.groupBoxUslovie.Controls.Add(this.textBoxUslovie_SKR);
            this.groupBoxUslovie.Location = new System.Drawing.Point(5, 50);
            this.groupBoxUslovie.Name = "groupBoxUslovie";
            this.groupBoxUslovie.Size = new System.Drawing.Size(809, 119);
            this.groupBoxUslovie.TabIndex = 1;
            this.groupBoxUslovie.TabStop = false;
            this.groupBoxUslovie.Text = "Условие";
            this.groupBoxUslovie.Enter += new System.EventHandler(this.groupBoxUslovie_Enter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(5, 175);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxInput_SKR);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOutput_SKR);
            this.splitContainer1.Size = new System.Drawing.Size(801, 287);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // groupBoxInput_SKR
            // 
            this.groupBoxInput_SKR.Controls.Add(this.textBoxInput_SKR);
            this.groupBoxInput_SKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_SKR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_SKR.Name = "groupBoxInput_SKR";
            this.groupBoxInput_SKR.Size = new System.Drawing.Size(384, 287);
            this.groupBoxInput_SKR.TabIndex = 2;
            this.groupBoxInput_SKR.TabStop = false;
            this.groupBoxInput_SKR.Text = "Ввод:";
            this.groupBoxInput_SKR.Enter += new System.EventHandler(this.groupBoxInput_SKR_Enter);
            // 
            // textBoxInput_SKR
            // 
            this.textBoxInput_SKR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxInput_SKR.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput_SKR.Multiline = true;
            this.textBoxInput_SKR.Name = "textBoxInput_SKR";
            this.textBoxInput_SKR.ReadOnly = true;
            this.textBoxInput_SKR.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxInput_SKR.Size = new System.Drawing.Size(332, 211);
            this.textBoxInput_SKR.TabIndex = 0;
            this.textBoxInput_SKR.TextChanged += new System.EventHandler(this.textBoxInput_SKR_TextChanged);
            // 
            // groupBoxOutput_SKR
            // 
            this.groupBoxOutput_SKR.Controls.Add(this.textBoxOutput_SKR);
            this.groupBoxOutput_SKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_SKR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_SKR.Name = "groupBoxOutput_SKR";
            this.groupBoxOutput_SKR.Size = new System.Drawing.Size(413, 287);
            this.groupBoxOutput_SKR.TabIndex = 3;
            this.groupBoxOutput_SKR.TabStop = false;
            this.groupBoxOutput_SKR.Text = "Вывод:";
            this.groupBoxOutput_SKR.Enter += new System.EventHandler(this.groupBoxOutput_SKR_Enter);
            // 
            // textBoxOutput_SKR
            // 
            this.textBoxOutput_SKR.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxOutput_SKR.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutput_SKR.Multiline = true;
            this.textBoxOutput_SKR.Name = "textBoxOutput_SKR";
            this.textBoxOutput_SKR.ReadOnly = true;
            this.textBoxOutput_SKR.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxOutput_SKR.Size = new System.Drawing.Size(332, 211);
            this.textBoxOutput_SKR.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog_SKR";
            // 
            // toolTip_SKR
            // 
            this.toolTip_SKR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_SKR.ToolTipTitle = "Подсказка";
            // 
            // buttonFileSelect_SKR
            // 
            this.buttonFileSelect_SKR.BackColor = System.Drawing.SystemColors.Window;
            this.buttonFileSelect_SKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFileSelect_SKR.Image = global::Tyuiu.KropchevSR.Sprint6.Task6.V30.Properties.Resources.folder_add;
            this.buttonFileSelect_SKR.Location = new System.Drawing.Point(0, 0);
            this.buttonFileSelect_SKR.Name = "buttonFileSelect_SKR";
            this.buttonFileSelect_SKR.Size = new System.Drawing.Size(148, 41);
            this.buttonFileSelect_SKR.TabIndex = 4;
            this.toolTip_SKR.SetToolTip(this.buttonFileSelect_SKR, "Открыть файл");
            this.buttonFileSelect_SKR.UseVisualStyleBackColor = false;
            this.buttonFileSelect_SKR.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonFirst_SKR
            // 
            this.buttonFirst_SKR.BackColor = System.Drawing.SystemColors.Window;
            this.buttonFirst_SKR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFirst_SKR.Enabled = false;
            this.buttonFirst_SKR.Image = global::Tyuiu.KropchevSR.Sprint6.Task6.V30.Properties.Resources.page_go;
            this.buttonFirst_SKR.Location = new System.Drawing.Point(0, 0);
            this.buttonFirst_SKR.Name = "buttonFirst_SKR";
            this.buttonFirst_SKR.Size = new System.Drawing.Size(159, 41);
            this.buttonFirst_SKR.TabIndex = 3;
            this.buttonFirst_SKR.UseVisualStyleBackColor = false;
            this.buttonFirst_SKR.Click += new System.EventHandler(this.buttonFirst_SKR_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(12, 12);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonFileSelect_SKR);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonFirst_SKR);
            this.splitContainer2.Size = new System.Drawing.Size(311, 41);
            this.splitContainer2.SplitterDistance = 148;
            this.splitContainer2.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 461);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.groupBoxUslovie);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(825, 500);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 30 | Кропчев С.Р.";
            this.groupBoxUslovie.ResumeLayout(false);
            this.groupBoxUslovie.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxInput_SKR.ResumeLayout(false);
            this.groupBoxInput_SKR.PerformLayout();
            this.groupBoxOutput_SKR.ResumeLayout(false);
            this.groupBoxOutput_SKR.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUslovie_SKR;
        private System.Windows.Forms.GroupBox groupBoxUslovie;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonFirst_SKR;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip_SKR;
        private System.Windows.Forms.Button buttonFileSelect_SKR;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBoxInput_SKR;
        private System.Windows.Forms.TextBox textBoxInput_SKR;
        private System.Windows.Forms.GroupBox groupBoxOutput_SKR;
        private System.Windows.Forms.TextBox textBoxOutput_SKR;
    }
}

