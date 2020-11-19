using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    public class Originator
    {

        private string state;
        private Caretaker caretaker;

        public Originator(Caretaker caretaker) { this.caretaker = caretaker; }

        public void SetState(string state) { this.state = state; }
        public string GetState() { return state; }

        public void SetMemento(Memento m) { state = m.GetState(); }

        public Memento CreateMemento() 
        {
            Memento m = new Memento(state);
            caretaker.AddMemento(m);
            return m;
        }
    }
}