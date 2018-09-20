using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole
{
    public class DirectoryClass
    {
        private static string filder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToLower(), "Log");
        private static string newFilder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToLower(), "NewLog");

        //文件夹移动
        public static void Move()
        {
            if (!Directory.Exists(filder))
            {
                Directory.CreateDirectory(filder);
            }

            if (Directory.Exists(filder))
            {
                Directory.Move(filder, newFilder);
            }
                
        }

        //写入文件
        public static void WriterFileMethod1(string writerContent)
        {
            string fileName = Path.Combine(newFilder, "1.txt");
            using (FileStream fileStream = File.Create(fileName))
            {
                byte[] buffer = System.Text.UTF8Encoding.UTF8.GetBytes(writerContent);
                fileStream.Write(buffer, 0, buffer.Length);
                fileStream.Flush();
            }
        }

        //写入文件
        public static void WriterFileMethod2(string writerContent)
        {
            string fileName = Path.Combine(newFilder, "2.txt");
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(writerContent);
                sw.Flush();
            }
        }

        //读取文件所有内容
        public static void ReadAllText()
        {
            string fileName = Path.Combine(newFilder, "2.txt");
            string readAllTxt = File.ReadAllText(fileName);
            Console.WriteLine(readAllTxt);
        }

        //读取文件所有内容
        public static void ReadLines()
        {
            string fileName = Path.Combine(newFilder, "2.txt");
            IEnumerable<string> list = File.ReadLines(fileName);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        //读取文件所有内容
        public static void ReadAllLines()
        {
            string fileName = Path.Combine(newFilder, "2.txt");
            string[] list = File.ReadAllLines(fileName);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        //读取文件所有内容
        public static void ReadAllBytes()
        {
            string fileName = Path.Combine(newFilder, "2.txt");
            byte[] buffer = File.ReadAllBytes(fileName);
            string readAllTxt = System.Text.UTF8Encoding.UTF8.GetString(buffer);
            Console.WriteLine(readAllTxt);
        }

        //读大文件
        public static void ReadBigFile()
        {
            string fileName = Path.Combine(newFilder, "2.txt");
            //分批读取
            using (FileStream stream = File.OpenRead(fileName))
            {
                int length = 5;
                int result = 0;

                do
                {
                    byte[] bytes = new byte[length];
                    result = stream.Read(bytes, 0, 5);
                    for (int i = 0; i < result; i++)
                    {
                        Console.WriteLine(bytes[i].ToString());
                    }
                } while (length == result);
            }
        }

        public static void WriteLog(string msg)
        {
            string fileName = Path.Combine(newFilder, "3.txt");
            StreamWriter sw = File.AppendText(fileName);
            sw.WriteLine(msg);
            sw.Flush();
            sw.Dispose();
            sw.Close();
        }
    }
}
