using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HalconDotNet;
namespace shiyan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         HObject Image;
         HObject Region;
         HTuple low=100;
         HTuple Area;
         HTuple Row;
         HTuple Column;

            //创建一个对象，用于读取图片
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                HOperatorSet.ReadImage(out Image, openFileDialog.FileName);
                //调用test方法  out关键字表明后面的变量为输出的参数
                my.Test.test(Image,out Region,low,out Area, out Row, out Column);
            }






        }
    }
}
