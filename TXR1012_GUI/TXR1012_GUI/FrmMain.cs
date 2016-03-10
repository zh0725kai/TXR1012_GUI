using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;

namespace TXR1012_GUI
{
    public partial class FrmMain : Form
    {
        public static SerialPort myserialPort = new SerialPort();
        public static ModbusDataCs MData = new ModbusDataCs();
        public static PowerSupplyTypeCs TXR1012 = new PowerSupplyTypeCs();
        public static Byte SlaveAddress;
        public static DateTime StartDateTime;
        public static DateTime HVStartDataTime;
        public FrmMain()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            //检查是否存在配置文件、读取配置文件。暂时没有这个功能

            //初始化串口

                FrmCOMSet frmComSet = new FrmCOMSet();
                frmComSet.ShowDialog();
            StartDateTime = DateTime.Now;
            //初始化电源参数信息，额定电压、电流等
            TXR1012.MaxFilLimit = 4F;
            TXR1012.MinFilLimit = 0F;
            TXR1012.MaxFilPreHeat = 2.6F;
            TXR1012.MinFilPreHeat = 0F;
            TXR1012.MaxkV = 50F;
            TXR1012.MinkV = 0F;
            TXR1012.MaxmA = 1F;
            TXR1012.MinmA = 0F;
            TXR1012.MaxTemp = 100F;
            TXR1012.MinTemp = -50F;
            TXR1012.MaxPowerVoltage = 43.9F;
            TXR1012.MinPowerVoltage = 0F;

            MData.PowerSupplyType = TXR1012;
            myserialPort.Open();//开机打开串口
            //初始化初始值，读取一次对电源电压和工作温度和状态进行显示
            MData.ReadAll(SlaveAddress, myserialPort);//这个还是有些问题，超时在NModbus里已经有设计 

            #region 初始化输入界面
            //初始输入化界面
            if (MData.ComStateFlag) //  通讯读取成功时
            {
                aGauge_kV.Value = 0F;
                txt_kVSet.Text = aGauge_kV.Value.ToString();
                aGauge_mA.Value = 0F;
                txt_mASet.Text = aGauge_mA.Value.ToString();
                txt_FilPreHeat.Text = 0F.ToString();
                trackBar_FilLimitSet.Value = 0;
                txt_FilLimitSet.Text = trackBar_FilLimitSet.Value.ToString();
                txt_FilPreHeat.Text = ((float)trackBar_FilLimitSet.Value / 10).ToString();
                label_FilLimitHiden.Visible = false;
                label_kV.Text = MData.kVRead.ToString();
                label_mA.Text = MData.mARead.ToString();
                label_Power.Text = MData.PowerVoltageRead.ToString() + "V";
                label_Temp.Text = MData.TempRead.ToString() + "℃";
                label_Filment.Text = MData.FilamentRead.ToString();
                //状态显示初始化
                if (MData.HVState)
                {
                    ovalShape_OpenHV.FillColor = Color.Red;
                    ovalShape_CloseHV.FillColor = Color.Gray;
                }
                else
                {
                    ovalShape_OpenHV.FillColor = Color.Gray;
                    ovalShape_CloseHV.FillColor = Color.Lime;
                }
                label_InterLockOK.BackColor = Color.GreenYellow;
                label_InterLockError.BackColor = Color.Gray;
                label_StateOK.BackColor = Color.GreenYellow;
                label_StateError.BackColor = Color.Gray;
            }
            else //  通讯读取失败时
            {
                aGauge_kV.Value = 0F;
                txt_kVSet.Text = aGauge_kV.Value.ToString();
                aGauge_mA.Value = 0F;
                txt_mASet.Text = aGauge_mA.Value.ToString();
                txt_FilPreHeat.Text = 0F.ToString();
                trackBar_FilLimitSet.Value = 0;
                txt_FilLimitSet.Text = trackBar_FilLimitSet.Value.ToString();
                txt_FilPreHeat.Text = ((float)trackBar_FilLimitSet.Value / 10).ToString();
                label_FilLimitHiden.Visible = false;
                label_kV.Text = "----";
                label_mA.Text = "----";
                label_Power.Text = "----" + "V";
                label_Temp.Text = "----" + "℃";
                label_Filment.Text = "----";
                //状态显示初始化
                //if (MData.HVState)
                //{
                ovalShape_OpenHV.FillColor = Color.Gray;
                ovalShape_CloseHV.FillColor = Color.Gray;
                //}
                //else
                //{
                //    ovalShape_OpenHV.FillColor = Color.Gray;
                //    ovalShape_CloseHV.FillColor = Color.Lime;
                //}
                label_InterLockOK.BackColor = Color.Gray;
                label_InterLockError.BackColor = Color.Gray;
                label_StateOK.BackColor = Color.Gray;
                label_StateError.BackColor = Color.Gray;
            }
            #endregion

            //初始化状态栏
            #region 初始化状态栏
            if (MData.ComStateFlag)
            {
                toolStripStatusLabel_SlaveAddress.Text = "从机地址:" + SlaveAddress.ToString();
                toolStripStatusLabel_ComNum.Text = "串口:" + myserialPort.PortName;
                toolStripStatusLabel_BaudRate.Text = "波特率:" + myserialPort.BaudRate;
                toolStripStatusLabel_RunTime.Text = DateDiff(DateTime.Now, StartDateTime);
            }
            else
            {
                toolStripStatusLabel_SlaveAddress.Text = "请正确设置通讯地址和端口号！";
                toolStripStatusLabel_ComNum.Text = "";
                toolStripStatusLabel_BaudRate.Text = "波特率:" + myserialPort.BaudRate;
                toolStripStatusLabel_RunTime.Text = DateDiff(DateTime.Now,StartDateTime);
            }
            #endregion

            //初始化显示值
        }
        /// <summary>
        /// 求时间差方法
        /// </summary>
        /// <param name="dateBegin">开始时间</param>
        /// <param name="dateEnd">结束时间</param>
        /// <returns>返回(秒)单位，比如: 0.00239秒</returns>
        public static string DateDiff(DateTime dateBegin, DateTime dateEnd)
        {
            TimeSpan ts1 = new TimeSpan(dateBegin.Ticks);
            TimeSpan ts2 = new TimeSpan(dateEnd.Ticks);
            TimeSpan ts3 = ts1.Subtract(ts2).Duration();
            //你想转的格式
            return ts3.ToString("c").Substring(0,8);
        }

        #region 菜单栏单击事件
        private void tsmi_COMSet_Click(object sender, EventArgs e)
        {
            FrmCOMSet frmComSet = new FrmCOMSet();
            frmComSet.ShowDialog();
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();
            //return;
        }

        private void trackBar_FilLimitSet_Scroll(object sender, EventArgs e)
        {
            //label_FilLimitHiden.Visible = true;//不需要了，直接在文本框就显示就好了
            txt_FilLimitSet.Text = ((float)trackBar_FilLimitSet.Value / 10).ToString();
            label_FilLimitHiden.Text = txt_FilLimitSet.Text;
            //label_FilLimitHiden.Visible = false;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            myserialPort.Close();
        }
    }
}
