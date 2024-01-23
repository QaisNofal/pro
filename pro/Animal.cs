using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace pro
{
    public abstract class  Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void MakeVoice();
       

    }

    public class Dog : Animal
    {
     
        public Dog(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

       
        public override void MakeVoice()
        {
            Console.WriteLine($"{this.GetType().Name} says hohoho. Age: {Age}, Name: {Name}");
        }
    }

    public class Cat : Animal
    {
      
        public Cat(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        
        public override void MakeVoice()
        {
            Console.WriteLine($"{this.GetType().Name} says meeaw. Age: {Age}, Name: {Name}");
        }
    }
    }
