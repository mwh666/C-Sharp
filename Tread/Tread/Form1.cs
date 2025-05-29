using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Tread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //存储音乐文件路径的列表
        List<string> musicList = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "请选择音乐文件";
            openFileDialog.InitialDirectory = "C:\\Users\\69138\\Music\\音乐\\";
            //是否全选
            openFileDialog.Multiselect = true;
            //是否显示预览
            openFileDialog.Filter= "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            //获得在文件夹中选择的所有文件的全路径
            string[] path=openFileDialog.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                //将文件名添加到列表框中
                listBox1.Items.Add(Path.GetFileName(path[i]));
                //将全路径添加到列表中
                musicList.Add(path[i]);
            }
        }
        SoundPlayer soundPlayer = new SoundPlayer();
        //实现双击播放事件
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
           
            soundPlayer.SoundLocation = musicList[listBox1.SelectedIndex];
            soundPlayer.Play();

        }
        //点击上一曲
        private void button2_Click(object sender, EventArgs e)
        {
            //将当前索引赋值给index
            int index=listBox1.SelectedIndex;
            index--;
            if (index == -1)
            {
                index = listBox1.Items.Count;
            }
            //将改变后的索引赋值给当前选中的索引,使选中框向上移动
            listBox1.SelectedIndex = index;
            soundPlayer.SoundLocation = musicList[index];
            soundPlayer.Play();

        }

        //点击下一曲
        private void button3_Click(object sender, EventArgs e)
        {
            //获取当前选中的索引
            int index = listBox1.SelectedIndex;
            index++;
            if(index==listBox1.Items.Count)
            {
                index = 0;
            }
            //将改变后的索引赋值给当前选中的索引
            listBox1.SelectedIndex = index;
            soundPlayer.SoundLocation = musicList[index];
            soundPlayer.Play();
            
        }
    }
}
