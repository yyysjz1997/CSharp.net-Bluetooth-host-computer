﻿using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using INIFILE;
using System.IO;
using System.Text.RegularExpressions;  //正则表达式类

namespace SerialCommunication
{
    public partial class Form1 : Form
    {
        int Sbitlen;
        int bytesRead;
        int Gbitlen;
        #region 日志记录，在richtextbox中显示不同颜色文字的方法

        public delegate void LogAppendDelegate(Color color, string text);

        //追加显示文本
        public void LogAppend(Color color, string msg)
        {
            txtRcv.SelectionColor = color;
            txtRcv.AppendText(msg);
            txtRcv.AppendText("\n");
        }

        //显示错误信息
        public void LogError(string msg)
        {
            LogAppendDelegate lad = new LogAppendDelegate(LogAppend);
            // Invoke()的作用是：在应用程序的主线程上执行指定的委托。一般应用：在辅助线程中修改UI线程（ 主线程 ）中对象的属性时，调用this.Invoke();
            txtRcv.Invoke(lad,Color.Red,DateTime.Now.ToString("HH:mm:ss ：")+msg);//为了不使线程冲突，需要创建一个委托
        }

        //显示警告信息
        public void LogWarning(string msg)
        {
            LogAppendDelegate lad = new LogAppendDelegate(LogAppend);
            txtRcv.Invoke(lad,Color.Violet,DateTime.Now.ToString("HH:mm:ss ：")+msg);
        }

