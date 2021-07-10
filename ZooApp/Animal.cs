﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Animal
    {
        public int Age { get; set; }
        public string Species => GetType().Name.ToLower();

        public void SetAge()
        {
            Console.WriteLine("How old is it?");
            Age = Int32.Parse(Console.ReadLine());
        }
    }
}
