using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Modbus;
using Modbus.Device;
using System.IO.Ports;

namespace TXR1012_GUI
{
    public class ModbusDataCs
    {
        //还有个问题待解决，负极性电压怎么处理表示的？？？？
        /// <summary>
        /// DO[00000]
        /// </summary>
        public bool HVSet { get; set; }//高压开关设定[00000]（0-高压关、1-高压开）
        /// <summary>
        /// DI[10000]
        /// </summary>
        public bool HVState { get; set; }//高压开关状态[10000]（0-高压输出关、1-高压输出开）
        /// <summary>
        /// AI[30000]
        /// </summary>
        public float kVRead { get; set; }//管电压指示：30000（0-4095对应0-120%额定电压，即0-60kV）
        public float mARead { get; set; }//管电流指示：30001（0-4095对应0-120%额定电流，0-1.2mA）
        public float FilamentRead { get; set; }//灯丝电流指示：30004（0-4095对应0-12 A灯丝电流）
        public float TempRead { get; set; }//温度指示：30010（0-4095对应-50℃~100℃）
        public float PowerVoltageRead { get; set; }//电源电压：30012（0-4095对应0-43.9V）
        /// <summary>
        /// AO[40000]
        /// </summary>
        public float kVSet { get; set; }//电压设定：40000（0-4095对应0-100%额定电压，0-50kV）
        public float mASet { get; set; }//电流设定：40001（0-4095对应0-100%额定电流，0-1mA）
        public float FilPreHeatSet { get; set; }//灯丝预热：40004（0-4095对应0-10A,电源限制0-1065有效即0-2.6A）
        public float FilLimitSet { get; set; }//灯丝限制：40005（0-4095对应0-10A,电源限制0-1638有效即0-4A）
        /// <summary>
        /// 电源型号
        /// </summary>
        public PowerSupplyTypeCs PowerSupplyType = new PowerSupplyTypeCs();//定义电源型号
        public bool ComStateFlag { get; set; }//COM开口通讯是否正常的标志
        /// <summary>
        /// 一次读取全部电源信息
        /// </summary>
        /// <param name="slaveAddress">从机地址</param>
        /// <param name="serialPort1">从机连接的串口号</param>
        public void ReadAll(byte slaveAddress,SerialPort serialPort1)
        {
            try
            {
                ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort1);
                //serialPort1.Open(); //开机就打开
                master.Transport.ReadTimeout = 300;//设置端口超时时间，单位ms
                bool[] DI = master.ReadInputs(slaveAddress, 10000, 1);//读取高压开关状态
                HVState = DI[0];
                ushort[] AI = master.ReadInputRegisters(slaveAddress, 30000, 2);//读取管电压管电流
                kVRead = (PowerSupplyType.MaxkV - PowerSupplyType.MinkV) * 1.2F * ((float)AI[0] / 4096);
                mARead = (PowerSupplyType.MaxmA - PowerSupplyType.MinmA) * 1.2F * ((float)AI[1] / 4096);

                AI = master.ReadInputRegisters(slaveAddress, 30004, 1);//读取灯丝电流
                FilamentRead = 10 * 1.2F * (float)AI[0] / 4096;//12A对应4095

                AI = master.ReadInputRegisters(slaveAddress, 30010, 1);//读取温度
                TempRead = (PowerSupplyType.MaxTemp - PowerSupplyType.MinTemp) * (float)AI[0] / 4096;

                AI = master.ReadInputRegisters(slaveAddress, 30012, 1);//读取电源电压
                //TempRead = (PowerSupplyType.MaxPowerVoltage - PowerSupplyType.MinPowerVoltage) * (float)AI[0] / 4096;
                PowerVoltageRead = 43.9F * (float)AI[0] / 4096;
                ComStateFlag = true;
            }
            catch (Exception)
            {
                MessageBox.Show("请检查端口设置","错误提示");
                ComStateFlag = false;
                //throw;
            }

        }
        public void WriteHVSet(byte slaveAddress, SerialPort serialPort1)
        {
            try
            {
                ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort1);
                master.WriteSingleCoil(slaveAddress, 00000, HVSet);//写高压开关，先不做验证是否写成功
                ComStateFlag = true;
            }
            catch (Exception)
            {
                MessageBox.Show("请检查端口设置", "错误提示");
                ComStateFlag = false;
                //throw;
            }
        }
        public void WritekVSet(byte slaveAddress, SerialPort serialPort1)
        {
            try
            {
                ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort1);
                ushort kVSetValue = (ushort)(kVSet * 4096 / PowerSupplyType.MaxkV);
                master.WriteSingleRegister(slaveAddress, 40000, kVSetValue);//写管电压，先不做验证是否写成功
                ComStateFlag = true;
            }
            catch (Exception)
            {
                MessageBox.Show("请检查端口设置", "错误提示");
                ComStateFlag = false;
                //throw;
            }
        }
        public void WritemASet(byte slaveAddress, SerialPort serialPort1)
        {
            try
            {
                ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort1);
                ushort mASetValue = (ushort)(mASet * 4096 / PowerSupplyType.MaxmA);
                master.WriteSingleRegister(slaveAddress, 40001, mASetValue);//写管电流，先不做验证是否写成功
                ComStateFlag = true;
            }
            catch (Exception)
            {
                MessageBox.Show("请检查端口设置", "错误提示");
                ComStateFlag = false;
                //throw;
            }
        }
        public void WriteFilPreHeatSet(byte slaveAddress, SerialPort serialPort1)
        {
            try
            {
                ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort1);
                if (FilPreHeatSet>PowerSupplyType.MaxFilPreHeat)//最大限定
                {
                    FilPreHeatSet = PowerSupplyType.MaxFilPreHeat;
                }
                ushort FilPreHeatSetValue = (ushort)(FilPreHeatSet * 4096 / 10);//4096对应10A
                master.WriteSingleRegister(slaveAddress, 40004, FilPreHeatSetValue);//写管电压，先不做验证是否写成功
                ComStateFlag = true;
            }
            catch (Exception)
            {
                MessageBox.Show("请检查端口设置", "错误提示");
                ComStateFlag = false;
                //throw;
            }
        }
        public void WriteFilLimitSet(byte slaveAddress, SerialPort serialPort1)
        {
            try
            {
                ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort1);
                if (FilLimitSet > PowerSupplyType.MaxFilLimit)//不要超过最大值
                {
                    FilLimitSet = PowerSupplyType.MaxFilLimit;
                }
                ushort FilLimitSetValue = (ushort)(FilLimitSet * 4096 / 10);
                master.WriteSingleRegister(slaveAddress, 40005, FilLimitSetValue);//写管电压，先不做验证是否写成功
                ComStateFlag = true;
            }
            catch (Exception)
            {
                MessageBox.Show("请检查端口设置", "错误提示");
                ComStateFlag = false;
                //throw;
            }
        }
    }
}
