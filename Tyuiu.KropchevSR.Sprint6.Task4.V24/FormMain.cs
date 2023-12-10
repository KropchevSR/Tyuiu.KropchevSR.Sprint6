using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KropchevSR.Sprint6.Task4.V24.Lib;

namespace Tyuiu.KropchevSR.Sprint6.Task4.V24
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_SKR_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxX_SKR.Text);
                int stopValue = Convert.ToInt32(textBoxY_SKR.Text);

                int len = ds.GetMassFunction(startValue,stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartResult_SKR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_SKR.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutput_SKR.Text = "";

                chartResult_SKR.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartResult_SKR.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxOutput_SKR.AppendText(valueArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveClick_SKR(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxOutput_SKR.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно. Открыть его?", "Сообщение", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelpClick(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4, вариант 24 выполнил студент группы АСОиУб-23-1 Кропчев Степан Романович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chartResult_SKR_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void textBoxOutput_SKR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
