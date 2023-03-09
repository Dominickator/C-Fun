using System;

namespace sampleCode{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Hey what's your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Oh, cool, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Ok cool, so your name is " + name + " and you are " + age + " years old!");
        }


    }
}