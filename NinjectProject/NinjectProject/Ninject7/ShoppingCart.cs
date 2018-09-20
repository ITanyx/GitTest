using NinjectProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectProject.Ninject7
{
    public class ShoppingCart
    {
        protected IValueCalculator calculator;
        protected Product[] products;

        //构造函数，参数为实现了IEmailSender接口的类的实例
        public ShoppingCart(IValueCalculator calcParam)
        {
            calculator = calcParam;
            products = new Product[]{
                new Product {Name = "西瓜", Category = "水果", Price = 2.3M},
                new Product {Name = "苹果", Category = "水果", Price = 4.9M},
                new Product {Name = "空心菜", Category = "蔬菜", Price = 2.2M},
                new Product {Name = "地瓜", Category = "蔬菜", Price = 1.9M}
            };
        }

        //计算购物车内商品总价钱
        public virtual decimal CalculateStockValue()
        {
            //计算商品总价钱 
            decimal totalValue = calculator.ValueProducts(products);
            return totalValue;
        }
    }
}
