using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 无法拒绝的表白
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Text = "是的";
            button1.Text = "不是";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = "不是";
            button1.Text = "是的";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 关闭窗口时弹出消息框
            if (e.CloseReason==CloseReason.UserClosing)
            {
                // 关闭窗口时弹出消息框
                MessageBox.Show("关闭窗口也改变不了你喜欢我的事实");
                e.Cancel = true;
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("就知道你喜欢我！");
            // 关闭窗口
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("就知道你喜欢我！");
            // 关闭窗口  比close更好,优先级更高
            Application.Exit();
            //如果在 FormClosing 事件中设置了 e.Cancel = true，Form.Close() 也会被阻止。
        }
    }
}
