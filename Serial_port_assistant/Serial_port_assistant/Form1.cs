using DevExpress.Utils.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Localization.XtraLocalizerTraceSource;

namespace Serial_port_assistant
{
    public partial class Form1 : Form
    {
        private bool isOpen = false;
        private bool isRxshow = true;
        //建立接收缓存区  List可动态变化（优于数组）
        private List<byte> reciveBuffer=new List<byte>();
        //计数接收到的数据
        private int reciveCount=0;
        //定义一个发送缓存区
        private List<byte> sendBuffer=new List<byte>();
        //发送量计数
        private int sendCount = 0;
        //声明一个队列
        private Queue<byte> bufferQueue = null;
        private bool isHeadRecive = false;
        //缓存帧长度
        private int frameLength = 0;
        //将串口接受的数据在子窗体显示。新建一个委托
        public TransmitData transmitData;

        public event TransmitEventHandler transitData2;
        string strRead;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; // 允许跨线程调用控件
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //定义默认显示的参数
        private void serial_show()
        {
            

            port_cbb.Items.Clear();
            //获取系统的串口  System.IO.Ports.SerialPort表示串口类，GetPortName()获得串口名
            string[] sort = System.IO.Ports.SerialPort.GetPortNames();
            //遍历加入到port_cbb中
            foreach (string s in sort)
            {
                port_cbb.Items.Add(s);
            }
            this.port_cbb.SelectedIndex =0 ;
            this.baud_cbb.SelectedIndex = 1;
            this.check_cbb.SelectedIndex = 0;
            this.databit_cbb.SelectedIndex = 3;
            this.stopbit_cbb.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serial_show();
            //实例化
            bufferQueue=new Queue<byte>();
            //实例化form2
            Form2 form2 = new Form2();
            //窗体1发送委托，窗体2的ReceiveData方法执行
            transmitData = form2.ReciveData;
            //事件的形式
            transitData2+=new TransmitEventHandler(form2.ReciveData2);
            //窗体2发送委托，窗体1的sendBytes方法执行
            form2.userForm1Send = sendBytes;
            form2.userForm1Send2 += new TransmitEventHandler(sendByte2);
            form2.Show();

        }

        private void sendByte2(object sender, TransimitEventAgrs s)
        {
            serialPort1.Write(s.data.ToArray(), 0, s.data.Length);
            sendCount += s.data.Length;
            sencount_tssl.Text = sendCount.ToString();
        }

