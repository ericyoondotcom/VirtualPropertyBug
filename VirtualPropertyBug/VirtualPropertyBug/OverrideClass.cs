using System;
namespace VirtualPropertyBug
{
    public class OverrideClass : BaseClass
    {

        /*public OverrideClass()
		{
			base.Foo = true;
		}*/

        public override MyEnum Foo { get { return MyEnum.Black; } set { throw new NotImplementedException(); }}
    }
}
