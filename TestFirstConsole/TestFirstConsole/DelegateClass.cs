using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole
{
    //1.声明委托
    public delegate void NoReturnNoPara();
    public delegate void NoReturnWithPara(int x, string s);

    public class DelegateClass
    {
        public void Show()
        {
            //2.实例化委托
            NoReturnNoPara delegateNoParaObj = new NoReturnNoPara(this.DoNothing);
            delegateNoParaObj.Invoke();

            NoReturnWithPara delegateWithParaObj = new NoReturnWithPara(this.WithParaNothing);
            delegateWithParaObj.Invoke(2, "sss");




            for (int i = 0; i < 10; i++)
            {
                delegateWithParaObj.BeginInvoke(i, i.ToString(),delegate (IAsyncResult t)
                {
                    Console.WriteLine("当前线程ID:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
                }, "哈哈哈");
            }
        }

        public void DetegateChangeCode()
        {
            //1. 1.0 1.1版本时的写法
            NoReturnWithPara method1 = new NoReturnWithPara(this.WithParaNothing);

            //2.0时的写法
            NoReturnWithPara method2 = new NoReturnWithPara(delegate (int x, string s)
            {
                Console.WriteLine("带参数的方法{0} - {1}", x, s);
            });

            //3.0时的写法
            NoReturnWithPara method3 = new NoReturnWithPara((int x,string s)=>
            {
                Console.WriteLine("带参数的方法{0} - {1}", x, s);
            });

            NoReturnWithPara method4 = new NoReturnWithPara((x,s)=>
            {
                Console.WriteLine("带参数的方法{0} - {1}", x, s);
            });

            NoReturnWithPara method5 = new NoReturnWithPara((x, s) => Console.WriteLine("带参数的方法{0} - {1}", x, s));
            NoReturnWithPara method6 = ((x, s) => {
                Console.WriteLine("带参数的方法{0} - {1}", x, s);
                Console.WriteLine("111");
            });
        }

        public void DoNothing()
        {
            Console.WriteLine("不带参数的方法.");
        }

        public void WithParaNothing(int x,string s)
        {
            Console.WriteLine("带参数的方法{0} - {1}", x, s);
        }
    }
}