        private void sendBytes(byte[] data)
        {
            serialPort1.Write(data.ToArray(), 0, data.Length);
            sendCount += data.Length;
            sencount_tssl.Text = sendCount.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void open_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    //设定串口参数
                    serialPort1.PortName = port_cbb.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baud_cbb.Text);
                    serialPort1.DataBits = Convert.ToInt32(databit_cbb.Text);
                    //typeof(System.IO.Ports.Parity)表示枚举类型System.IO.Ports.Parity
                    //Enum.Parse将字符串转换为枚举值。即是把check_cbb.Text转换为System.IO.Ports.Parity类型的枚举值
                    // (System.IO.Ports.Parity)Enum.Parse()将 Enum.Parse 返回的对象强制转换为 Parity 枚举类型
                    serialPort1.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), check_cbb.Text);
                    serialPort1.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), stopbit_cbb.Text);

                    serialPort1.Open();
                    isOpen = true;
                    open_btn.Text = "关闭串口";
                    state_tssl.Text= $"关闭{serialPort1.PortName}串口成功";
                }
                else
                {
                    serialPort1.Close();
                    isOpen = false;
                    open_btn.Text = "打开串口";
                    state_tssl.Text = $"打开{serialPort1.PortName}串口成功";
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()+serialPort1.PortName.ToString());
            }
        }

        private void sendData()
        {
            serialPort1.Write(sendBuffer.ToArray(),0,sendBuffer.Count);
            sendCount += sendBuffer.Count;
            sencount_tssl.Text=sendCount.ToString();
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            if (send_rtxb.Text != "" && serialPort1.IsOpen)
            {
                Console.WriteLine(Transform.ToHexString(sendBuffer.ToArray()));
                sendData();
            }
            else
            {
                MessageBox.Show("请先打开串口或输入要发送的内容");
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (isRxshow == false) return;
            //获得串口数据的字节
            byte[] dataTemp = new byte[serialPort1.BytesToRead];
            //读取串口数据
            serialPort1.Read(dataTemp,0,dataTemp.Length);
            //将串口数据添加到缓存区中
            reciveBuffer.AddRange(dataTemp);
            //计数得到的数据
            reciveCount += dataTemp.Length;

            //?.是空值条件运算符，表示如果 transmitData 不为 null，则调用它的 Invoke 方法，否则不执行任何操作。
            transmitData?.Invoke(dataTemp); //调用子窗体的接收数据方法
            transitData2?.Invoke(this,new TransimitEventAgrs { data=dataTemp });
            this.Invoke(new EventHandler(delegate
            {
                //更新状态栏的接收计数
                recivecount_tssl.Text = reciveCount.ToString();
                if (dataZhen_chb.Checked==false)
                {
                    if (!shiliu_chb.Checked)
                    {
                        //将串口接收到的字节数据（dataTemp）转换为字符串，并显示在界面上的文本框.GB2312可以显示中文
                        string str = Encoding.GetEncoding("gb2312").GetString(dataTemp);
                        //0x00 ——>\0结束符，不会显示
                        //•	将字符串中的 \0（空字符，ASCII 0，常作为结束符）替换为可见的 \\0，
                        //这样在界面上也能看到原本不可见的结束符，方便调试和观察数据内容。
                        str = str.Replace("\0", "\\0");
                        receive_rteb.AppendText(str);

                    }
                    else
                    {
                        //当选中十六进制
                        receive_rteb.AppendText(Transform.ToHexString(dataTemp, " "));
                    }
                }
                else
                {
                     //解析数据
                     //数据到队列的添加
                     foreach (byte item in dataTemp)
                    {
                        bufferQueue.Enqueue(item);

                    }
                     //解析获取帧头
                    if (isHeadRecive ==false)
                    {
                        //判断队列是否从帧头开始
                        foreach(byte item in bufferQueue.ToArray())
                        {
                            if (item != 0x7f)
                            {
                                //出列
                                bufferQueue.Dequeue();
                                Console.WriteLine("not 0x7f,Dequeue");
                            }
                            else
                            {
                                isHeadRecive = true; //标记已经接收到帧头
                                Console.WriteLine("0x7f,Is Recive");
                                break;
                            }
                        }
                    }

                    //如果已经接收到帧头
                    if (isHeadRecive == true)
                    {
                        //判断有数据帧长度
                        if (bufferQueue.Count >= 2)
                        {
                            //解析
                            Console.WriteLine(DateTime.Now.ToLongTimeString());
                            Console.WriteLine($"show the data in bufferQueue{Transform.ToHexString(bufferQueue.ToArray())}");
                            Console.WriteLine($"frame length ={String.Format("{0:X2}", bufferQueue.ToArray()[1])}");
                            frameLength = bufferQueue.ToArray()[1];
                        }
                        //没有就继续接收数据
                        //一帧完整的数据长度判断，不代表数据是正确的
                        //帧头+数据长度+数据+crc校验
                        if (bufferQueue.Count >= 1 + 1 + frameLength+2)
                        {
                            byte[] frameBuffer=new byte[1 + 1 + frameLength + 2];
                            Array.Copy(bufferQueue.ToArray(),0,frameBuffer,0,frameBuffer.Length);
                            if (crc_chech(frameBuffer))
                            {
                                Console.WriteLine("frame is check ok,pick it");
                                data_txb.Text=Transform.ToHexString(frameBuffer);
                                data1_txb.Text = String.Format("{0:X2}", frameBuffer[2]);
                                data2_txb.Text = String.Format("{0:X2}", frameBuffer[3]);
                                data3_txb.Text = String.Format("{0:X2}", frameBuffer[4]);
                                data4_txb.Text = String.Format("{0:X2}", frameBuffer[5]);
                            }
                            else
                            {
                                //无效数据
                                Console.WriteLine("bad frame ,drop it");

                            }
                            for (int i = 0; i < 1+1+frameLength+2; i++)
                            {
                                bufferQueue.Dequeue();
                            }
                            isHeadRecive = false;
                        }
                    }
                }
            }));

        }

        private bool crc_chech(byte[] frameBuffer)
        {
            bool ret = false;
            byte[] temp = new byte[frameBuffer.Length - 2];
            Array.Copy(frameBuffer, 0, temp, 0, temp.Length);
            byte[] crcdata=DataCheck.DataCrc16_Ccitt(temp,DataCheck.BigOrLittle.BigEndian);
            if (crcdata[0]== frameBuffer[frameBuffer.Length - 2] && crcdata[1]==frameBuffer[frameBuffer.Length-1])
            {
                ret= true;
            }
            return ret;
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            if (isRxshow == true)
            {
                isRxshow = false;
                stop_btn.Text = "继续";
            }
            else
            {
                isRxshow = true;
                stop_btn.Text = "暂停";
            }
        }

        private void shiliu_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (receive_rteb.Text == "")
            {
                return;
            }
            if (shiliu_chb.Checked)
            {
                receive_rteb.Text=Transform.ToHexString(reciveBuffer.ToArray(), " ");
            }
            else
            {
                receive_rteb.Text=Encoding.GetEncoding("GB2312").GetString(reciveBuffer.ToArray()).Replace("\0","\\0");
            }
           
            
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            reciveBuffer.Clear();
            recivecount_tssl.Text = "";
            receive_rteb.Text = "0";
            reciveCount = 0;


        }

        private void autoclear_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (autoclear_chb.Checked)
            {
                timer1.Start();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (receive_rteb.Text.Length > 4096)
            {
                reciveBuffer.Clear();
                receive_rteb.Text = "";
                recivecount_tssl.Text= "";
                reciveCount = 0;
            }
        }

        private void send_rtxb_Leave(object sender, EventArgs e)
        {
            if (sendshiliu_chb.Checked)
            {
                if (DataEncoding.IsHexString(send_rtxb.Text.Replace("\0", "\\0")))
                {
                    sendBuffer.Clear();
                    sendBuffer.AddRange(Transform.ToBytes(send_rtxb.Text.Replace("\0", "\\0")));
                }
                else
                {
                    MessageBox.Show("请输入正确的十六进制数据");
                    //光标回到窗体
                    send_rtxb.Select();
                }
            }
            else
            {
                sendBuffer.Clear();
                //将发送的字符串转换为字节数组
                sendBuffer.AddRange(Encoding.GetEncoding("GB2312").GetBytes(send_rtxb.Text));
            }
        }

        private void send_rtxb_TextChanged(object sender, EventArgs e)
        {
            //如果发送的内容是十六进制,会出现0x00转换

        }

        private void sendshiliu_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (send_rtxb.Text == "")
            {
                return;
            }
            if (sendshiliu_chb.Checked)
            {
                send_rtxb.Text = Transform.ToHexString(sendBuffer.ToArray()," ");
            }
            else
            {
                send_rtxb.Text = Encoding.GetEncoding("gb2312").GetString(sendBuffer.ToArray()).Replace("\0","\\0");
            }
        }

        private void receive_rteb_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearsend_btn_Click(object sender, EventArgs e)
        {
            sendBuffer.Clear();
            send_rtxb.Text = "";
            sendCount = 0;
            sencount_tssl.Text = "0";
        }

        private void autosend_chb_CheckedChanged(object sender, EventArgs e)
        {
            //串口未打开
            if (serialPort1.IsOpen == false&&autosend_chb.CheckState==CheckState.Checked)
            {
                autosend_chb.CheckState = CheckState.Unchecked;
                if (timer2 != null)
                {
                    timer2.Enabled = false;
                    timer2.Stop();
                    timer2 = null;
                }
                MessageBox.Show("发送失败，请先打开串口");
                return;
            }
            //串口打开，启动定时发送
            if (serialPort1.IsOpen == true && autosend_chb.CheckState == CheckState.Checked)
            {
                autotimer_teb.Enabled = false;
                send_btn.Enabled = false;
                int i=Convert.ToInt32(autotimer_teb.Text);
                if (i < 10 || i > 60 * 1000)
                {
                    i = 1000;
                    autotimer_teb.Text = "1000"; //设置默认值
                    MessageBox.Show("自动发送时间间隔必须在10毫秒到60秒之间，已设置为1000毫秒","警告");
                }
                timer2.Interval = i;
                timer2.Start();

            }
            //如果串口关闭
            else
            {
                send_btn.Enabled = true;
                autotimer_teb.Enabled = true;
                if (timer2 != null)
                {
                    timer2.Stop();
                    timer2 = null;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (send_rtxb.Text != "" && serialPort1.IsOpen)
            {
                Console.WriteLine(Transform.ToHexString(sendBuffer.ToArray()));
                sendData();
            }
            else
            {
                state_tssl.Text=("请先打开串口或输入要发送的内容");
                Console.WriteLine("请先打开串口或输入要发送的内容");
            }
        }

        private void clearcount_Click(object sender, EventArgs e)
        {
            //清除接收计数和发送计数
            sendCount = 0;
            sendBuffer.Clear();
            sencount_tssl.Text = "0";

            reciveBuffer.Clear();
            receive_rteb.Text = "";
            recivecount_tssl.Text = "0";
        }

        private void DTR_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (DTR_chb.CheckState == CheckState.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void RTS_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (RTS_chb.CheckState == CheckState.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void xzlj_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbFialog=new FolderBrowserDialog();
            if(fbFialog.ShowDialog() == DialogResult.OK)
            {
                receiveflie_txb.Text = fbFialog.SelectedPath;

            }
        }

        private void bcsj_btn_Click(object sender, EventArgs e)
        {
            if(receive_rteb.Text=="")
            {
                return;
            }
            string fileName=receiveflie_txb.Text+"\\"+DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(receive_rteb.Text);
            sw.Flush();
            sw.Close();
            MessageBox.Show("保存成功！文件名为：" + fileName, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //加载文本到发送框
        private void openflie_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Title = "请选择文件";
            ofDialog.Filter = "文本文件 (*.txt)|*.txt";
            ofDialog.RestoreDirectory = true;
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                //读取文件内容
                string filePath = ofDialog.FileName;
                sendflie_teb.Text = filePath;
                StreamReader sr=new StreamReader(filePath, Encoding.GetEncoding("GB2312"));
                strRead=sr.ReadToEnd();
                send_rtxb.Text = strRead;
                sr.Close();
                
            }
        }

        private void sendflie_btn_Click(object sender, EventArgs e)
        {
            if (strRead == "")
            {
                MessageBox.Show("请先选择文件");
                return;
            }
            try
            {
                Byte[] data=Encoding.GetEncoding("GB2312").GetBytes(strRead);
                sendCount += data.Length;
                sencount_tssl.Text = sendCount.ToString();
                int pagenum = data.Length / 4096;
                int remaind = data.Length % 4096;
                for(int i = 0; i < pagenum; i++)
                {
                    serialPort1.Write(data, i * 4096, 4096);
                    Thread.Sleep(10);

                }
                if (remaind>0)
                {
                    serialPort1.Write(data, pagenum * 4096, remaind);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("发送失败，请检查串口是否打开或文件内容是否正确！\n" + //
                    ex.Message.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
    }
}
