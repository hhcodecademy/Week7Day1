using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Day1
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }

        public abstract void MakeSound();

        public virtual void Move() {
            Console.WriteLine("animal is moving ");
        }

    }
}
