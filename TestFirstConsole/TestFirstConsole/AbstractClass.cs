using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole
{
    public abstract class AbstractClass
    {
        public abstract void AbstractMethod();

        public void CommonMethod()
        {
            
            Console.WriteLine("父类的CommonMethod方法");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("父类的VirtualMethod方法");
        }
    }

    public class ChildrenClass : AbstractClass
    {
        public sealed override void AbstractMethod()
        {
            Console.WriteLine($"子类{nameof(ChildrenClass)}的AbstractMethod方法");
        }

        //隐藏普通方法
        public new void CommonMethod()
        {
            Console.WriteLine($"子类{nameof(ChildrenClass)}的CommonMethod方法");
        }

        //隐藏虚方法
        public new virtual void VirtualMethod()
        {
            Console.WriteLine($"子类{nameof(ChildrenClass)}的VirtualMethod方法");
        }
    }

    public class ThirdChildrenClass : ChildrenClass, IInterfaceClass
    {
        public string this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Online()
        {
            throw new NotImplementedException();
        }

        public override void VirtualMethod()
        {
            Console.WriteLine($"子类{nameof(ThirdChildrenClass)}的VirtualMethod方法");
        }
    }
}
