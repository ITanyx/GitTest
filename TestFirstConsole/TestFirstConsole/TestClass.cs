using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole
{
    public class TestClass
    {
        private TestClass()
        {
            Console.WriteLine("调用构造函数");
        }

        public TestClass(int id,string name)
        {
            Console.WriteLine("调用构造函数,参数id={0},name={1}", id, name);
        }

        public TestClass(string name, int id)
        {
            Console.WriteLine("调用构造函数,参数id={0},name={1}", id, name);
        }

        public void Show()
        {
            Console.WriteLine("This is Method Show.");
        }
    }
}
