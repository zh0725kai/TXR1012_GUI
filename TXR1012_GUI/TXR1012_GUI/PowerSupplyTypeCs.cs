using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TXR1012_GUI
{
    class PowerSupplyTypeCs
    {
        /// <summary>
        /// 电源型号规格参数表
        /// </summary>
        public float MaxkV { get; set; }//最高输出电压
        public float MinkV { get; set; }//最低输出电压
        public float MaxmA { get; set; }//最大输出电流
        public float MinmA { get; set; }//最小输出电流
        public float MaxFilLimit { get; set; }//最大灯丝限幅
        public float MinFilLimit { get; set; }//最小灯丝限幅
        public float MaxFilPreHeat { get; set; }//最大灯丝预热电流
        public float MinFilPreHeat { get; set; }//最小灯丝预热电流
        public float MaxPowerVoltage { get; set; }//最高测量供电电压
        public float MinPowerVoltage { get; set; }//最低测量供电电压
        public float MaxTemp { get; set; }//最高测量温度
        public float Minemp { get; set; }//最低测量温度
    }
}
