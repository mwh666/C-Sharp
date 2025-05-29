using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int imgIndex = 0;
        private int num;
        private void Form1_Load(object sender, EventArgs e)
        {
            num=this.imageList1.Images.Count;
            SetButtonEnable();
            this.pictureBox1.Image = this.imageList1.Images[imgIndex];
            if (imgIndex == 0)
            {
                //使上一张按钮不可用
                this.btPrav.Enabled = false;
            }
            
        }

        private void btPrav_Click(object sender, EventArgs e)
        {
            
            imgIndex--;
            SetButtonEnable();
            this.pictureBox1.Image=this.imageList1.Images[imgIndex];
        }

        private void btNext_Click(object sender, EventArgs e)
        {
           
            imgIndex++;
            SetButtonEnable();
            this.pictureBox1.Image = this.imageList1.Images[imgIndex];
        }


        //控制上一张和下一张按钮的可用性
        private void SetButtonEnable()
        {
            
            if (imgIndex == 0)
            {
                //使上一张按钮不可用
                this.btPrav.Enabled = false;
            }
            else
            {
                this.btPrav.Enabled = true;
            }
            if (imgIndex == num - 1)
            {
                //使下一张按钮不可用
                this.btNext.Enabled= false;
            }
            else
            {
                this.btNext.Enabled = true;
            }
        }
    }
}
