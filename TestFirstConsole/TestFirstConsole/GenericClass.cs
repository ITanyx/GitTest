using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole
{
    //普通类型里面的泛型方法
    public class CommonClass
    {
        private CommonClass()
        {
            Console.WriteLine("调用了类型CommonClass的私有构造函数");
        }

        [return: CustomerAttribute]
        public T Show<T>()
        {
            Console.WriteLine("调用了普通类型CommonClass中的泛型方法");
            return default(T);
        }

        public void HasParamtersMethod(int i)
        {
            Console.WriteLine("调用了普通类型CommonClass中的带参数的普通方法_int");
        }

        public void HasParamtersMethod(string s)
        {
            Console.WriteLine("调用了普通类型CommonClass中的带参数的普通方法_string");
        }

        public void HasParamtersMethod(string s,int i)
        {
            Console.WriteLine("调用了普通类型CommonClass中的带参数的普通方法_string_int");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("调用了普通类型CommonClass中的静态方法");
        }

        private void PrivateMethod(string s, int i, DateTime dt)
        {
            Console.WriteLine("调用了普通类型CommonClass中的私有多参数方法");
        }
    }

    public class GenericSingleClass<T>
    {
        public T Show<S>()
        {
            Console.WriteLine("调用了单个泛型参数的类型GenericSingleClass的泛型方法.");
            return default(T);
        }
    }

    public class GenericMulitClass<T, S, W>
    {
        public void Show1()
        {
            Console.WriteLine("调用了多个泛型参数的类型GenericMulitClass的普通方法.");
        }

        public Z Show2<X,Y,Z>()
        {
            Console.WriteLine("调用了多个泛型参数的类型GenericMulitClass的泛型方法.");
            return default(Z);
        }
    }

    public interface IInterface
    {
        void Show();
    }
}
