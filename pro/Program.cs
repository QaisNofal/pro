using System;

namespace pro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Buddy", 5);
            Cat myCat = new Cat("Whiskers", 3);
            Horse myHorse = new Horse("saki", 8);

           
            myDog.MakeVoice();
            myCat.MakeVoice();
            myHorse.MakeVoice();
        }
    }
}
