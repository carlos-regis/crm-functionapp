using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedLibraries_Plugins.Repos.Products
{
    public class ProductRepos : IProductRepos
    {
        private CrmContext crmContext;

        public ProductRepos(CrmContext _crmContext)
        {
            this.crmContext = _crmContext;
        }

        public void createProduct(Product product)
        {
            crmContext.AddObject(product);
            crmContext.SaveChanges();
        }

        public List<Product> retrieveMultipleProducts()
        {
            List<Product> productList = (from p in crmContext.ProductSet
                                         select new Product
                                         {
                                             Id = p.Id,
                                             ProductNumber = p.ProductNumber,
                                             Name = p.Name,
                                             QuantityDecimal = p.QuantityDecimal,
                                             DefaultUoMId = p.DefaultUoMId,
                                             DefaultUoMScheduleId = p.DefaultUoMScheduleId,
                                             ModifiedOn = p.ModifiedOn
                                         }).ToList();
            return productList;
        }

        public Product retrieveProductById(Guid id)
        {
            Product product = (from p in crmContext.ProductSet
                               where p.Id == id
                               select new Product
                               {
                                   Id = p.Id,
                                   ProductNumber = p.ProductNumber,
                                   Name = p.Name,
                                   QuantityDecimal = p.QuantityDecimal,
                                   DefaultUoMId = p.DefaultUoMId,
                                   DefaultUoMScheduleId = p.DefaultUoMScheduleId,
                                   ModifiedOn = p.ModifiedOn
                               }).FirstOrDefault();
            return product;
        }

        public Product retrieveProductByTTNr(string ttNR)
        {
            Product product = (from p in crmContext.ProductSet
                               where p.ProductNumber == ttNR
                               select new Product
                               {
                                   Id = p.Id,
                                   ProductNumber = p.ProductNumber,
                                   Name = p.Name,
                                   QuantityDecimal = p.QuantityDecimal,
                                   DefaultUoMId = p.DefaultUoMId,
                                   DefaultUoMScheduleId = p.DefaultUoMScheduleId,
                                   ModifiedOn = p.ModifiedOn
                               }).FirstOrDefault();
            return product;
        }
    }
}