using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Abstract;
using WinFormsApp1.Interfaces;

namespace WinFormsApp1.Models
{
    internal class Person : Humant,IHelper
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }
        public string? Sex { get; set; }
        public int Sou;

        public string Eat()
        {
            //MessageBox.Show($"{Name},{Age}岁，是个{Sex}");
            return $"{Name},{Age}岁，是个{Sex}";
        }
        public void SetSou(int sou)
        {
            Sou = sou;
        }
        public override void Move()
        {
            MessageBox.Show("正在跑");
        }
    }
}
