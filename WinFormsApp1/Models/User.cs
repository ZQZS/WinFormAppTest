using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Interfaces;

namespace WinFormsApp1.Models
{
    class User : IUser
    {
        public int Count { get; set; }
        public string Name { get; set; }

        public User()
        {

        }
        /// <summary>
        /// 这是一个学习测试方法，说你好
        /// </summary>
        /// <param name="i">这个是数字</param>
        public void SayHello(int i)
        {
            /*
             * 
             */
            int x = 1;
            int y = x + 1;
        }
        public void SayHello()
        {
            MessageBox.Show($"{Name} say,hello");
        }
        public void Say()
        {
            SayHello(123);
        }
    }
}
