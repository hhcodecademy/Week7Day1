using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7Day1.Enums;

namespace Week7Day1
{
    internal class Dog:Animal
    {
        public DogType Type { get; set; }
        public int Age { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Dog says that Ham-ham");
        }
        public override void Move()
        {
            Console.WriteLine("it qararaq hereket edir");
        }
        public void Eat() {
            Console.WriteLine("dog can be eat meat");

        }
    }
}
