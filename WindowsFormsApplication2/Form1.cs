using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FileName = "C:\\";
            openFileDialog1.ShowDialog();
            linkLabel1.Text = openFileDialog1.FileName;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            saveFileDialog1.FileName = "C:\\";
            saveFileDialog1.ShowDialog();
            linkLabel2.Text = saveFileDialog1.FileName;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            linkLabel3.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            progressBar1.Refresh();
            progressBar1.ResetText();
            for (int k = 0; k < 100; k++)
                progressBar1.Increment(1);

        }
    }
}
