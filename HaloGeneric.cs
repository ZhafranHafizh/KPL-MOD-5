using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD5_1302210036
{
    internal class HaloGeneric<T>
    {
        public void SapaUser(T Name)
        {
            Console.WriteLine("Hallo user, " + Name);
        }
    }
}
