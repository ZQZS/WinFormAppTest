using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Interfaces
{
    internal interface IUsb
    {
        /// <summary>
        /// 设备名称
        /// </summary>
        public string EquipmentName { get; set; }
        /// <summary>
        /// 添加时触发
        /// </summary>
        public void InsetEquipment();
        //{
        //    MessageBox.Show($"{EquipmentName}设备插入了");
        //}
        /// <summary>
        /// 工作时方法
        /// </summary>
        public void EquipmentWorking();
        //{
        //    MessageBox.Show($"{EquipmentName}设备在工作");
        //}
    }
}
