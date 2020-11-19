using System;

namespace ObjectPoolDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectPool objectPool = new ObjectPool();

            ReusableObject obj1 = objectPool.GetReusableObject();
            obj1.ChangeData("obj1 data");

            ReusableObject obj2 = objectPool.GetReusableObject();
            obj2.ChangeData("obj2 data");

            ReusableObject obj3 = objectPool.GetReusableObject();
            obj3.ChangeData("obj3 data");

            objectPool.RemoveFromUse(obj3);

            ReusableObject obj3_reused = objectPool.GetReusableObject();
            obj3_reused.PrintData();
        }
    }
}