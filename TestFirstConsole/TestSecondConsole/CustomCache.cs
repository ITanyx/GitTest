using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSecondConsole
{
    /// <summary>
    /// 自定义缓存
    /// </summary>
    public class CustomCache
    {
        /// <summary>
        /// private 保护数据   
        /// static  全局唯一  不释放
        /// Dictionary  保存多项数据
        /// </summary>
        private static Dictionary<string, object> CustomCacheDictionary;
        static CustomCache()
        {
            CustomCacheDictionary = new Dictionary<string, object>();
            Console.WriteLine($"{DateTime.Now.ToString("MM-dd HH:mm:ss fff")}初始化缓存");
            //缓存依托内存，系统重启后，缓存会重启，日志
        }

        /// <summary>
        /// 添加数据  key重复会异常的
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Add(string key, object value)
        {
            CustomCacheDictionary.Add(key, value);
        }

        /// <summary>
        /// 保存数据，有就覆盖 没有就新增
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SaveOrUpdate(string key, object value)
        {
            CustomCacheDictionary[key] = value;
        }

        /// <summary>
        /// 获取数据 没有会异常的
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Get<T>(string key)
        {
            return (T)CustomCacheDictionary[key];
        }

        /// <summary>
        /// 检查是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool Exsit(string key)
        {
            return CustomCacheDictionary.ContainsKey(key);
        }

        public static T Find<T>(string key, Func<T> func)
        {
            T t = default(T);
            if (!Exsit(key))
            {
                t = func.Invoke();
                Add(key, t);
            }
            else
            {
                t = Get<T>(key);
            }

            return t;
        }
    }

    /// <summary>
    /// 数据库查询
    /// </summary>
    public class DBHelper
    {
        public static List<T> Query<T>(int index)
        {
            Console.WriteLine("This is {0} Query", typeof(DBHelper));
            long lResult = 0;
            for (int i = index; i < 1000000000; i++)
            {
                lResult += i;
            }

            return new List<T>()
            {
                default(T),default(T),default(T),default(T)
            };

        }

    }
}
