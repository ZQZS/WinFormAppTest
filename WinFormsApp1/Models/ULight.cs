using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;

namespace WinFormsApp1.Models
{
    internal class ULight : IUsb
    {
        public string? EquipmentName { get ; set; }
        public ULight(string equipmentName) { 
            EquipmentName = equipmentName;
            InsetEquipment();
        }
        public void EquipmentWorking()
        {
            OpenLight();
        }

        public void InsetEquipment()
        {
            MessageBox.Show($"{EquipmentName}设备插入了");
        }
        private void OpenLight()
        {
            MessageBox.Show($"{EquipmentName}设备在工作");
        }
    }
}
