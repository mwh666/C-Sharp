using HalconDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //图像变量
        HObject ho_Image = null;
        //采集句柄
        HTuple hv_AcqHandle = new HTuple();
        //显示图片的窗口句柄
        HTuple hv_windowH = new HTuple();


        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化  采集相关参数
            //查找设备
            

        }

        //连接设备
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            
        }


        //实时采集
        private void btn_Grabber_Click(object sender, EventArgs e)
        {
           
        }
    }
}
