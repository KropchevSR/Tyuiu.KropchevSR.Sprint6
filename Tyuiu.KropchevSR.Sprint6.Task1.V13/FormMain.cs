using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KropchevSR.Sprint6.Task1.V13.Lib;

namespace Tyuiu.KropchevSR.Sprint6.Task1.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_KSR_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxVarX_KSR.Text);
                int endStep = Convert.ToInt32(textBoxVarY_KSR.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, endStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, endStep);
                textBoxResult_KSR.Text = "";
                textBoxResult_KSR.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KSR.AppendText("|    X     |   F(x)   |" + Environment.NewLine);
                textBoxResult_KSR.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <=len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f1}   | ", startStep, valueArray[i]);
                    textBoxResult_KSR.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_KSR.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_KSR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }
        private void buttonInfo_KSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0,вариант 14 выполнил студент группы АСОиУб-23-1 Кропчев Степан Романович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelVarX_KSR_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxResult_KSR_Enter(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
