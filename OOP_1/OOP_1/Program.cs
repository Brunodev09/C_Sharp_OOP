using System;

namespace OOP_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Human Bruno = new Human("21", "Bruno");
            Console.WriteLine(Bruno.getAge());
            Bruno.Speak();

            Member mem = new Member(102);
            mem.getID();
        } //destructor will be called here, when we're out of scope, or when the object is deleted
    }
}
