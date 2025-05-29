using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraExport.Xls;
using HalconDotNet;
using static System.Windows.Forms.MonthCalendar;

namespace Matchs
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        HWindow hw_home;
        HObject ReadImage1, ho_ModelContours, ho_ContoursAffineTrans;
        HTuple Width1;
        HTuple height1;
        HTuple row, column, radius, hv_Area, hv_Row, hv_Column, hv_ModelID, hv_HomMat2D;
        HObject circle, reducedImage;

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化Halcon窗口
            hw_home = hWindowControl1.HalconWindow;
        }

        

        private void barCreateROI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HOperatorSet.GenEmptyObj(out circle);
            ReadImage1.Dispose();
            //显示原图
            HOperatorSet.DispObj(circle, hw_home);


            HOperatorSet.SetColor(hw_home, "green");
            HOperatorSet.SetDraw(hw_home, "margin");
            HOperatorSet.SetLineWidth(hw_home, 2);
            HOperatorSet.SetTposition(hw_home, 50, 50);
            HOperatorSet.WriteString(hw_home, "请选择ROI区域");

            HOperatorSet.DrawCircle(hw_home, out row, out column, out radius);
            HOperatorSet.GenCircle(out circle, row, column, radius); // Corrected method call  
            HOperatorSet.DispObj(circle, hw_home); // Display the generated circle  
        }

        private void BtnReadImage_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HOperatorSet.GenEmptyObj(out ReadImage1);
            ReadImage1.Dispose();
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "选择图片";
                ofd.Multiselect = false;
                ofd.Filter = "图片文件|*.jpg;*.png;*.bmp;*.tif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    HOperatorSet.ReadImage(out ReadImage1, filePath);
                    HOperatorSet.GetImageSize(ReadImage1, out Width1, out height1);
                    HOperatorSet.SetPart(hw_home, 0, 0, height1 - 1, Width1 - 1);

                    HOperatorSet.DispObj(ReadImage1, hw_home);

                }
            }
            ReadImage1.Dispose();
        }

       

       
    }
}
