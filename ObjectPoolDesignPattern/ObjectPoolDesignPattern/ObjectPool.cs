using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectPoolDesignPattern
{
    public class ObjectPool
    {
        private List<ReusableObject> inPool = new List<ReusableObject>();
        private List<ReusableObject> inUse = new List<ReusableObject>();

        public ObjectPool() { }

        public void RemoveFromUse(ReusableObject reusableObject) 
        {
            inUse.Remove(reusableObject);
            reusableObject.SetDefault();
            inPool.Add(reusableObject);

            reusableObject.isActive = false;

            Console.WriteLine("Object removed from use");
        }

        public ReusableObject GetReusableObject() 
        {
            if (inPool.Count > 0)
            {
                ReusableObject obj = inPool[0];
                inPool.RemoveAt(0);
                inUse.Add(obj);
                obj.isActive = true;
                return obj;
            }
            // if no objects are in pool at the moment
            {
                ReusableObject obj = new ReusableObject();
                inUse.Add(obj);
                obj.isActive = true;
                return obj;
            }
        }
    }
}