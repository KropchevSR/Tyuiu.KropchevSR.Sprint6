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
using Tyuiu.KropchevSR.Sprint6.Task5.V9.Lib;

namespace Tyuiu.KropchevSR.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path = @"C:\Users\Степан\source\repos\Tyuiu.KropchevSR.Sprint6\Tyuiu.KropchevSR.Sprint6.Task5.V9\bin\Debug\InPutFileTask5V9.txt";

        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxUslovie_SKR_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDone_SKR_Click(object sender, EventArgs e)
        {
            dataGridviewSums_SKR.Rows.Clear();
            dataGridviewSums_SKR.ColumnCount = 2;
            dataGridviewSums_SKR.Columns[0].Width = 20;
            dataGridviewSums_SKR.Columns[1].Width = 50;
            this.chartResult_SKR.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_SKR.ChartAreas[0].AxisY.Title = "Ось Y";
            chartResult_SKR.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);
            string pathout = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
            for (int i = 0; i< numsMass.Length;i++)
            {
                Console.WriteLine(ds.LoadFromDataFile(path)[i]);
                dataGridviewSums_SKR.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_SKR.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonHelp_SKR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5, вариант 9 выполнил студент группы АСОиУб-23-1 Кропчев Степан Романович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SKR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask5.txt";
            txt.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxOutput_SKR_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void chartResult_SKR_click(object sender, EventArgs e)
        {

        }
    }
}
