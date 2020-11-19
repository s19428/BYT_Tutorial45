using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    public class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();

        public Caretaker() { }

        public void AddMemento(Memento m) { mementos.Add(m); }
        public Memento GetPreviousMemento() { return mementos[mementos.Count - 2]; }
    }
}
