using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole.Drawing
{
    /// <summary>
    /// 验证码类
    /// </summary>
    public class DrawVerify
    {
        private static string ImagePath = ConfigurationManager.AppSettings["ImagePath"];

        /// <summary>
        /// 画验证码
        /// </summary>
        public static void Drawing()
        {
            //创建一个画布
            Bitmap bitmap = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(bitmap);
            //创建绘画对象，如Pen,Brush等
            g.Clear(Color.White);
            //绘制图形
            Pen redPen = new Pen(Color.Red, 8);
            g.DrawLine(redPen, 50, 20, 500, 20);
            g.DrawEllipse(Pens.Black, new Rectangle(0, 0, 200, 100));//画椭圆
            g.DrawLine(Pens.Black, 10, 10, 100, 100);//画直线
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, 100, 200));//画矩形
            g.DrawString("我爱北京天安门", new Font("微软雅黑", 12), new SolidBrush(Color.Red), new PointF(10, 10));//画字符串
            //g.DrawImage(

            if (!Directory.Exists(ImagePath))
                Directory.CreateDirectory(ImagePath);

            bitmap.Save(ImagePath + "pic1.jpg", ImageFormat.Jpeg);
            //释放所有对象
            bitmap.Dispose();
            g.Dispose();
        }
    }
}
