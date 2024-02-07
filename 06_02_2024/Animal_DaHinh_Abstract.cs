using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_02_2024
{
    
     abstract class Animal_DaHinh_Abstract
        {
         public abstract void Speak();
            //{
            //    Console.WriteLine(" Animals is speaking...");
            //}
        }
    
        class Cat : Animal_DaHinh_Abstract
        {
            public override void Speak()
            {
                Console.WriteLine(" Cat is speaking...");
            }
        }
    
        class Dog : Animal_DaHinh_Abstract
        {
            public override void Speak()
            {
                Console.WriteLine(" Dog is speaking...");
            }

        public void info()
        {
             
        }
        }
    
        class Program
        {
            static void Main(string[] args)
            {
             Animal_DaHinh_Abstract cat = new Cat();
             Animal_DaHinh_Abstract dog = new Dog();
    
                cat.Speak();
                dog.Speak();


                Console.ReadKey();
            }
        }
    
}
