using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Car
    {
        public string Color { get; set; } = "red";
        public double Length { get; set; }

        public void Run()
        {
            MessageBox.Show($"{Color} car {Length} Running");
        }
    }
    public class Truck : Car
    {
        public string Carriage { get; set; }
        public string Freight()
        {
            return Carriage;
        }

    }
    public class SUV : Car
    {
        public string Seat { get; set; }

    }
}
