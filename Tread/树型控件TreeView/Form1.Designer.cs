namespace 树型控件TreeView
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("TCP/UDP");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("计算机网络", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("计算机组成原理");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("软件工程", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("销售");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("市场");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("电子商务", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("学校**大学", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点1");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点8";
            treeNode1.Text = "TCP/UDP";
            treeNode2.Name = "节点4";
            treeNode2.Text = "计算机网络";
            treeNode3.Name = "节点5";
            treeNode3.Text = "计算机组成原理";
            treeNode4.Name = "节点2";
            treeNode4.Text = "软件工程";
            treeNode5.Name = "节点6";
            treeNode5.Text = "销售";
            treeNode6.Name = "节点7";
            treeNode6.Text = "市场";
            treeNode7.Name = "节点3";
            treeNode7.Text = "电子商务";
            treeNode8.Name = "节点0";
            treeNode8.Text = "学校**大学";
            treeNode9.Name = "节点1";
            treeNode9.Text = "节点1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(224, 632);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 632);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

