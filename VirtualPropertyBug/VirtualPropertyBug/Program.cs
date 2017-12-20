using System;

namespace VirtualPropertyBug
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BaseClass bar = new OverrideClass();

            Console.WriteLine(bar.Foo.ToString());  //"Black"
            //However, when debugging bar.Foo (in immediate or hover) it shows Red
            //Hovering over bar and clicking on property Foo correctly shows Black
        }
    }
}
