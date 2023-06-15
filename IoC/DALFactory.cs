using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    public class DALFactory
    {
        public static IDAL GetDal()
        {
            return new DAL();
        }
    }
}
