using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Tyuiu.KropchevSR.Sprint6.Task3.V18.Lib;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KropchevSR.Sprint6.Task3.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5]
                    {{-19,-19,1,18,7},
                     {5,3,-4,-6,-12},
                     { -15,6,2,2,-14},
                     {-9,-10,15,-5,-6},
                     {-13,-15,-9,7,1}};



        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_SKR.ColumnCount = columns;
            dataGridViewMatrix_SKR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_SKR.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_SKR.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        private void buttonDone_SKR_Click(object sender, EventArgs e)
        {
            var sorted_matrix = ds.Calculate(mtrx);

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult_SKR.ColumnCount = columns;
            dataGridViewResult_SKR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_SKR.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_SKR.Rows[i].Cells[j].Value = Convert.ToString(sorted_matrix[i, j]);
                }
            }
        }

        private void groupBoxResult_SKR_Enter(object sender, EventArgs e)
        {

        }

        private void buttonHelp_SKR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3, вариант 18 выполнил студент группы АСОиУб-23-1 Кропчев Степан Романович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
