using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Abstract
{
    internal abstract class Humant
    {
        public string Name { get; set; }
        public abstract void Move();
        public void Eat()
        {
            MessageBox.Show("需要吃食物补充能量");
        }
    }
    //internal class Humant
    //{
    //    public string wegith { get; set; }
    //    public virtual void Move()
    //    {
    //        MessageBox.Show("正在移动");
    //    }
    //}
}
