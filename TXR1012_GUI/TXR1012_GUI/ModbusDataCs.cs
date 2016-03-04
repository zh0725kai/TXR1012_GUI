using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Modbus;
using Modbus.Device;
using System.IO.Ports;

namespace TXR1012_GUI
{
    class ModbusDataCs
    {
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
        public PowerSupplyTypeCs PowerSupplyType { get; set; }//定义电源型号
        public void ReadAll(byte slaveAddress,SerialPort serialPort1)
        {
            try
            {
                ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(serialPort1);
                serialPort1.Open();
                //ushort startAddress = (ushort)Convert.ToInt16(txtAddress_R.Text.Trim());
                //ushort[] values = master.ReadHoldingRegisters(1, startAddress, 2);
                //ushort[] values = master.ReadInputRegisters(1, startAddress, 2);
                bool[] DI = master.ReadInputs(slaveAddress, 10000, 1);//读取高压开关状态
                HVState = DI[0];
                ushort[] AI = master.ReadHoldingRegisters(slaveAddress, 30000, 2);//读取管电压管电流
                kVRead = (PowerSupplyType.MaxkV- PowerSupplyType.MinkV) *1.2F* ((float)AI[0]/4096);
                mARead = (PowerSupplyType.MaxmA- PowerSupplyType.MinmA)* 1.2F * ((float)AI[1]/4096);

                AI = master.ReadHoldingRegisters(slaveAddress, 30004, 1);//读取灯丝电流
                FilamentRead =10*1.2F* (float)AI[0]/4096;//12A对应4095
                //foreach (var item in values)
                //{
                //    txtVlaue_R.AppendText(item.ToString() + "   ");
                //}
                //bool[] values = master.ReadCoils(slaveAddress, startAddress, 8);

                serialPort1.Close();
                foreach (var item in DI)
                {
                    //txtVlaue_R.AppendText(item.ToString() + "   ");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Write()
        {

        }
    }
}
