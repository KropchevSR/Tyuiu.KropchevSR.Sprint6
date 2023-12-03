using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Tyuiu.KropchevSR.Sprint6.Task2.V4.Lib;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KropchevSR.Sprint6.Task2.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_SKR_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_SKR.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_SKR.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartResult_SKR.Titles.Add("График функции");

                this.chartResult_SKR.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult_SKR.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_SKR.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.chartResult_SKR.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SKR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2, вариант 4 выполнил студент группы АСОиУб-23-1 Кропчев Степан Романович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SKR_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SKR.BackColor = Color.Red;
        }

        private void buttonDone_SKR_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SKR.BackColor = Color.Chartreuse;
        }

        private void buttonDone_SKR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SKR.BackColor = Color.Blue;
        }
    }
}
