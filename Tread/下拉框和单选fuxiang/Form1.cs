using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 下拉框和单选fuxiang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("大面包");
            this.comboBox1.Items.Add("小面包");
            this.comboBox1.Items.Add("超级面包");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region
            string str = "";
            string str1 = "";
            //遍历panel1中的所有CheckBox控件,panel1.Controls是一个控件集合
            foreach (CheckBox item in panel1.Controls)
            {
                if (item.Checked)
                {
                    if (str != null)
                    {
                        str += ",";
                    }
                    str += item.Text;
                }
            }
            //MessageBox.Show($"时间段：{str}");
            #endregion

            foreach (RadioButton radioButton in this.panel2.Controls)
            {
                if(radioButton.Checked)
                {
                    str1 = radioButton.Text;
                    break;
                }
            }
            MessageBox.Show($"时间段：{str}\n优惠：{str1}");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // label2.Text = comboBox1.SelectedItem.ToString();
            this.label2.Text = this.comboBox1.Text;
        }
    }
}
