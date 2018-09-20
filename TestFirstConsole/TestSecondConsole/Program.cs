using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestSecondConsole
{
    delegate void AsyncFoo(int i);
    class Program
    {
        ///<summary>
        /// 输出当前线程的信息
        ///</summary>
        ///<param name="name">方法名称</param>
        static void PrintCurrThreadInfo(string name)
        {
            Console.WriteLine("Thread Id of " + name + " is: " + Thread.CurrentThread.ManagedThreadId + ", current thread is "
            + (Thread.CurrentThread.IsThreadPoolThread ? "" : "not ")
            + "thread pool thread.");
        }

        ///<summary>
        /// 测试方法，Sleep一定时间
        ///</summary>
        ///<param name="i">Sleep的时间</param>
        static void Foo(int i)
        {
            PrintCurrThreadInfo("Foo()");
            Thread.Sleep(i);
        }

        ///<summary>
        /// 投递一个异步调用
        ///</summary>
        static void PostAsync()
        {
            AsyncFoo caller = new AsyncFoo(Foo);
            caller.BeginInvoke(1000, new AsyncCallback(FooCallBack), caller);
        }

        static void Main(string[] args)
        {
            //TestFirstConsole.Packaging.AccessModifiers a = new TestFirstConsole.Packaging.AccessModifiers();

            //{
            //    PrintCurrThreadInfo("Main()");
            //    for (int i = 0; i < 10; i++)
            //    {
            //        PostAsync();
            //    }
            //}

            //{
            //    ThreadPool.SetMaxThreads(4, 4);
            //    ThreadPool.SetMinThreads(2, 2);
            //    Thread.Sleep(3000);

            //    int maxWorkerThreadCount = 0;
            //    int maxIOThreadCount = 0;
            //    ThreadPool.GetMaxThreads(out maxWorkerThreadCount, out maxIOThreadCount);
            //    Console.WriteLine("最大的工作线程数：" + maxWorkerThreadCount);
            //    Console.WriteLine("最大的IO线程数：" + maxIOThreadCount);

            //    int minWorkerThreadCount = 0;
            //    int minIOThreadCount = 0;
            //    ThreadPool.GetMinThreads(out minWorkerThreadCount, out minIOThreadCount);
            //    Console.WriteLine("最小的工作线程数：" + minWorkerThreadCount);
            //    Console.WriteLine("最小的IO线程数：" + minIOThreadCount);

            //    int canUseWorkerThreadCount = 0;
            //    int canUseIOThreadCount = 0;
            //    ThreadPool.GetAvailableThreads(out canUseWorkerThreadCount, out canUseIOThreadCount);
            //    Console.WriteLine("能用的工作线程数：" + canUseWorkerThreadCount);
            //    Console.WriteLine("能用的IO线程数：" + canUseIOThreadCount);
            //}

            //{
            //    Console.WriteLine("主线程ID：" + Thread.CurrentThread.ManagedThreadId);
            //    Thread thread = new Thread(() =>
            //    {
            //        Thread.Sleep(3000);
            //        Console.WriteLine("子线程ID为：" + Thread.CurrentThread.ManagedThreadId);
            //    });
            //    thread.Start();
            //}

            //{
            //    ParallelTest p = new ParallelTest();
            //    //p.Invoke();
            //    //p.ForMethod();
            //    p.ForeachMethod();
            //}

            //{
            //    using (FileStream fs = File.Create(""))
            //    {
            //        string name = "";
            //        byte[] buffer = System.Text.UTF8Encoding.UTF8.GetBytes(name);
            //        fs.Write(buffer, 0, buffer.Length);
            //        fs.Flush();
            //    }

            //    using (StreamWriter sw=File.AppendText(""))
            //    {
            //        sw.WriteLine("");
            //        sw.Flush();
            //    }
            //}

            {
                //Func<int, int, int> func = (m, n) => m * n + 2;

                //Expression<Func<int, int, int>> expression = (m, n) => m * n + 2;

                //Expression<Func<People, PeopleCopy>> copyFunc = t => new PeopleCopy()
                //{
                //     Id = t.Id,
                //     Name = t.Name,
                //     Age = t.Age
                //};


                //ParameterExpression parameterExpression = Expression.Parameter(typeof(int), "m");
                //ParameterExpression parameterExpression2 = Expression.Parameter(typeof(int), "n");
                //Expression<Func<int, int, int>> expression = Expression.Lambda<Func<int, int, int>>(
                //    Expression.Add(
                //        Expression.Multiply(parameterExpression, parameterExpression2), 
                //        Expression.Constant(2, typeof(int))
                //    ),
                //    new ParameterExpression[]
                //    {
                //        parameterExpression,
                //        parameterExpression2
                //    }
                //);

            }

            {
                //Expression<Func<int, int, int>> expression = (m, n) => m * n + 2 + 3 + Get(m);

                //Expression<Action> expression = () => Convert.ToDouble("123");

                //OperatorVisitor visitor = new OperatorVisitor();
                //visitor.Visit(expression);
            }

            {
                //List<Team> teams = new List<Team>();
                //teams.Add(new Team("teamA", 10, 18));
                //teams.Add(new Team("teamB", 12, 16));
                //teams.Add(new Team("teamC", 8, 18));
                //List<Team> teams2 = new List<Team>() { new Team("teamD", 9, 18) };

                ////inner join 写法1
                //var list1 = teams.Join(teams2, l => l.Score, l => l.Score, (t, o) =>
                //{
                //    return new
                //    {
                //        IName = t.Name,
                //        OName = o.Name,
                //        IScore = t.Score,
                //        OScore = o.Score,
                //        ITimeCost = t.TimeCost,
                //        OTimeCost = o.TimeCost
                //    };
                //});
                //foreach (var item in list1)
                //{
                //    Console.WriteLine(item.IName + "----" + item.OName + "------" + item.ITimeCost + "------" + item.OTimeCost);
                //}

                //Console.WriteLine("*************************************************************");

                ////inner join 写法2
                //var list2 = from t in teams
                //            join o in teams2
                //            on t.Score equals o.Score
                //            select new
                //            {
                //                IName = t.Name,
                //                OName = o.Name,
                //                IScore = t.Score,
                //                OScore = o.Score,
                //                ITimeCost = t.TimeCost,
                //                OTimeCost = o.TimeCost
                //            };
                //foreach (var item in list2)
                //{
                //    Console.WriteLine(item.IName + "----" + item.OName + "------" + item.ITimeCost + "------" + item.OTimeCost);
                //}
            }

            {
                //List<Team> teams = new List<Team>();
                //teams.Add(new Team("teamA", 10, 18));
                //teams.Add(new Team("teamB", 12, 16));
                //teams.Add(new Team("teamC", 8, 18));
                //List<Team> teams2 = new List<Team>() { new Team("teamD", 9, 18) };

                //Console.WriteLine("***************************left join**********************************");
                //var list1 = from t in teams 
                //            join o in teams2
                //            on t.Score equals o.Score into to
                //            from o in to.DefaultIfEmpty()
                //            select new
                //            {
                //                IName = t.Name,
                //                OName = o == null ? "无数据" : o.Name,
                //                IScore = t.Score,
                //                OScore = o == null ? -1 : o.Score,
                //                ITimeCost = t.TimeCost,
                //                OTimeCost = o == null ? -1 : o.TimeCost
                //            };

                //foreach (var item in list1)
                //{
                //    Console.WriteLine(item.IName + "----" + item.OName + "------" + item.ITimeCost + "------" + item.OTimeCost);
                //}

                //Console.WriteLine("***************************right join**********************************");
                //var list2 = from t in teams2
                //            join o in teams
                //            on t.Score equals o.Score into to
                //            from o in to.DefaultIfEmpty()
                //            select new
                //            {
                //                IName = t.Name,
                //                OName = o == null ? "无数据" : o.Name,
                //                IScore = t.Score,
                //                OScore = o == null ? -1 : o.Score,
                //                ITimeCost = t.TimeCost,
                //                OTimeCost = o == null ? -1 : o.TimeCost
                //            };

                //foreach (var item in list2)
                //{
                //    Console.WriteLine(item.IName + "----" + item.OName + "------" + item.ITimeCost + "------" + item.OTimeCost);
                //}
            }

            {
                //List<Team> teams = new List<Team>();
                //teams.Add(new Team("teamA", 10, 18));
                //teams.Add(new Team("teamB", 12, 16));
                //teams.Add(new Team("teamC", 8, 18));
                //List<Team> teams2 = new List<Team>() {
                //    new Team("teamD", 9, 18),
                //    new Team("teamA", 10, 18)
                //};

                //Console.WriteLine("***************************Concat**********************************");

                //var list1 = teams.Concat<Team>(teams2);
                //Console.WriteLine(list1.Count());

                //var list2 = teams.Union(teams2, new MyCompare());

                //try
                //{
                //    int a = int.MaxValue;
                //    unchecked
                //    {
                //        int s = a + 1;
                //        s = s + 1;
                //        s = s + int.MaxValue;
                //        Console.WriteLine(s);
                //        Console.WriteLine("程序不会执行这里");
                //    }
                //}
                //catch (OverflowException ex)
                //{
                //    Console.WriteLine("a溢出");

                //}

                //{
                //    Stopwatch watch = new Stopwatch();
                //    watch.Start();
                //    for (int i = 0; i < 100000000; i++)
                //    {

                //    }
                //    watch.Stop();
                //    Console.WriteLine(watch.ElapsedMilliseconds);
                //}
                {
                    //for (int i = 0; i < 100000; i++)
                    //{
                    //    Task.Run(() =>
                    //    {
                    //        Console.WriteLine(i);
                    //    });
                    //}

                    //ThreadWait w = new ThreadWait();
                    //w.UpdateLockValue();

                    //for (int i = 0; i < 10; i++)
                    //{
                    //    byte[] buffer = Guid.NewGuid().ToByteArray();
                    //    int iSeed = BitConverter.ToInt32(buffer, 0);

                    //    int s = new Random(iSeed).Next(0,16);
                    //    Console.WriteLine(s);
                    //}

                    //AsyncFoo foo = f =>
                    //{
                    //    long result = 0;
                    //    for (int i = 0; i < 1000000000; i++)
                    //    {
                    //        result += i;
                    //    }
                    //    Console.WriteLine(result);
                    //};
                    //AsyncCallback callback = iResult =>
                    //{
                    //    Console.WriteLine(iResult.AsyncState);
                    //};
                    //IAsyncResult asyncResult = foo.BeginInvoke(1, callback, "小林北");

                    //while (!asyncResult.IsCompleted)
                    //{
                    //    Console.WriteLine("请耐心等待...");
                    //    Thread.Sleep(1000);
                    //}

                    //asyncResult.AsyncWaitHandle.WaitOne(3000);

                    //Console.WriteLine("已经完成.");

                    //ManualResetEvent manualResetEvent = new ManualResetEvent(false);
                    //ThreadPool.QueueUserWorkItem(t =>
                    //{
                    //    DoSomethingLong("btnThreadPool_Click");
                    //    manualResetEvent.Set();
                    //    Console.WriteLine("我完成了");
                    //    //manualResetEvent.Reset();
                    //});
                    //manualResetEvent.WaitOne();
                    //Console.WriteLine("我终于可以通行了");

                    //Task.Delay(3000).ContinueWith(t=>
                    //{
                    //    Console.WriteLine($"当前的线程ID={Thread.CurrentThread.ManagedThreadId.ToString("00")}");
                    //});
                    //Console.WriteLine("哈哈哈");

                    //Stopwatch watch = new Stopwatch();
                    //watch.Start();
                    ////Task.Delay(3000).ContinueWith((t, o) =>
                    ////{
                    ////    Console.WriteLine(o);
                    ////    Console.WriteLine(t.AsyncState);
                    ////    watch.Stop();
                    ////    Console.WriteLine(watch.ElapsedMilliseconds);
                    ////}, "123");

                    //Console.WriteLine($"主线程ID：{Thread.CurrentThread.ManagedThreadId}");
                    //Task.Run(() =>
                    //{
                    //    Thread.Sleep(3000);
                    //    Console.WriteLine($"当前线程ID：{Thread.CurrentThread.ManagedThreadId}");
                    //}).ContinueWith((t, o) =>
                    //{
                    //    Console.WriteLine($"回调线程ID：{Thread.CurrentThread.ManagedThreadId}");
                    //    Console.WriteLine(o);
                    //    Console.WriteLine(t.AsyncState);
                    //    watch.Stop();
                    //    Console.WriteLine(watch.ElapsedMilliseconds);
                    //}, "123");
                }

                {
                    //Action<object> act = o =>
                    //{
                    //    Console.WriteLine($"参数：{o},当前线程ID：{Thread.CurrentThread.ManagedThreadId}");
                    //};
                    //act.BeginInvoke("Paramter", c => {
                    //    Console.WriteLine($"标识：{c.AsyncState},当前线程ID：{Thread.CurrentThread.ManagedThreadId}");
                    //}, "Identity");
                }

                {
                    //string[] names1 = new string[] {
                    //    "mahesh","sabnis","manish","sharma","saket","karnik"
                    //};
                    //string[] names2 = new string[] {
                    //    "suprotim","agarwal","vikram","pendse","mahesh","mitkari"
                    //};
                    //HashSet<string> hSetN2 = new HashSet<string>(names2);

                    //HashSet<string> hSetN4 = new HashSet<string>(names1);
                    //Console.WriteLine("_________________________________");
                    //Console.WriteLine("Elements in HashSet before using SymmetricExceptWith");
                    //Console.WriteLine("_________________________________");
                    //Console.WriteLine("HashSet 1");
                    //foreach (var n in hSetN4)
                    //{
                    //    Console.WriteLine(n);
                    //}
                    //Console.WriteLine("HashSet 2");
                    //foreach (var n in hSetN2)
                    //{
                    //    Console.WriteLine(n);
                    //}
                    //Console.WriteLine("_________________________________");
                    //Console.WriteLine("Using SymmetricExceptWith");
                    //Console.WriteLine("_________________________________");
                    //hSetN4.SymmetricExceptWith(hSetN2);
                    //foreach (var n in hSetN4)
                    //{
                    //    Console.WriteLine(n);
                    //}
                }

                {
                    //for (int i = 0; i < 5; i++)
                    //{
                    //    List<Program> programList = null;
                    //    string key = "Query_123";//1 能精确描述这次操作  2 能够重现
                    //    //if (!CustomCache.Exsit(key))
                    //    //{
                    //    //    programList = DBHelper.Query<Program>(123);
                    //    //    //CustomCache.SaveOrUpdate(key, programList);
                    //    //    CustomCache.Add(key, programList);
                    //    //}
                    //    //else
                    //    //{
                    //    //    programList = CustomCache.Get<List<Program>>(key);
                    //    //}
                    //    programList = CustomCache.Find<List<Program>>(key, () => { return DBHelper.Query<Program>(123); });

                    //    //programList = CustomCache.Find<List<Program>>(key, () => DBHelper.Query<Program>(123));
                    //    //Console.WriteLine($"{i}次获取的数据为{programList.GetHashCode()}");
                    //}
                }

                {
                    //DateTime dt = DateTime.Now + System.Runtime.Caching.ObjectCache.NoSlidingExpiration;
                    //Console.WriteLine(dt == DateTime.Now);
                    //Console.WriteLine(System.Runtime.Caching.ObjectCache.NoSlidingExpiration);

                    Console.WriteLine(DateTimeOffset.Now);
                    Console.WriteLine(DateTimeOffset.UtcNow);
                }
            }

            Console.Read();
        }

        /// <summary>
        /// 一个比较耗时耗资源的私有方法
        /// </summary>
        /// <param name="name"></param>
        static void DoSomethingLong(string name)
        {
            Console.WriteLine($"****************DoSomethingLong {name} Start {Thread.CurrentThread.ManagedThreadId.ToString("00")} {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}***************");
            long lResult = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                lResult += i;
            }
            //Thread.Sleep(2000);

            Console.WriteLine($"****************DoSomethingLong {name}   End {Thread.CurrentThread.ManagedThreadId.ToString("00")} {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} {lResult}***************");
        }

        static int Get(int m)
        {
            return m * m;
        }

        static void FooCallBack(IAsyncResult ar)
        {
            PrintCurrThreadInfo("FooCallBack()");
            AsyncFoo caller = (AsyncFoo)ar.AsyncState;
            caller.EndInvoke(ar);
        }
        
    }

    public class ChildrenTask : Task
    {
        public object States { get;}
        
        public ChildrenTask(Action act,object states) : base(act)
        {
            this.States = states;
        }


    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class PeopleCopy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Team
    {
        public Team(string name, int timeCost, int score)
        {
            this.Name = name;
            this.TimeCost = timeCost;
            this.Score = score;
        }

        public string Name
        {
            get;
            private set;
        }

        public int TimeCost
        {
            get;
            private set;
        }

        public int Score
        {
            get;
            private set;
        }

    }

    public class MyCompare : IEqualityComparer<Team>
    {
        public bool Equals(Team x, Team y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(Team obj)
        {
            return base.GetHashCode();
        }
    }
}
