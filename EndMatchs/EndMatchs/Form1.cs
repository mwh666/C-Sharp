using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HalconDotNet;
using static System.Windows.Forms.MonthCalendar;

namespace EndMatchs
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //将hw_home赋值为hWindowControl1.HalconWindow,窗口句柄为hw_home
            hw_home = hWindowControl1.HalconWindow;
        }


        // Initialize local and output iconic variables 
        HWindow hw_home;
        HObject ReadImage1,circle, ImageReduced, ho_ModelContours, ho_ContoursAffineTrans
            , ho_ContoursAffineTrans1, ho_Circle1, ho_EmptyObject;
        HTuple hv_Width, hv_Height, hv_Row, hv_Column, hv_Radius, hv_ModelID, hv_Area
    , hv_HomMat2D, hv_Row1, hv_Column1, hv_Angle, hv_Score, hv_Index, hv_HomMat2DIdentity
            , hv_HomMat2DTranslate, hv_HomMat2DRotate;


        //匹配模版
        private void BtnMatch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            HObject ExpTmpOutVar_0;

            //生成空的图像数组
            HOperatorSet.GenEmptyObj(out ho_EmptyObject);

            HOperatorSet.DispObj(ReadImage1, hw_home);

            HOperatorSet.FindShapeModel(ReadImage1, hv_ModelID, (new HTuple(-180)).TupleRad()
                    , (new HTuple(180)).TupleRad(), 0.8, 0, 0.5, "least_squares", 0, 0.9, out hv_Row1,
                    out hv_Column1, out hv_Angle, out hv_Score);

            
            //对寻找到的模版进行仿射变换
            for (hv_Index = 0; (int)hv_Index <= (int)((new HTuple(hv_Score.TupleLength())) - 1); hv_Index = (int)hv_Index + 1)
            {
                //生成相同2D变换的齐次变换矩阵。
                HOperatorSet.HomMat2dIdentity(out hv_HomMat2DIdentity);
                //平移 
                HOperatorSet.HomMat2dTranslate(hv_HomMat2DIdentity, hv_Row1.TupleSelect(hv_Index),
                        hv_Column1.TupleSelect(hv_Index), out hv_HomMat2DTranslate);
                //旋转
                HOperatorSet.HomMat2dRotate(hv_HomMat2DTranslate, hv_Angle.TupleSelect(hv_Index),
                        hv_Row1.TupleSelect(hv_Index), hv_Column1.TupleSelect(hv_Index), out hv_HomMat2DRotate);
                //仿射变换
                HOperatorSet.AffineTransContourXld(ho_ModelContours, out ho_ContoursAffineTrans1,
                    hv_HomMat2DRotate);
                //生成圆
                HOperatorSet.GenCircle(out ho_Circle1, hv_Row1.TupleSelect(hv_Index), hv_Column1.TupleSelect(
                        hv_Index), 21);
                HOperatorSet.SetColor(hw_home, "red");
                HOperatorSet.DispObj(ho_ContoursAffineTrans1, hw_home);
                HOperatorSet.SetDraw(hw_home, "margin");
                //将两个图像变为一个图像 
               /* HOperatorSet.ConcatObj(ho_Circle1, ho_EmptyObject, out ho_EmptyObject);
                ho_EmptyObject.Dispose();
                // ho_EmptyObject = ExpTmpOutVar_0;
                */
                //展示
                HOperatorSet.DispObj(ho_Circle1, hw_home);
            }
            HOperatorSet.SetTposition(hw_home, 50, 50);
            HOperatorSet.WriteString(hw_home, "当前数量：" + (int)((new HTuple(hv_Score.TupleLength()))));
        }


        //创建模版
        private void BtnCreateModel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HOperatorSet.GenEmptyObj(out ho_ContoursAffineTrans);
            ho_ContoursAffineTrans.Dispose();

            HOperatorSet.GenEmptyObj(out ImageReduced);
            ImageReduced.Dispose();

            HOperatorSet.ReduceDomain(ReadImage1, circle, out ImageReduced);


            using (HDevDisposeHelper dh = new HDevDisposeHelper())
            {
                HOperatorSet.CreateShapeModel(ImageReduced, "auto", (new HTuple(-180)).TupleRad()
                    , (new HTuple(180)).TupleRad(), "auto", "auto", "use_polarity", "auto", "auto",
                    out hv_ModelID);
            }
            //返回模版轮廓
            HOperatorSet.GetShapeModelContours(out ho_ModelContours, hv_ModelID, 1);

            HOperatorSet.AreaCenter(circle, out hv_Area, out hv_Row, out hv_Column);


            HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_Row, hv_Column, hv_Area, out hv_HomMat2D);
            //对XLD轮廓应用任意仿射2D变换。

            HOperatorSet.AffineTransContourXld(ho_ModelContours, out ho_ContoursAffineTrans,
                hv_HomMat2D);
            if (HDevWindowStack.IsOpen())
            {
                HOperatorSet.DispObj(ReadImage1, hw_home);
            }
            if (HDevWindowStack.IsOpen())
            {
                HOperatorSet.DispObj(ho_ContoursAffineTrans, hw_home);
            }
        }

    

        //创建ROI
        private void BtnCreateROI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HOperatorSet.GenEmptyObj(out circle);
            circle.Dispose();

            //显示原图,窗口重新更新，清空数据
            HOperatorSet.DispObj(ReadImage1, hw_home);
            
            HOperatorSet.SetTposition(hw_home, 50, 50);
            HOperatorSet.WriteString(hw_home, "请在图像上画ROI，右键选定");

          /*  HOperatorSet.SetTposition(hw_home, 100, 100);
            HOperatorSet.WriteString(hw_home, "右键选定");*/

            HOperatorSet.SetColor(hw_home,"green");
            HOperatorSet.SetDraw(hw_home, "margin");
            HOperatorSet.SetLineWidth(hw_home, 2);

            //画圆形ROI
            HOperatorSet.DrawCircle(hw_home, out hv_Row, out hv_Column, out hv_Radius);

            //生成圆形ROI
            HOperatorSet.GenCircle(out circle, hv_Row, hv_Column, hv_Radius);

            //显示
            HOperatorSet.DispObj(circle,hw_home);



        }

        //读取图片
        private void BtnReadImage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            HOperatorSet.GenEmptyObj(out ReadImage1);
            ReadImage1.Dispose();

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "图像|*.jpg;*.png;*.bmp;*.tif;";
                fileDialog.Multiselect = false;
                fileDialog.Title = "选择图片";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    HOperatorSet.ReadImage(out ReadImage1, fileDialog.FileName);
                    HOperatorSet.GetImageSize(ReadImage1, out hv_Width, out hv_Height);
                    HOperatorSet.SetPart(hw_home, 0, 0, hv_Height - 1, hv_Width - 1);
                    HOperatorSet.DispObj(ReadImage1, hw_home);
                }
            }
           
        }




    }
}
