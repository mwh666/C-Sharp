using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 from2 = new Form2();
            //非模态窗体打开的form2可以和form1同时执行
            //from2.Show();

            //模态窗体打开的form2必须先执行完毕，才能执行form1
            from2.ShowDialog();
        }
    }
}
