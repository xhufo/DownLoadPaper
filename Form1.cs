using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FlowRun;

namespace DownLoadPaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Run1 c1 = new Run1();
        //readonly string path = "JournalList.json";
        //c1.Read(Path); //读json文件 返回字典

        private void label1_Click(object sender, EventArgs e)
        {

        }
         

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        string defaultfilePath = "";
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            
            //首次defaultfilePath为空，按FolderBrowserDialog默认设置（即桌面）选择
            if (defaultfilePath != "")
            {
                //设置此次默认目录为上一次选中目录
                folderBrowserDialog1.SelectedPath = defaultfilePath;
            }

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录
                defaultfilePath = folderBrowserDialog1.SelectedPath;
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            } 
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
