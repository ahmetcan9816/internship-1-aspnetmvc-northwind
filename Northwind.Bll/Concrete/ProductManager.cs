using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Dal.Abstract;
using Northwind.Entities;
using Northwind.Interfaces;

namespace Northwind.Bll.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //validation
            //security
            //exception handling
            return _productDal.GetAll();
        }

        public Product Get(int productId)
        {
            return _productDal.Get(productId);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
