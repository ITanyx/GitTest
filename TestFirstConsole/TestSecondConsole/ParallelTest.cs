using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestSecondConsole
{
    public class ParallelTest
    {
        public void Invoke()
        {
            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = 6;

            Parallel.Invoke(options,
                () => { Thread.Sleep(10000); Console.WriteLine("1-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(1500); Console.WriteLine("2-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(3000); Console.WriteLine("3-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(4000); Console.WriteLine("4-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(2500); Console.WriteLine("5-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(1600);Console.WriteLine("6-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(700);Console.WriteLine("7-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(8000);Console.WriteLine("8-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(1900);Console.WriteLine("9-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(3000);Console.WriteLine("10-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(1100);Console.WriteLine("11-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(2200);Console.WriteLine("12-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(1000);Console.WriteLine("13-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(1400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(4400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(2400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(1400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(5400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(4400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(2400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(3400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(1400);Console.WriteLine("14-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); },
                () => { Thread.Sleep(1500); Console.WriteLine("15-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId); }
            );
        }

        public void ForMethod()
        {
            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = 10;

            Parallel.For(0, 10000, (t,state) =>
            {
                if (t > 20)
                {
                    state.Break();
                    return;
                }
                Console.WriteLine("{1}-----------当前线程ID  {0}", Thread.CurrentThread.ManagedThreadId, t);
            });
        }

        public void ForeachMethod()
        {
            List<CommonIDNameModel> list = new List<CommonIDNameModel>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(new CommonIDNameModel() { Id = i + 1, Name = "N_" + i });
            }

            Parallel.ForEach(list,l=>
            {
                l.Id = l.Id + 1;
            });

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class CommonIDNameModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
