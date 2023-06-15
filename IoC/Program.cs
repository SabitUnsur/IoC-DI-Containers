using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BL b1 = new BL(new DAL());

            b1.GetProducts().ForEach(p =>
            {
                Console.WriteLine($"{p.Id}--{p.Name}--{p.Price}--{p.Stock}") ;
            });
        }
    }
}
