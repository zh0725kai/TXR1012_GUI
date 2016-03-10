using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TXR1012_GUI
{
    public partial class FrmCOMSet : Form
    {
        public FrmCOMSet()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            //FrmMain.myserialPort.BaudRate = Convert.ToInt32(this.cbo_BaudRate.Text.Trim());
            List<string> comNumList = new List<string>();//创建集合存储端口
            comNumList.AddRange(SerialPort.GetPortNames());//获取所有存在的串口号
            List<int> comNum = new List<int>();//存放端口数值
            foreach (string item in comNumList)//
            {
                comNum.Add(Convert.ToInt32(item.Substring(3)));//去除端口号前面的字符，只保留数字并转换值类型
            }
            comNum.Sort();//值类型排序
            //comNumList.Sort();//字符类型的排序存在问题，比COM10和COM2顺序不对
            foreach (int item in comNum)//把串口号赋值给下拉框并在前面加上COM字符
            {
                this.cbo_COMNum.Items.Add("COM" + item.ToString());//
            }
            cbo_COMNum.SelectedIndex = 0;

            cbo_Parity.Items.Add(Parity.None);
            cbo_Parity.Items.Add(Parity.Odd);
            cbo_Parity.Items.Add(Parity.Even);
            cbo_Parity.SelectedIndex = 0;

            cbo_StopBit.Items.Add(StopBits.None);
            cbo_StopBit.Items.Add(StopBits.One);
            cbo_StopBit.Items.Add(StopBits.Two);
            cbo_StopBit.Items.Add(StopBits.OnePointFive);
            cbo_StopBit.SelectedIndex = 1;


        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            FrmMain.myserialPort.PortName = cbo_COMNum.Text.Trim();
            FrmMain.myserialPort.BaudRate = Convert.ToInt32(cbo_BaudRate.Text.Trim());
            FrmMain.myserialPort.Parity = (Parity)cbo_Parity.SelectedIndex;
            FrmMain.myserialPort.StopBits = (StopBits)cbo_StopBit.SelectedIndex;
            FrmMain.myserialPort.DataBits = Convert.ToInt32(cbo_DataBits.Text.Trim());
            //验证txt_SlaveAddress为数字

                try
                {
                    FrmMain.SlaveAddress =(Byte)int.Parse(txt_SlaveAddress.Text.Trim());//从机地址要本文框验证才行
                }
                catch (Exception)
                {
                    MessageBox.Show("请输入正确的从机地址！地址为纯数字","提示！");
                    return;
                }
           
            this.Close();
        }

        private void btn_AdvanceSet_Click(object sender, EventArgs e)
        {
            cbo_DataBits.Enabled = true;
            cbo_Parity.Enabled = true;
            cbo_StopBit.Enabled = true;
            txt_SlaveAddress.Enabled = true;
        }
    }
}
