using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7Day1.Enums;

namespace Week7Day1
{
    internal class Snake:Animal
    {
        public PoisonType Type { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Snake says that Fssss, fsss");
        }
        
    }
}
