using System;

namespace MementoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();
            Originator originator = new Originator(caretaker);
            originator.SetState("state1");
            originator.CreateMemento();
            Console.WriteLine("CurrentState: " + originator.GetState());
            originator.SetState("state2");
            originator.CreateMemento();
            Console.WriteLine("CurrentState: " + originator.GetState());

            originator.SetMemento(caretaker.GetPreviousMemento());
            Console.WriteLine("RolledBackState: " + originator.GetState());
        }
    }
}