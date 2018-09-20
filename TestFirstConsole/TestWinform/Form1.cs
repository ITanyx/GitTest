using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Thread thread = new Thread(() =>
            //{
            //    Console.WriteLine("I am begin time {0}",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            //    Thread.Sleep(5000);
            //    Console.WriteLine("I am end time {0}",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            //    Console.WriteLine("*****************************************************************");
            //});
            //thread.IsBackground = true;

            //thread.Start();

            Console.WriteLine("我是主线程begin，线程ID {0}", Thread.CurrentThread.ManagedThreadId);
            //BeginInvokeNoReturn(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("子线程begin，线程ID {0}", Thread.CurrentThread.ManagedThreadId);
            //    Console.WriteLine("子线程end，线程ID {0}", Thread.CurrentThread.ManagedThreadId);
            //}, () =>
            //{
            //    Thread.Sleep(5000);
            //    Console.WriteLine("子线程callback,线程ID {0}", Thread.CurrentThread.ManagedThreadId);
            //});

            Func<int> callback = BeginInvokeWithReturn(() =>
            {
                Console.WriteLine("子线程begin，线程ID {0}", Thread.CurrentThread.ManagedThreadId);
                 Thread.Sleep(5000);
                Console.WriteLine("子线程end，线程ID {0}", Thread.CurrentThread.ManagedThreadId);
                return 12354;
            }, () =>
             {
                 Thread.Sleep(5000);
                 Console.WriteLine("我是callback,线程ID {0}", Thread.CurrentThread.ManagedThreadId);
             });
            Console.WriteLine("这里来了");
            int r = callback.Invoke();

            Console.WriteLine("我是主线程end，线程ID {0}", Thread.CurrentThread.ManagedThreadId);

            //int r = BeginInvokeWithReturn(()=>
            //{
            //    Console.WriteLine("我是一个方法begin，主线程执行,线程ID {0}", Thread.CurrentThread.ManagedThreadId);
            //    Console.WriteLine("我是一个方法end，主线程执行,线程ID {0}", Thread.CurrentThread.ManagedThreadId);
            //    return 1;
            //},()=>
            //{
            //    Thread.Sleep(5000);
            //    Console.WriteLine("我是callback,线程ID {0}", Thread.CurrentThread.ManagedThreadId);
            //});
            //Console.WriteLine(r);
        }

        private void BeginInvokeNoReturn(ThreadStart threadStart,Action act)
        {
            Thread thread = new Thread(()=>
            {
                threadStart.Invoke();
                act.Invoke();
            });
            thread.Start();
        }

        private Func<T> BeginInvokeWithReturn<T>(Func<T> threadStart, Action act)
        {
            T t = default(T);
            Thread thread = new Thread(() =>
            {
                t = threadStart.Invoke();
                act.Invoke();
            });
            thread.Start();

            return new Func<T>(()=>
            {
                thread.Join();
                return t;
            });
        }
    }
}
