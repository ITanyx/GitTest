using NinjectProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectProject.Ninject2
{
    public class LinqValueCalculator : IValueCalculator
    {
        public decimal ValueProducts(params Product[] products)
        {
            return products.Sum(p => p.Price);
        }
    }
}
