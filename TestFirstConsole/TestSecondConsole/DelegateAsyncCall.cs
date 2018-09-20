using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestSecondConsole
{
    //委托的异步调用
    public class DelegateAsyncCall
    {
        public void BeginInvokeCall()
        {
            //委托的异步调用
            Console.WriteLine("***************************************************************");
            {
                Console.WriteLine("主线程ID：" + Thread.CurrentThread.ManagedThreadId);
                Action act = () =>
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("子线程ID为：" + Thread.CurrentThread.ManagedThreadId);
                };
                act.BeginInvoke(c =>
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("回调函数线程ID为：" + Thread.CurrentThread.ManagedThreadId);
                    Console.WriteLine("参数：" + c.AsyncState);
                }, "123456");
            }
        }

        public void ThreadCall()
        {
            //Thread实现委托的异步调用 回调 参数
            Console.WriteLine("***************************************************************");
            {
                Console.WriteLine("主线程ID：" + Thread.CurrentThread.ManagedThreadId);
                ParameterizedThreadStart threadStart = o =>
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("子线程ID为：" + Thread.CurrentThread.ManagedThreadId);
                    new Action(() =>
                    {
                        Thread.Sleep(3000);
                        Console.WriteLine("回调函数线程ID为：" + Thread.CurrentThread.ManagedThreadId);
                        Console.WriteLine("参数：" + o);
                    }).Invoke();
                };
                Thread thread = new Thread(threadStart);
                thread.Start("123456");
            }
        }

        public void ThreadPoolCall()
        {
            //ThreadPool实现委托的异步调用 参数
            Console.WriteLine("***************************************************************");
            {
                Console.WriteLine("主线程ID：" + Thread.CurrentThread.ManagedThreadId);
                ThreadPool.QueueUserWorkItem(o =>
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("子线程ID为：" + Thread.CurrentThread.ManagedThreadId);
                    new Action(() =>
                    {
                        Thread.Sleep(3000);
                        Console.WriteLine("回调函数线程ID为：" + Thread.CurrentThread.ManagedThreadId);
                        Console.WriteLine("参数：" + o);
                    }).Invoke();
                }, "123456");
            }
        }
    }
}
