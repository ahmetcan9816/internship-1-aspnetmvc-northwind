using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Dal.Abstract;
using Northwind.Entities;

namespace Northwind.Dal.Concrete.NHiberNate
{
    public class NHProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int ProductId)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