        //显示信息
        public void LogMessage(string msg)
        {
            LogAppendDelegate lad = new LogAppendDelegate(LogAppend);
            txtRcv.Invoke(lad,Color.Black,DateTime.Now.ToString("HH:mm:ss ：")+msg);
        }
        //发送信息的设置
        public void SendMessage(string msg)
        {
            LogAppendDelegate lad = new LogAppendDelegate(LogAppend);
            txtRcv.Invoke(lad, Color.Green, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ：") + msg);
        }
        //接收信息的设置
        public void RcvMessage(string msg)
        {
            LogAppendDelegate lad = new LogAppendDelegate(LogAppend);
            txtRcv.Invoke(lad, Color.Blue, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ：") + msg);
        }
        #endregion

        SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        #region Form_load 窗口加载
        //窗口加载
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //加载所有
            INIFILE.Profile.LoadProfile();

            // 预置波特率
            switch (Profile.G_BAUDRATE)
            {
                case "300":
                    cbBaudRate.SelectedIndex = 0;
                    break;
                case "600":
                    cbBaudRate.SelectedIndex = 1;
                    break;
                case "1200":
                    cbBaudRate.SelectedIndex = 2;
                    break;
                case "2400":
                    cbBaudRate.SelectedIndex = 3;
                    break;
                case "4800":
                    cbBaudRate.SelectedIndex = 4;
                    break;
                case "9600":
                    cbBaudRate.SelectedIndex = 5;
                    break;
                case "19200":
                    cbBaudRate.SelectedIndex = 6;
                    break;
                case "38400":
                    cbBaudRate.SelectedIndex = 7;
                    break;
                case "115200":
                    cbBaudRate.SelectedIndex = 8;
                    break;
                default:
                    {
                        MessageBox.Show("波特率预置参数错误。", "异常提示信息", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
            }

            //预置波特率
            switch (Profile.G_DATABITS)
            {
                case "5":
                    cbDataBits.SelectedIndex = 0;
                    break;
                case "6":
                    cbDataBits.SelectedIndex = 1;
                    break;
                case "7":
                    cbDataBits.SelectedIndex = 2;
                    break;
                case "8":
                    cbDataBits.SelectedIndex = 3;
                    break;
                default:
                    {
                        MessageBox.Show("数据位预置参数错误。", "异常提示信息", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

            }
            //预置停止位
            switch (Profile.G_STOP)
            {
                case "1":
                    cbStop.SelectedIndex = 0;
                    break;
                case "1.5":
                    cbStop.SelectedIndex = 1;
                    break;
                case "2":
                    cbStop.SelectedIndex = 2;
                    break;
                default:
                    {
                        MessageBox.Show("停止位预置参数错误。", "异常提示信息", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
            }

            //预置校验位
            switch (Profile.G_PARITY)
            {
                case "NONE":
                    cbParity.SelectedIndex = 0;
                    break;
                case "ODD":
                    cbParity.SelectedIndex = 1;
                    break;
                case "EVEN":
                    cbParity.SelectedIndex = 2;
                    break;
                default:
                    {
                        MessageBox.Show("校验位预置参数错误。","异常提示信息",
                            MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
            }

            //检查是否含有串口  
               string[] str = SerialPort.GetPortNames();  
               if (str == null)  
               {  
                   MessageBox.Show("本机没有串口！", "信息提示",
                       MessageBoxButtons.OK,MessageBoxIcon.Information);  
                   return;  
               }  
      
               //添加串口项目  
               foreach (string s in System.IO.Ports.SerialPort.GetPortNames())  
               {
                   //获取有多少个COM口  
                   cbSerial.Items.Add(s);  
               }  
      
               //串口设置默认选择项  
               //设置cbSerial的默认选项  
               cbSerial.SelectedIndex = -1;
               serialPort.BaudRate = 9600;

            //这个类中不检查跨线程的调用是否合法
            /*.NET2.0以后加强了安全机制，不允许在WinForm中直接跨线程访问控件的属性*/
               Control.CheckForIllegalCrossThreadCalls = false;

               serialPort.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);

            //发送和接收格式默认是字符串

               //rbSend16.Checked = true;
               //rbRcv16.Checked = true;

               rbSendStr.Checked = true;
               rbRcvStr.Checked = true;
               btnSendCRC.Enabled = false;

            //设置数据读取超时为1秒
               serialPort.ReadTimeout = 1000;

            //设置编码
               //serialPort.Encoding = System.Text.Encoding.GetEncoding("UTF-8");

            //关闭串口
               serialPort.Close();

              
        }
        #endregion

        #region sp1_DataReceived 处理接收数据
        /// <summary>
        /// 对接收的数据进行处理的方法
        /// </summary>
        void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                if (serialPort.BytesToRead != 0)
                {
                    bytesRead = serialPort.BytesToRead / 2;
                    
                    Gbitlen += bytesRead;
                   // Gbitlen = Gbitlen / 2;
                    Rcvnum.Text = "已接收字节数 " + Gbitlen.ToString() + "个";
                }

                //BytestoRead:sp1接收的字符个数
                byte[] receiveBytes = new byte[serialPort.BytesToRead];
                serialPort.Read(receiveBytes, 0, receiveBytes.Length);
                serialPort.DiscardInBuffer();

                //rdRcvStr:"接收字符串"单选按钮
                if (rbRcvStr.Checked)
                {
                    string receiveStr = ByteToString(receiveBytes);
                    RcvMessage(receiveStr);
                }
                else
                {
                    try
                    {
                        string strRcv = ByteToHex(receiveBytes);
                        RcvMessage(strRcv);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"异常提示信息",
                            MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        txtSend.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("请打开某个串口", "信息提示",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        #endregion

        #region btnClear_Click 清空按钮
        /// <summary>
        /// "清空"按钮事件
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRcv.Text = "";
        }
        #endregion

        #region btnExit_Click 退出按钮
        /// <summary>
        /// "退出"按钮事件
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }
        #endregion

        #region btnSend_Click 发送按钮：处理发送数据
        /// <summary>
        /// 点击“发送按钮”事件
        /// </summary>
        private void btnSend_Click(object sender, EventArgs e)
        {
            //发送前判断串口是否打开
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("请先打开串口！", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtSend.Text))
            {
                MessageBox.Show("请输入发送信息！", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {

                string ComString = txtSend.Text;
                string s2 = ComString;
                s2 = s2.Replace(" ", "");
                Sbitlen += s2.Length / 2;
                send_num.Text = "已发送字节数 " + Sbitlen.ToString() + "个";

                
                    
                //判断cbTimeSend是否被勾选，来决定是否启动Timer控件进行定时发送
                if (cbTimeSend.Checked)
                {
                    timeSend.Enabled = true;
                }
                else
                {
                    timeSend.Enabled = false;
                }

                string strSend = txtSend.Text;

                if (rbSend16.Checked == true)
                {
                    try
                    {
                        //如果以16进制形式发送，将16进制数转换为byte数组进行发送
                        byte[] byteBuffer = HexToByte(strSend);
                        serialPort.Write(byteBuffer, 0, byteBuffer.Length);
                        SendMessage(ByteToHex(byteBuffer));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("16进制数的格式或长度不正确，请检查格式后重新发送。", "信息提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (rbSendStr.Checked == true)
                {
                    //如果以字符串形式发送，将字符串转换为byte数组进行发送
                    byte[] byteBuffer = StringToByte(txtSend.Text);
                    serialPort.Write(byteBuffer, 0, byteBuffer.Length);
                    SendMessage(strSend);
                }
                else
                {
                    MessageBox.Show("请选择数据发送的格式！", "信息提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
        #endregion

        #region timeSend_Tick 定时器Timer
        /// <summary>
        /// 定时发送的定时器Timer
        /// </summary>
        private void timeSend_Tick(object sender, EventArgs e)
        {
            //转换时间间隔
            string strSecond = txtSecond.Text;

            try
            {
                //Interval的单位是ms
                int isecond = int.Parse(strSecond) * 1000;
                timeSend.Interval = isecond;

                if (timeSend.Enabled==true)
                {
                    //如果timeSend空间是可用状态，用按钮的PerformClick()方法生成按钮的点击事件。
                    btnSend.PerformClick();
                }
            }
            catch (Exception ex)
            {
                //若出现异常，就将Timer控件状态设为不可用，然后抛出异常提示
                timeSend.Enabled = false;
                MessageBox.Show("设置的时间间隔格式错误!\n"+ex.Message, "异常提示信息", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region btnSwitch_Click 打开/关闭串口按钮
        /// <summary>
        /// 打开/关闭串口的按钮事件
        /// </summary>
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                try
                {
                    //设置串口号
                    string serialName = cbSerial.SelectedItem.ToString();
                    serialPort.PortName = serialName;

                    //对串口参数进行设置
                    string strBaudRate = cbBaudRate.Text;
                    string strDateBits = cbDataBits.Text;
                    string strStopBits = cbStop.Text;

                    Int32 iBaudRate = Convert.ToInt32(strBaudRate);
                    Int32 iDateBits = Convert.ToInt32(strDateBits);

                    //设置波特率
                    serialPort.BaudRate = iBaudRate;
                    //设置数据位
                    serialPort.DataBits = iDateBits;
                    //设置停止位
                    switch (cbStop.Text)
                    {
                        case "1": serialPort.StopBits = StopBits.One; break;
                        case "1.5": serialPort.StopBits = StopBits.OnePointFive; break;
                        case "2": serialPort.StopBits = StopBits.Two; break;                        
                        default:
                            MessageBox.Show("停止位参数不正确", "异常提示信息", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    //设置校验位
                    switch (cbParity.Text)
                    {
                        case "无": serialPort.Parity = Parity.None; break;
                        case "奇校验": serialPort.Parity = Parity.Odd; break;
                        case "偶校验": serialPort.Parity = Parity.Even; break;
                        default:
                            MessageBox.Show("校验位参数不正确！", "异常提示信息", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }

                    //如果串口为打开状态，就先关闭一下来初始化串口
                    if (serialPort.IsOpen==true)
                    {
                        serialPort.Close();
                    }

                    //状态栏设置
                    tsSpNum.Text = "串口号：" + serialPort.PortName + "|";
                    tsBaudRate.Text = "波特率：" + serialPort.BaudRate + "|";
                    tsDataBits.Text = "数据位：" + serialPort.DataBits + "|";
                    tsStopBits.Text = "停止位：" + serialPort.StopBits + "|";
                    tsParity.Text = "校验位：" + serialPort.Parity + "|";


                    //设置必要的控件为不可用状态
                    SettingControls(0);

                    //打开串口
                    serialPort.Open();
                    //将按钮内容设置为"关闭串口"
                    btnSwitch.Text = "关闭串口";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex.Message, "异常提示信息", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    timeSend.Enabled = false;

                    //设置必要的控件为可用状态
                    SettingControls(1);
                    return;                    
                }
            }
            else
            {
                //状态栏设置
                tsSpNum.Text = "串口号：未指定|";
                tsBaudRate.Text = "波特率：未指定|";
                tsDataBits.Text = "数据位：未指定|";
                tsStopBits.Text = "停止位：未指定|";
                tsParity.Text = "校验位：未指定|";

                //恢复控件功能，设置必要控件为可用状态
                SettingControls(1);

                //关闭串口
                serialPort.Close();

                //设置按钮内容为"打开串口"
                btnSwitch.Text = "打开串口";

                //关闭计时器Timer
                timeSend.Enabled = false;
            }
        }
        #endregion

        #region Form1_FormClosing 程序窗口关闭事件
        /// <summary>
        /// 程序窗口关闭时的事件
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //保存配置到INI文件，关闭打开的串口
            INIFILE.Profile.SaveProfile();
            serialPort.Close();
        }
        #endregion

        #region btnSave_Click 保存设置按钮
        /// <summary>
        /// "保存设置"按钮点击事件
        /// </summary>        
        private void btnSave_Click(object sender, EventArgs e)
        {
            //设置各"串口设置"
            string strStopBits = cbStop.Text;
            Int32 iBaudRate = Convert.ToInt32(cbBaudRate.Text);
            Int32 iDataBits = Convert.ToInt32(cbDataBits.Text);

            //保存波特率设置
            Profile.G_BAUDRATE = iBaudRate + "";
            //保存数据位设置
            Profile.G_DATABITS = iDataBits + "";
            //保存停止位设置
            switch (cbStop.Text)
            {
                case "1": Profile.G_STOP = "1"; break;
                case "1.5": Profile.G_STOP = "1.5"; break;
                case "2": Profile.G_STOP = "2"; break;
                default:
                    MessageBox.Show("停止位参数不正确", "异常提示信息", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
            //保存校验位设置
            switch (cbParity.Text)
            {
                case "无": Profile.G_PARITY = "NONE"; break;
                case "奇校验": Profile.G_PARITY = "ODD"; break;
                case "偶校验": Profile.G_PARITY = "EVEN"; break;
                default:
                    MessageBox.Show("校验位参数不正确", "异常提示信息", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

            //保存设置
            Profile.SaveProfile();

            //保存成功提示
            MessageBox.Show("设置保存成功！","信息提示",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        #endregion

        #region txtSend_KeyPress 发送框输入校验
        /// <summary>
        /// 对发送框的输入进行校验
        /// </summary>
        private void txtSend_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbSend16.Checked == true)
            {
                //正则匹配,\b表示退格键（对16进制的输入进行格式校验）
                string pattern = "[0-9a-fA-F]|\b|0x|0X| ";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(e.KeyChar.ToString());

                if (match.Success)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = false;
            }
        }
        #endregion

        #region txtSecond_KeyPress 定时输入校验
        /// <summary>
        /// 对定时输入的时间进行校验
        /// </summary>
        private void txtSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            string pattern = "[0-9]|\b";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(e.KeyChar.ToString());

            if (match.Success)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Method ByteToHex and HexToByte Byte字节数组、Hex16进制和字符串之间转换的方法

        //byte字节数组转16进制
        private string ByteToHex(byte[] comByte)
        {
            StringBuilder builder = new StringBuilder(comByte.Length * 3);

            foreach (byte data in comByte)
            {
                builder.Append(Convert.ToString(data,16).PadLeft(2,'0').PadRight(3,' '));
            }
            return builder.ToString().ToUpper();
        }

        //16进制转字节数组
        private byte[] HexToByte(string msg)
        {
            msg = msg.Replace(" ", "");
            msg = msg.Replace("0x", "");
            msg = msg.Replace("0X", "");

            byte[] comBuffer = new byte[msg.Length / 2];

            for (int i = 0; i < msg.Length; i+=2)
            {
                comBuffer[i / 2] = (byte)Convert.ToByte(msg.Substring(i, 2), 16);
            }
            return comBuffer;
        }

        //字符串转字节型数组
        private byte[] StringToByte(string msgtxt)
        {
            return System.Text.Encoding.UTF8.GetBytes(msgtxt);
        }

        //字节型数组转字符串
        private string ByteToString(byte[] buffer)
        {
            return System.Text.Encoding.UTF8.GetString(buffer);
        }
        #endregion

        #region rbSend16_CheckedChanged 发送方式改变时清空原来的输入框

        //当发送方式发生变化时更改cbSendHex的可用状态并清空当前发送框的内容
        private void rbSend16_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSend16.Checked==true)
            {
                cbSendHex.Enabled = false;
                btnSendCRC.Enabled = true;
                txtStrTo16.Text = "";
            }
            else
            {
                cbSendHex.Enabled = true;
                btnSendCRC.Enabled = false;
            }
            txtSend.Text = "";
        }
        #endregion

        #region Method SettingControls 设置控件可用状态的方法
        //用于设置控件的可用状态，canUse 参数-> 1：可用  0：不可用
        private void SettingControls(int canUse)
        {
            if (canUse==1)
            {
                cbSerial.Enabled = true;
                cbBaudRate.Enabled = true;
                cbDataBits.Enabled = true;
                cbStop.Enabled = true;
                cbParity.Enabled = true;
            }
            else if(canUse==0)
            {
                cbSerial.Enabled = false;
                cbBaudRate.Enabled = false;
                cbDataBits.Enabled = false;
                cbStop.Enabled = false;
                cbParity.Enabled = false;
            }
        }
        #endregion

        #region 用于将输入框的字符串实时翻译为16进制
        //用于监听cbSendHex按钮的状态
        private void cbSendHex_CheckedChanged(object sender, EventArgs e)
        {
            //如果cbSendHex按钮选中就翻译发送框的内容
            if (cbSendHex.Checked==true)
            {
                txtStrTo16.Text = ByteToHex(StringToByte(txtSend.Text));
            }
            else
            {
                txtStrTo16.Text = "";
            }
        }

        //用于监听txtSend的文本输入，如果txtSend内容发生变化，txtStrTo16实时将字符串翻译为16进制
        private void txtSend_TextChanged(object sender, EventArgs e)
        {
            if (cbSendHex.Checked == true&&rbSend16.Checked==false)
            {
                txtStrTo16.Text = ByteToHex(StringToByte(txtSend.Text));
            }
        }
        #endregion

        private void btnSendCRC_Click(object sender, EventArgs e)
        {
            //发送前判断串口是否打开
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("请先打开串口！", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //判断cbTimeSend是否被勾选，来决定是否启动Timer控件进行定时发送
            if (cbTimeSend.Checked)
            {
                timeSend.Enabled = true;
            }
            else
            {
                timeSend.Enabled = false;
            }

            if (rbSend16.Checked == true)
            {
                try
                {
                    //如果以16进制带CRC校验形式发送，调用ModbusCRC16的方法将16进制字符串转换为带CRC的字节数组
                    byte[] byteBuffer=ModbusCRC16.getSendBuf(txtSend.Text);

                    serialPort.Write(byteBuffer, 0, byteBuffer.Length);

                    SendMessage(ByteToHex(byteBuffer));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("16进制数的格式或长度不正确，请检查格式后重新发送。\n"+ex.Message, "信息提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("请选择数据发送的格式！", "信息提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void txtRcv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRcv_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("波特率预置参数错误。", "异常提示信息",
                            //MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cbTimeSend_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel2.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("demo_try.txt");
            string text = sr.ReadToEnd();//这个是把文件从头读到结尾
            sr.Close();
            //txtSend.Text += "\r\n";
            txtSend.Text += text;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSend.Text = "";
        }

        private void Enter_Press(object sender, KeyPressEventArgs e)
        {
            //发送前判断串口是否打开
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("请先打开串口！", "提示信息",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //判断cbTimeSend是否被勾选，来决定是否启动Timer控件进行定时发送
            if (cbTimeSend.Checked)
            {
                timeSend.Enabled = true;
            }
            else
            {
                timeSend.Enabled = false;
            }

            string strSend = txtSend.Text;

            if (rbSend16.Checked == true)
            {
                try
                {
                    //如果以16进制形式发送，将16进制数转换为byte数组进行发送
                    byte[] byteBuffer = HexToByte(strSend);
                    serialPort.Write(byteBuffer, 0, byteBuffer.Length);
                    SendMessage(ByteToHex(byteBuffer));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("16进制数的格式或长度不正确，请检查格式后重新发送。", "信息提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (rbSendStr.Checked == true)
            {
                //如果以字符串形式发送，将字符串转换为byte数组进行发送
                byte[] byteBuffer = StringToByte(txtSend.Text);
                serialPort.Write(byteBuffer, 0, byteBuffer.Length);
                SendMessage(strSend);
            }
            else
            {
                MessageBox.Show("请选择数据发送的格式！", "信息提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_Save.Text))
                {
                    MessageBox.Show("请输入保存文件的文件名！", "信息提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string TxtName = txt_Save.Text + ".txt";
                    StreamWriter sw = File.CreateText(@TxtName);
                    sw.WriteLine(txtRcv.Text);
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("已保存！", "信息提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                          
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的文件名！", "信息提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sbitlen = 0;
            send_num.Text = "已发送字节数 " + "0" + "个";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bytesRead = 0;
            Gbitlen = 0;
            Rcvnum.Text = "已接收字节数 " + "0" + "个";
        }

        private void txt_Save_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            Info.FileName = "notepad.exe ";//"calc.exe"为计算器，"notepad.exe"为记事本
            System.Diagnostics.Process Proc = System.Diagnostics.Process.Start(Info);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            Info.FileName = "calc.exe ";//"calc.exe"为计算器，"notepad.exe"为记事本
            System.Diagnostics.Process Proc = System.Diagnostics.Process.Start(Info);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

