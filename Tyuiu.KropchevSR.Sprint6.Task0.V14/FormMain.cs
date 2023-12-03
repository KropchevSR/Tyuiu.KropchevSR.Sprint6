using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Tyuiu.KropchevSR.Sprint6.Task0.V14.Lib;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KropchevSR.Sprint6.Task0.V14
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
                textBoxResult_KSR.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KSR.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_KSR_KeyPress(object sender,KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            { e.Handled = true;}   
        }
        private void buttonInfo_KSR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0,вариант 14 выполнил студент группы АСОиУб-23-1 Кропчев Степан Романович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
