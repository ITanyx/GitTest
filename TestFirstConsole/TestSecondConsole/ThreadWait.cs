using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestSecondConsole
{
    public class ThreadWait
    {
        public void WaitOneZero()
        {

            {
                Console.WriteLine("正式开始了......");
                Action act = () =>
                {
                    Thread.Sleep(5000);
                    Console.WriteLine("哈哈哈");
                };
                IAsyncResult result = act.BeginInvoke(null, null);

                result.AsyncWaitHandle.WaitOne();//必须等到线程完成

                Console.WriteLine("已经全部完成了。");
            }

        }

        public void WhileWait()
        {
            {
                Action act = () =>
                {
                    Thread.Sleep(5000);
                    Console.WriteLine("哈哈哈");
                };
                IAsyncResult result = act.BeginInvoke(null, null);
                int i = 0;
                while (!result.IsCompleted)
                {
                    i += new Random().Next(1, 8);
                    if (i > 99)
                    {
                        i = 99;
                    }
                    Console.WriteLine("已完成了{0}%......", i);
                    Thread.Sleep(200);
                }
                Console.WriteLine("已经全部完成了。");
            }

        }

        public void WaitMostMilliseconds()
        {

            {
                Console.WriteLine("正式开始了......");
                Action act = () =>
                {
                    Thread.Sleep(5000);
                    Console.WriteLine("哈哈哈");
                };
                IAsyncResult result = act.BeginInvoke(null, null);

                result.AsyncWaitHandle.WaitOne(2000);//最多等待线程2000毫秒

                Console.WriteLine("已经全部完成了。");
            }

        }

        public void EndInvoke()
        {
            {
                Console.WriteLine("正式开始了......");
                Action act = () =>
                {
                    Thread.Sleep(5000);
                    Console.WriteLine("哈哈哈");
                };
                IAsyncResult result = act.BeginInvoke(null, null);

                act.EndInvoke(result);

                Console.WriteLine("已经全部完成了。");
            }

        }

        public void UpdateLockValue()
        {
            int total = 0;
            ConcurrentQueue<Task> list = new ConcurrentQueue<Task>();
            ConcurrentQueue<int> totalList = new ConcurrentQueue<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Enqueue(Task.Run(() =>
                {
                    totalList.Enqueue(1);
                }));
            }

            Task.WaitAll(list.ToArray());

            total = totalList.Sum();
            Console.WriteLine(list.Count);
            Console.WriteLine(total);
        }
    }
}
