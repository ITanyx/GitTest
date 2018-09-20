using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using firstNinject = NinjectProject.Ninject2;
using secondNinject = NinjectProject.Ninject3;
using thirdNinject = NinjectProject.Ninject4;
using fourNinject = NinjectProject.Ninject5;
using fiveNinject = NinjectProject.Ninject6;
using sixNinject = NinjectProject.Ninject7;
using System.Threading;

namespace NinjectProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***************Ninject2***************");
            //{
            //    //创建Ninject内核实例
            //    IKernel ninjectKernel = new StandardKernel();

            //    //绑定接口到实现了该接口的类
            //    ninjectKernel.Bind<firstNinject.IValueCalculator>().To<firstNinject.LinqValueCalculator>();

            //    // 获得实现接口的对象实例
            //    ninjectKernel.Bind<firstNinject.ShoppingCart>().ToSelf();
            //    firstNinject.ShoppingCart cart = ninjectKernel.Get<firstNinject.ShoppingCart>();

            //    // 计算商品总价钱并输出结果
            //    Console.WriteLine("Total: {0:c}", cart.CalculateStockValue());
            //}

            //Console.WriteLine("***************Ninject3***************");
            //{
            //    //创建Ninject内核实例
            //    IKernel ninjectKernel = new StandardKernel();

            //    //绑定接口到实现了该接口的类
            //    ninjectKernel.Bind<secondNinject.IValueCalculator>().To<secondNinject.LinqValueCalculator>();
            //    ninjectKernel.Bind<secondNinject.IDiscountHelper>().To<secondNinject.DefaultDiscountHelper>();

            //    // 获得实现接口的对象实例
            //    ninjectKernel.Bind<secondNinject.ShoppingCart>().ToSelf();
            //    secondNinject.ShoppingCart cart = ninjectKernel.Get<secondNinject.ShoppingCart>();

            //    // 计算商品总价钱并输出结果
            //    Console.WriteLine("Total: {0:c}", cart.CalculateStockValue());
            //}

            //Console.WriteLine("***************Ninject4***************");
            //{
            //    //创建Ninject内核实例
            //    IKernel ninjectKernel = new StandardKernel();

            //    //绑定接口到实现了该接口的类
            //    ninjectKernel.Bind<thirdNinject.IValueCalculator>().To<thirdNinject.LinqValueCalculator>();
            //    ninjectKernel.Bind<thirdNinject.IDiscountHelper>().To<thirdNinject.DefaultDiscountHelper>()
            //    .WithPropertyValue("DiscountSize", 5M);

            //    // 获得实现接口的对象实例
            //    ninjectKernel.Bind<thirdNinject.ShoppingCart>().ToSelf();
            //    thirdNinject.ShoppingCart cart = ninjectKernel.Get<thirdNinject.ShoppingCart>();

            //    // 计算商品总价钱并输出结果
            //    Console.WriteLine("Total: {0:c}", cart.CalculateStockValue());
            //}

            //Console.WriteLine("***************Ninject5***************");
            //{
            //    //创建Ninject内核实例
            //    IKernel ninjectKernel = new StandardKernel();

            //    //绑定接口到实现了该接口的类
            //    ninjectKernel.Bind<fourNinject.IValueCalculator>().To<fourNinject.LinqValueCalculator>();
            //    ninjectKernel.Bind<fourNinject.IDiscountHelper>().To<fourNinject.DefaultDiscountHelper>()
            //    .WithConstructorArgument("discountParam", 5M);

            //    // 获得实现接口的对象实例
            //    ninjectKernel.Bind<fourNinject.ShoppingCart>().ToSelf();
            //    fourNinject.ShoppingCart cart = ninjectKernel.Get<fourNinject.ShoppingCart>();

            //    // 计算商品总价钱并输出结果
            //    Console.WriteLine("Total: {0:c}", cart.CalculateStockValue());
            //}

            //Console.WriteLine("***************Ninject6***************");
            //{
            //    //创建Ninject内核实例
            //    IKernel ninjectKernel = new StandardKernel();

            //    //绑定接口到实现了该接口的类
            //    ninjectKernel.Bind<fiveNinject.IValueCalculator>().To<fiveNinject.LinqValueCalculator>();
            //    ninjectKernel.Bind<fiveNinject.IDiscountHelper>().To<fiveNinject.DefaultDiscountHelper>()
            //    .WithConstructorArgument("discountParam", 5M);

            //    // 获得实现接口的对象实例
            //    ninjectKernel.Bind<fiveNinject.ShoppingCart>().To<fiveNinject.LimitShoppingCart>().WithPropertyValue("ItemLimit", 3M);
            //    fiveNinject.ShoppingCart cart = ninjectKernel.Get<fiveNinject.ShoppingCart>();

            //    // 计算商品总价钱并输出结果
            //    Console.WriteLine("Total: {0:c}", cart.CalculateStockValue());
            //}

            //Console.WriteLine("***************Ninject7***************");
            //{
            //    //创建Ninject内核实例
            //    IKernel ninjectKernel = new StandardKernel();

            //    //绑定接口到实现了该接口的类
            //    ninjectKernel.Bind<sixNinject.IValueCalculator>().To<sixNinject.LinqValueCalculator>();
            //    ninjectKernel.Bind<sixNinject.IDiscountHelper>().To<sixNinject.DefaultDiscountHelper>()
            //    .WithConstructorArgument("discountParam", 5M);

            //    //派生类绑定
            //    ninjectKernel.Bind<sixNinject.ShoppingCart>().To<sixNinject.LimitShoppingCart>().WithPropertyValue("ItemLimit", 3M);

            //    //条件绑定
            //    ninjectKernel.Bind<sixNinject.IValueCalculator>()
            //        .To<sixNinject.IterativeValueCalculator>().WhenInjectedInto<sixNinject.LimitShoppingCart>();

            //    sixNinject.ShoppingCart cart = ninjectKernel.Get<sixNinject.ShoppingCart>();

            //    // 计算商品总价钱并输出结果
            //    Console.WriteLine("Total: {0:c}", cart.CalculateStockValue());
            //}
            
            Console.Read();
        }
    }
}
