using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC
{
    //Tightly Coupled
    public class BL
    {
        private IDAL _dal; //IoC


        //dependency injection implementation
        public BL(IDAL dal)
        {
            _dal = dal;
        }

        //IOC IMPLEMENTATION

        /*public BL()
        {
            //_dal = new DAL(); Tightly Coupled

            _dal = DALFactory.GetDal(); //Factory Pattern with IOC Principle
        }*/

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }


    }
}
