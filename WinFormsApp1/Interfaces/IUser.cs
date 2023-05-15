using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Interfaces
{
    public interface IUser
    {
        public int Count { get; set; }
        void SayHello();
    }
}
