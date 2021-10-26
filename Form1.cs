using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020002309_方泽楠_学生管理
{
    public partial class Form1 : Form
    {
        sxb s1 = new sxb(1);
        String str = "";
        public Form1()
        {
            InitializeComponent();
            listBox1.Text = s1.ToString();

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count - 1; i++)
            {
                for (int j = 0; j < listBox1.Items.Count - 1 - i; j++)
                {
                    if (int.Parse(listBox1.Items[j].ToString().Replace("         ", ",").Split(',')[0]) > int.Parse(listBox1.Items[j + 1].ToString().Replace("         ", ",").Split(',')[0]))
                    {
                        //MessageBox.Show(int.Parse(listBox1.Items[j].ToString().Replace("         ", ",").Split(',')[0]) + "", "we", MessageBoxButtons.OKCancel);
                        object temp;
                        temp = listBox1.Items[j];
                        listBox1.Items[j] = listBox1.Items[j + 1];
                        listBox1.Items[j + 1] = temp;
                    }
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count - 1; i++)
            {
                for (int j = 0; j < listBox1.Items.Count - 1 - i; j++)
                {
                    if (int.Parse(listBox1.Items[j].ToString().Replace("         ",",").Split(',')[0]) < int.Parse(listBox1.Items[j + 1].ToString().Replace("         ", ",").Split(',')[0]))
                    {
                        //MessageBox.Show(int.Parse(listBox1.Items[j].ToString().Replace("         ", ",").Split(',')[0]) + "", "we", MessageBoxButtons.OKCancel);
                        object temp;
                        temp = listBox1.Items[j];
                        listBox1.Items[j] = listBox1.Items[j + 1];
                        listBox1.Items[j + 1] = temp;
                    }
                }
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            xs x1 = new xs();
            str += textBox1.Text + ",";
            x1.name = textBox1.Text;
            x1.xh = int.Parse(textBox2.Text);
            MessageBox.Show(s1.insert(s1.getLen(), x1.xh) + "", "添加位置" + (s1.getLen() - 1), MessageBoxButtons.OKCancel);
            listBox1.Items.Add(x1.xh + "         " + x1.name);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            str = str.Replace((str.Split(',')[int.Parse(textBox3.Text) - 1] + ","), "");
            MessageBox.Show(s1.delIndex(int.Parse(textBox3.Text)) + "", "删除位置" + int.Parse(textBox3.Text), MessageBoxButtons.OKCancel);
            listBox1.Items.RemoveAt(int.Parse(textBox3.Text) - 1);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("姓名为" + (str.Split(',')[int.Parse(textBox4.Text) - 1]) + "学号为" + s1.findI(int.Parse(textBox4.Text)), "查询位置" + int.Parse(textBox4.Text), MessageBoxButtons.OKCancel);
        }
    }
}
