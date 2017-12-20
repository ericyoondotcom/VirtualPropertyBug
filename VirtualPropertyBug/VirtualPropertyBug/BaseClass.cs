using System;
namespace VirtualPropertyBug
{

    public abstract class BaseClass
    {
		public enum MyEnum
		{
			Red,
			Black
		}
        public virtual MyEnum Foo { get; set; }


    }
}
