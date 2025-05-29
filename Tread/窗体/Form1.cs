using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在窗体加载时弹出对话框
            MessageBox.Show("Hello, World!");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("窗体被点击了！");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 修复 CS0019 错误：将 MessageBox.Show 的返回值与 DialogResult.Yes 进行比较
            DialogResult result = MessageBox.Show("确定关闭此页面吗？", "提示框", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                //取消窗体关闭事件
                e.Cancel = true;
            }
            else
            {
                
            }
        }
    }
}
