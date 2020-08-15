using System;
using System.Collections.Generic;
using System.Text;

namespace singletondemo
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        private static int ObjectsCount = 0;
        public static Singleton GetInstance
        {
            get
            {
                return lazy.Value;
            }
        }


        private Singleton()
        {
            ObjectsCount++;
            Console.WriteLine($"instances {ObjectsCount}");
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}
