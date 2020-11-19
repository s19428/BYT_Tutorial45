using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPoolDesignPattern
{
    public class ReusableObject
    {
        public ReusableObject() { SetDefault(); }

        string data = "";

        public bool isActive = false;

        public void SetDefault() { data = "default"; }

        public void ChangeData(string data)
        {
            CheckIsActive();
            this.data = data;
            PrintData();
        }

        public void PrintData()
        {
            CheckIsActive();
            Console.WriteLine("data: " + data);
        }
        private void CheckIsActive()
        {
            if (!isActive)
                throw new Exception("Trying to use inactive reusable object!!!");
        }
    }
}