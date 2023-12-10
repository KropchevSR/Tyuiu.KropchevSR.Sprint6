using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KropchevSR.Sprint6.Task6.V30.Lib;

namespace Tyuiu.KropchevSR.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public string openFilePath;
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxUslovie_SKR_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void buttonFirst_SKR_Click(object sender, EventArgs e)
        {
            textBoxOutput_SKR.Text = ds.CollectTextFromFile(openFilePath);

        }

        private void groupBoxUslovie_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxInput_SKR_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxOutput_SKR_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxInput_SKR_Enter(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            openFilePath = openFileDialog.FileName;
            textBoxInput_SKR.Text = File.ReadAllText(openFilePath);
            groupBoxInput_SKR.Text = groupBoxInput_SKR.Text + " " + openFileDialog.FileName;
            buttonFirst_SKR.Enabled = true;
        }
    }
}
