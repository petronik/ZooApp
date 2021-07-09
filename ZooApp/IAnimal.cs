using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    interface IAnimal
    {
        int Age { get; set; }
        string Species { get;}
        void RequestUniqueCharacteristic();
        void GetDescription();
    }
}
