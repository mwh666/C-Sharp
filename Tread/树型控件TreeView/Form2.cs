using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 树型控件TreeView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //方法1
            #region
            /* //创建根节点
             TreeNode root = new TreeNode("武汉**学校",0,0);
             //Nodes 节点    将根节点附加到空间上
             this.treeView1.Nodes.Add(root);
             //创建专业的节点
             TreeNode tnPro1 = new TreeNode("计算机技术",0,0);
             TreeNode tnPro2 = new TreeNode("电子商务", 0, 0);
             //将专业节点添加到根节点下，作为子节点
             root.Nodes.Add(tnPro1);
             root.Nodes.Add(tnPro2);

             //创建课程节点
             TreeNode tnPro11 = new TreeNode("计算机技术1",1,1);
             TreeNode tnPro12 = new TreeNode("计算机技术2", 1, 1);
             //添加到专业节点下
             tnPro1.Nodes.Add(tnPro11);
             tnPro1.Nodes.Add(tnPro12);


             TreeNode tnPro21 = new TreeNode("电子商务1",1,1);
             TreeNode tnPro22 = new TreeNode("电子商务2",1,1);
             tnPro2.Nodes.Add(tnPro21);
             tnPro2.Nodes.Add(tnPro22);
 */
            //总的来说，就是新建一个节点  TreeNode x =new TreeNode()
            //然后将其作为根节点或者通过add方法作为子节点




            #endregion

            //方法2  使用键值对的方法直接添加节点

            this.treeView1.Nodes.Add("1", "武汉**学院",0,0);
            this.treeView1.Nodes["1"].Nodes.Add("1.1", "计算机技术",0, 0);
            this.treeView1.Nodes["1"].Nodes.Add("1.2", "电子商务",0, 0);
            this.treeView1.Nodes["1"].Nodes["1.1"].Nodes.Add("1.1.1", "C#",1,1);

            TreeNode x = new TreeNode("java");
            //添加图标
            x.ImageIndex = 0;
            x.SelectedImageIndex = 0;
            x.Name = "javaName";
            this.treeView1.Nodes.Add(x);

            //全部展开
            this.treeView1.ExpandAll();

            //通过对象来删除   (需要先设定一个对象)
           // this.treeView1.Nodes.Remove(x);

            //使用下标来删除  （根据节点的下标）
            //this.treeView1.Nodes[0].Nodes[0].Nodes.RemoveAt(0);

            //通过键值对来删除
            //this.treeView1.Nodes.RemoveByKey("javaName");
            //this.treeView1.Nodes["1"].Nodes.RemoveByKey("1.1");

            
        

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获取当前选中的节点
            TreeNode node =this.treeView1.SelectedNode;

            MessageBox.Show($"{node.Name} , {node.Text}");
        }
    }
}
