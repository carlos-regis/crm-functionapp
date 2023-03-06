using SharedLibraries_Plugins.EntityModel;
using System;
using System.Collections.Generic;

namespace SharedLibraries_Plugins.Repos.Products
{
    public interface IProductRepos
    {
        Product retrieveProductByTTNr(string ttNR);
        Product retrieveProductById(Guid id);
        List<Product> retrieveMultipleProducts();
        void createProduct(Product product);
    }
}
