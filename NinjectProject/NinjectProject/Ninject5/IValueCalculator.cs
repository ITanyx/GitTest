using NinjectProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectProject.Ninject5
{
    public interface IValueCalculator
    {
        decimal ValueProducts(params Product[] products);
    }
}
