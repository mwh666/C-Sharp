namespace DXApplication2
{
    partial class XtraForm2
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "XtraForm2";

            // 添加一个简单的 DevExpress 控件（如按钮）
            var simpleButton = new DevExpress.XtraEditors.SimpleButton();
            simpleButton.Text = "Click Me";
            simpleButton.Location = new System.Drawing.Point(50, 50);
            this.Controls.Add(simpleButton);
        }


        #endregion
    }
}