using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinjectProject.Model;

namespace NinjectProject.Ninject1
{
    public interface IValueCalculator
    {
        decimal ValueProducts(params Product[] products);
    }
}
