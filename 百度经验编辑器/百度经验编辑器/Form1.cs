using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 百度经验编辑器.MainClass;

namespace 百度经验编辑器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public 百度经验编辑器.MainClass.PublicClass mainclass = new 百度经验编辑器.MainClass.PublicClass();
        string strContent;
        
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "D:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fullpath = openFileDialog1.FileName;
                PublicClass.photopath = fullpath.Substring(0, fullpath.LastIndexOf('\\')+1) ;
                mainclass.FirstPhoto(fullpath, pictureBox1);
                textBox1.Focus();
                
            }
          
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            PublicClass.tag = textBox.Tag.ToString();
            mainclass.AutoChangePhoto(pictureBox1);
        }
        public string getText()
        {
            string strText = null;
            if (textBox1.Text != "")
                strText = textBox1.Text + '\n';
            if (textBox2.Text != "")
                strText = strText + textBox2.Text + '\n';
            if (textBox3.Text != "")
                strText = strText + textBox3.Text + '\n';
            if (textBox4.Text != "")
                strText = strText + textBox4.Text + '\n';
            if (textBox5.Text != "")
                strText = strText + textBox5.Text + '\n';
            if (textBox6.Text != "")
                strText = strText + textBox6.Text + '\n';
            if (textBox7.Text != "")
                strText = strText + textBox7.Text + '\n';
            if (textBox8.Text != "")
                strText = strText + textBox8.Text + '\n';
            if (textBox9.Text != "")
                strText = strText + textBox9.Text + '\n';
            return strText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainclass.GetWord(getText());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

       

       
    }
}
