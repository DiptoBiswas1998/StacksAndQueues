using System;
namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stack and Queue Problem!");
            LinkedList linkedList = new LinkedList();
            linkedList.Enqueue(56);
            linkedList.Enqueue(30);
            linkedList.Enqueue(70);
            linkedList.Display();
        }
    }
}
