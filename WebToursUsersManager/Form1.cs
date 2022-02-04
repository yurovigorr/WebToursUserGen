using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebToursUsersManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Searching the folder
            if (System.IO.Directory.Exists("C:\\WebTours\\cgi-bin\\users"))
            {
                ChooseFolder("C:\\WebTours\\cgi-bin\\users");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectFolder();
        }
        public void ChooseFolder(string path)
        {
            folderBrowserDialog1.SelectedPath = path;
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }
        public void SelectFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
