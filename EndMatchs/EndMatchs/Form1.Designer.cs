namespace EndMatchs
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.BtnReadImage = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCreateROI = new DevExpress.XtraBars.BarButtonItem();
            this.BtnCreateModel = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMatch = new DevExpress.XtraBars.BarButtonItem();
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(40, 42, 40, 42);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnReadImage,
            this.barButtonItem2,
            this.BtnCreateROI,
            this.BtnCreateModel,
            this.BtnMatch});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 440;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1011, 200);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnReadImage);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnCreateROI);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnCreateModel);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMatch);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // BtnReadImage
            // 
            this.BtnReadImage.Caption = "读取图片";
            this.BtnReadImage.Id = 1;
            this.BtnReadImage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.BtnReadImage.Name = "BtnReadImage";
            this.BtnReadImage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnReadImage_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // BtnCreateROI
            // 
            this.BtnCreateROI.Caption = "划取ROI\r\n";
            this.BtnCreateROI.Id = 3;
            this.BtnCreateROI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.BtnCreateROI.Name = "BtnCreateROI";
            this.BtnCreateROI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCreateROI_ItemClick);
            // 
            // BtnCreateModel
            // 
            this.BtnCreateModel.Caption = "创建模版";
            this.BtnCreateModel.Id = 4;
            this.BtnCreateModel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage1")));
            this.BtnCreateModel.Name = "BtnCreateModel";
            this.BtnCreateModel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnCreateModel_ItemClick);
            // 
            // BtnMatch
            // 
            this.BtnMatch.Caption = "匹配";
            this.BtnMatch.Id = 5;
            this.BtnMatch.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.BtnMatch.Name = "BtnMatch";
            this.BtnMatch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnMatch_ItemClick);
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(0, 200);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(1011, 547);
            this.hWindowControl1.TabIndex = 1;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(1011, 547);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 747);
            this.Controls.Add(this.hWindowControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnReadImage;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem BtnCreateROI;
        private DevExpress.XtraBars.BarButtonItem BtnCreateModel;
        private DevExpress.XtraBars.BarButtonItem BtnMatch;
        private HalconDotNet.HWindowControl hWindowControl1;
    }
}

