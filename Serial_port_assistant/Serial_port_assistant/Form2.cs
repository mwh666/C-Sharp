using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serial_port_assistant
{
    public partial class Form2 : Form
    {

        public TransmitData userForm1Send;
        public event TransmitEventHandler userForm1Send2;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void ReciveData(byte[] tempdata)
        {
            string str = Encoding.GetEncoding("gb2312").GetString(tempdata);
            str=str.Replace("\0", "\\0");
            richTextBox1.AppendText(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] dataTemp = Encoding.GetEncoding("GB2312").GetBytes(textBox1.Text);

            userForm1Send?.Invoke(dataTemp);
            userForm1Send2?.Invoke(this, new TransimitEventAgrs { data = dataTemp });
        }

        internal void ReciveData2(object sender, TransimitEventAgrs s)
        {
            string str = Encoding.GetEncoding("gb2312").GetString(s.data);
            //str = str.Replace("\0", "\\0");
            //richTextBox1.AppendText(str);
            MessageBox.Show(str);
        }
    }
}
