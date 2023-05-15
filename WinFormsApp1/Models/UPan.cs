using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;

namespace WinFormsApp1.Models
{

    internal class UPan : IUsb
    {
        public string? EquipmentName { get; set; }
        public UPan(string? equipmentName)
        {
            EquipmentName = equipmentName;
            InsetEquipment();
        }


        public void EquipmentWorking()
        {
            ReadData();
        }

        public void InsetEquipment()
        {
            MessageBox.Show($"{EquipmentName}设备插入了");
        }
        private void ReadData()
        {
            MessageBox.Show($"{EquipmentName}设备在读取");
        }
    }
}
