using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Diagnostics;
using System.Collections;
using TestFirstConsole.EventStandard;
using TestFirstConsole.Drawing;
using System.Dynamic;
using System.Linq.Expressions;

namespace TestFirstConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            //{
            //    Assembly assembly = Assembly.Load("TestFirstConsole");//加载dll路径的名称
            //    Type type = assembly.GetType("TestFirstConsole.TestClass");//获取类型信息
            //    object obj = Activator.CreateInstance(type);//创建对象
            //    TestClass testClass = (TestClass)obj;//类型转换
            //    testClass.Show();//调用方法
            //}

            //{
            //    Assembly assembly = Assembly.Load("TestFirstConsole");//加载dll路径的名称
            //    Type type = assembly.GetType("TestFirstConsole.TestClass");//获取类型信息
            //    object obj = Activator.CreateInstance(type);//创建对象
            //    MethodInfo showMethod = type.GetMethod("Show");
            //    showMethod.Invoke(obj, null);
            //}

            //#region 反射调用带参数的构造函数
            //{
            //    Assembly assembly = Assembly.Load("TestFirstConsole");//加载dll路径的名称
            //    Type type = assembly.GetType("TestFirstConsole.TestClass");//获取类型信息
            //    object obj = Activator.CreateInstance(type, new object[] { 3, "哈哈哈" });//创建对象
            //    MethodInfo showMethod = type.GetMethod("Show");
            //    showMethod.Invoke(obj, null);
            //}
            //#endregion

            //#region 反射调用普通类型中的泛型方法
            //{
            //    Assembly assembly = Assembly.Load("TestFirstConsole");//加载dll路径的名称
            //    Type type = assembly.GetType("TestFirstConsole.CommonClass");//获取类型信息
            //    object obj = Activator.CreateInstance(type,true);//创建对象
            //    MethodInfo showMethod = type.GetMethod("Show");
            //    MethodInfo showNewMethod = showMethod.MakeGenericMethod(new Type[] { typeof(string) });
            //    object oValue = showNewMethod.Invoke(obj, null);
            //}
            //#endregion

            //#region 反射调用泛型类中的泛型方法
            //{
            //    Assembly assembly = Assembly.Load("TestFirstConsole");//加载dll路径的名称
            //    Type type = assembly.GetType("TestFirstConsole.GenericSingleClass`1");//获取类型信息
            //    Type genericType = type.MakeGenericType(new Type[] { typeof(string) });
            //    object obj = Activator.CreateInstance(genericType);//创建对象
            //    MethodInfo showMethod = genericType.GetMethod("Show");
            //    MethodInfo showNewMethod = showMethod.MakeGenericMethod(new Type[] { typeof(int) });
            //    object oValue = showNewMethod.Invoke(obj, null);
            //}
            //#endregion

            //#region 反射调用泛型类中的泛型方法
            //{
            //    Assembly assembly = Assembly.Load("TestFirstConsole");//加载dll路径的名称
            //    Type type = assembly.GetType("TestFirstConsole.GenericMulitClass`3");//获取类型信息
            //    Type genericType = type.MakeGenericType(new Type[] { typeof(string), typeof(int), typeof(DateTime) });
            //    object obj = Activator.CreateInstance(genericType);//创建对象
            //    MethodInfo showMethod1 = genericType.GetMethod("Show1");
            //    MethodInfo showMethod2 = genericType.GetMethod("Show2");
            //    MethodInfo showNewMethod = showMethod2.MakeGenericMethod(new Type[] { typeof(int),typeof(string),typeof(DateTime) });
            //    object oValue1 = showMethod1.Invoke(obj, null);
            //    object oValue2 = showNewMethod.Invoke(obj, null);
            //}
            //#endregion

            //#region 反射调用普通类型中的带参数的普通方法
            //{
            //    Assembly assembly = Assembly.Load("TestFirstConsole");//加载dll路径的名称
            //    Type type = assembly.GetType("TestFirstConsole.CommonClass");//获取类型信息
            //    object obj = Activator.CreateInstance(type);//创建对象
            //    MethodInfo showMethod = type.GetMethod("HasParamtersMethod", new Type[] { typeof(string), typeof(int) });
            //    object oValue = showMethod.Invoke(obj, new object[] { "哈哈哈" , 5 });
            //}
            //#endregion

            //#region 反射调用普通类型中的静态方法
            //{
            //    Assembly assembly = Assembly.Load("TestFirstConsole");//加载dll路径的名称
            //    Type type = assembly.GetType("TestFirstConsole.CommonClass");//获取类型信息
            //    MethodInfo showMethod = type.GetMethod("StaticMethod");
            //    object oValue = showMethod.Invoke(null, null);
            //}
            //#endregion

            //#region 反射调用普通类型中的私有构造函数
            //{
            //    Assembly assembly = Assembly.Load("TestFirstConsole");//加载dll路径的名称
            //    Type type = assembly.GetType("TestFirstConsole.CommonClass");//获取类型信息
            //    object obj = Activator.CreateInstance(type, true);
            //    MethodInfo showMethod = type.GetMethod("HasParamtersMethod", new Type[] { typeof(string), typeof(int) });
            //    object oValue = showMethod.Invoke(obj, new object[] { "哈哈哈", 5 });
            //}
            //#endregion

            //#region 反射调用普通类型中的重载方法
            //{
            //    Assembly assembly = Assembly.Load("TestFirstConsole");//加载dll路径的名称
            //    Type type = assembly.GetType("TestFirstConsole.CommonClass");//获取类型信息
            //    object obj = Activator.CreateInstance(type, true);

            //    //调用重载方法 两个参数
            //    MethodInfo showMethodStringInt = type.GetMethod("HasParamtersMethod", new Type[] { typeof(string), typeof(int) });
            //    object oValueStringInt = showMethodStringInt.Invoke(obj, new object[] { "哈哈哈", 5 });

            //    //调用重载方法 一个int参数 
            //    MethodInfo showMethodInt = type.GetMethod("HasParamtersMethod", new Type[] {  typeof(int) });
            //    object oValueInt = showMethodInt.Invoke(obj, new object[] {5 });

            //    //调用重载方法 一个string参数
            //    MethodInfo showMethodString = type.GetMethod("HasParamtersMethod", new Type[] { typeof(string) });
            //    object oValueString = showMethodString.Invoke(obj, new object[] { "哈哈哈" });
            //}
            //#endregion

            //#region 反射调用普通类型中的私有方法带多个参数
            //{
            //    Assembly assembly = Assembly.Load("TestFirstConsole");//加载dll路径的名称
            //    Type type = assembly.GetType("TestFirstConsole.CommonClass");//获取类型信息
            //    object obj = Activator.CreateInstance(type, true);

            //    //调用重载方法 两个参数
            //    MethodInfo showMethod = type.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[] { typeof(string), typeof(int), typeof(DateTime) }, null);
            //    object oValue = showMethod.Invoke(obj, new object[] { "哈哈哈", 5, DateTime.Now });
            //}
            //#endregion

            //#region 反射调用接口
            //{
            //    Assembly assembly = Assembly.Load("TestFirstConsole");//加载dll路径的名称
            //    Type type = assembly.GetType("TestFirstConsole.IInterface");//获取类型信息

            //    foreach (var item in assembly.GetModules())
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}
            //#endregion

            //#region 静态缓存与本地缓存比较
            //{
            //Stopwatch watch1 = new Stopwatch();
            //watch1.Start();
            //for (int i = 0; i < 1000000; i++)
            //{
            //    GenericCache.GetList();
            //}
            //watch1.Stop();
            //Console.WriteLine(watch1.ElapsedMilliseconds);

            //List<string> setList = new List<string>();
            //for (int i = 0; i < 10000; i++)
            //{
            //    setList.Add(i.ToString());
            //}
            //CacheHelper.SetCache("localCache", setList);
            //Stopwatch watch2 = new Stopwatch();
            //watch2.Start();
            //for (int i = 0; i < 1000000; i++)
            //{
            //    CacheHelper.GetCache("localCache");
            //}
            //watch2.Stop();
            //Console.WriteLine(watch2.ElapsedMilliseconds);
            //}
            //#endregion

            //#region mvc实体模型验证
            //{
            //Student student = new Student()
            //{
            //    Age = 20,
            //    Id = 1,
            //    Name = "",
            //    QQ = 999
            //};

            //DateValidateModel dateValid = new DateValidateModel();
            //if (!dateValid.Validate<Student>(student))
            //{
            //    foreach (var item in dateValid.ErrorDictionary)
            //    {
            //        Console.WriteLine("{0} - {1}", item.Key, item.Value);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("success");
            //}
            //}
            //#endregion

            //#region 泛型
            //{
            //    GenericList<int> list = new GenericList<int>();
            //    for (int i = 0; i < 10; i++)
            //    {
            //        list.AddHead(i);
            //    }
            //    foreach (var item in list)
            //    {
            //        Console.WriteLine(item + " ");
            //    }
            //    Console.WriteLine("\nDone");
            //}
            //#endregion

            //#region new关键字的用法 
            //{
            //AbstractClass absChildren = new ChildrenClass();
            ////调用隐藏的普通方法 - 调用父类AbstractClass
            //absChildren.CommonMethod();
            ////调用隐藏的虚方法 - 调用父类AbstractClass
            //absChildren.VirtualMethod();
            ////调用抽象方法 - 调用子类
            //absChildren.AbstractMethod();

            //AbstractClass absThirdChildren = new ThirdChildrenClass();
            ////调用隐藏的普通方法 1
            //absThirdChildren.CommonMethod();
            ////调用隐藏的虚方法 1 
            //absThirdChildren.VirtualMethod();
            ////调用抽象方法 2
            //absThirdChildren.AbstractMethod();

            //ThirdChildrenClass thirdChildren = new ThirdChildrenClass();
            //thirdChildren.VirtualMethod();

            //ChildrenClass childrenClass = new ChildrenClass();
            //childrenClass.VirtualMethod();
            //}
            //#endregion

            //#region 委托
            //{
            //    DelegateClass d = new DelegateClass();
            //    d.Show();
            //}
            //#endregion

            //#region 委托的标准事件
            //{
            //    EventRegister e = new EventRegister();
            //    EventRegister e2 = new EventRegister();
            //    int s = e.s;
            //    e.Init();

            //    Console.WriteLine("***********************请输入*****************************");
            //    Console.WriteLine("退出：Exit");
            //    string input = Console.ReadLine();
            //    while (input.ToLower() != "exit")
            //    {
            //        decimal money = 0;
            //        if (!decimal.TryParse(input, out money))
            //        {
            //            Console.WriteLine("输入错误，请重新输入.");
            //            Console.WriteLine("***********************请输入*****************************");
            //            Console.WriteLine("退出：Exit");
            //            input = Console.ReadLine();
            //            continue;
            //        }

            //        e.SetPrice(money);
            //        Console.WriteLine("***********************请输入*****************************");
            //        Console.WriteLine("退出：Exit");
            //        input = Console.ReadLine();
            //        continue;
            //    }
            //}
            //#endregion

            //#region IO操作
            //{
            //    // DirectoryClass.Move();
            //    for (int i = 0; i < 3; i++)
            //    {
            //        DirectoryClass.WriterFileMethod1("哈哈,我是方法1  " + i);
            //    }
            //    for (int i = 0; i < 3; i++)
            //    {
            //        DirectoryClass.WriterFileMethod2("哈哈,我是方法2  " + i);
            //    }

            //    //DirectoryClass.ReadAllText();
            //    //DirectoryClass.ReadAllBytes();
            //    //DirectoryClass.ReadAllLines();
            //    //DirectoryClass.ReadLines();
            //    //DirectoryClass.ReadBigFile();
            //    DirectoryClass.WriteLog("卧似一张弓。");
            //    DirectoryClass.WriteLog("站似一颗松。");
            //}
            //#endregion

            //#region 画验证码
            //{
            //    DrawVerify.Drawing();
            //}
            //#endregion

            //string str = "我是人";
            //byte[] buffer = System.Text.ASCIIEncoding.UTF8.GetBytes(str);
            //string base64String = Convert.ToBase64String(buffer);
            //byte[] byte64Buffer = Convert.FromBase64String(base64String);
            //string base64Str = System.Text.ASCIIEncoding.UTF8.GetString(byte64Buffer);
            //Console.WriteLine(base64Str);


            //IEnumerable<int> list1 = OriginalEnumerableMethod();
            //IEnumerable<int> list2 = YieldEnumerableMethod();
            //foreach (var item in list1)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> list3 = list1.ToList();
            //IEnumerable<int> list4 = new List<int>();
            //IEnumerable<int> list5 = null;

            //Stopwatch watch1 = new Stopwatch();
            //watch1.Start();
            //try
            //{
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        list3.Find(l => l == 3);
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
            //watch1.Stop();
            //Console.WriteLine("watch1=" + watch1.ElapsedMilliseconds);

            //Stopwatch watch2 = new Stopwatch();
            //watch2.Start();
            //try
            //{
            //    for (int i = 0; i < 1000000; i++)
            //    {
            //        list3.FirstOrDefault(l => l == 3);
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
            //watch2.Stop();
            //Console.WriteLine("watch2=" + watch2.ElapsedMilliseconds);

            //Func<int, int, int> func = (m, n) => m * n + n;
            //Expression<Func<int, int, int>> exp = (m, n) => m * n + n;
            //Func<int,int,int> func2 = exp.Compile();

            //ParameterExpression parameterExpression = Expression.Parameter(typeof(int), "m");
            //ParameterExpression parameterExpression2 = Expression.Parameter(typeof(int), "n");
            //Expression<Func<int, int, int>> expression = Expression.Lambda<Func<int, int, int>>
            //(
            //    Expression.Add(
            //       Expression.Multiply(parameterExpression, parameterExpression2),
            //       parameterExpression2
            //    ),
            //    parameterExpression,
            //    parameterExpression2
            //);

            Expression<Func<People, bool>> lambda = x => x.Id.ToString().Equals("5");
            //var result = lambda.Compile().Invoke(new People()
            //{
            //    Id = 5,
            //    Age = 1,
            //    Name = "流浪的人在外想念你"
            //});

            ParameterExpression parameterExpression = Expression.Parameter(typeof(People), "x");
            MemberExpression memberExpression = Expression.Property(parameterExpression, "Id");
            MethodInfo methodInfo = typeof(People).GetMethod("ToString");
            MethodInfo methodInfo2 = typeof(People).GetMethod("Equals", BindingFlags.Static |  BindingFlags.IgnoreCase | BindingFlags.NonPublic); //(MethodInfo)MethodBase.GetMethodFromHandle(ldtoken(Equals()));
           

            MethodCallExpression callExpression1 = Expression.Call(memberExpression, methodInfo, new Expression[0]);
            MethodCallExpression callExpression2 = Expression.Call(callExpression1, methodInfo2,
                new Expression[]
                {
                    Expression.Constant("5", typeof(string))
                });

            Expression<Func<People, bool>> expression = Expression.Lambda<Func<People, bool>>(callExpression2,
            new ParameterExpression[]
            {
                parameterExpression
            });
            var r = expression.Compile().Invoke(
                new People()
                {
                    Id = 6,
                    Age = 1,
                    Name = "流浪的人在外想念你"
                });
            
            //ParameterExpression parameterExpression = Expression.Parameter(typeof(People), "x");
            //Expression<Func<People, bool>> lambda2 = Expression.Lambda<Func<People, bool>>();

            Console.Read();
        }

        //原始集合方法
        static IEnumerable<int> OriginalEnumerableMethod()
        {
            List<int> results = new List<int>();
            int counter = 0;
            int result = 1;

            while (counter++ < 10)
            {
                result = result * 2;
                results.Add(result);
            }
            return results;
        }

        //Yield方法
        static IEnumerable<int> YieldEnumerableMethod()
        {
            List<int> results = new List<int>();
            int counter = 0;
            int result = 1;

            while (counter++ < 10)
            {
                result = result * 2;
                yield return result;
            }
        }

        static void TryCatchFinally()
        {
            SqlTransaction tran = null;
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //SqlCommand cmd = new SqlCommand("",conn);
                    conn.Open();
                    tran = conn.BeginTransaction();

                    string s = null;
                    s = s.ToString();

                    tran.Commit();
                }
            }
            catch (Exception ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            {

            }
        }
    }

    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public static class EnumerableExtend
    {
        public static TSource MyFirst<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentException("source");
            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                if (list.Count > 0) return list[0];
            }
            else
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    if (e.MoveNext()) return e.Current;
                }
            }
            throw new Exception("不存在");
        }
    }
}
