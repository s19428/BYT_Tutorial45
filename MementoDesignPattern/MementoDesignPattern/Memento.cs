using System;
using System.Collections.Generic;
using System.Text;

namespace MementoDesignPattern
{
    public class Memento
    {
        private string state;

        public Memento(string state)
        {
            SetState(state);
        }

        public string GetState() { return state; }
        public void SetState(string state) { this.state = state; }
    }
}