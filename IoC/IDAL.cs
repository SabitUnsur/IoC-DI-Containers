using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public interface IDAL
    {
        List<Product> GetProducts();

        int Hesapla();
    }
}
