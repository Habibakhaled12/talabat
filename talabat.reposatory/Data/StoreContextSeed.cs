using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using talabat.core.entites;

namespace talabat.reposatory.Data
{
    public static class StoreContextSeed
    {
        public static async Task SeedAsync(storeContext dbcontext)
        {
            if (!dbcontext.productBrands.Any())
            {
                var BradsData = File.ReadAllText("../talabat.reposatory/Data/DataSeed/brands.json");
                var Brands = JsonSerializer.Deserialize<List<ProductBrand>>(BradsData);
                if (Brands?.Count > 0)
                {
                    foreach (var Brand in Brands)
                    {
                        await dbcontext.Set<ProductBrand>().AddAsync(Brand);

                    }

                     await dbcontext.SaveChangesAsync();
                }
            }
            if (!dbcontext.productTypes.Any())
            {
                var typedata = File.ReadAllText("../talabat.reposatory/Data/DataSeed/types.json");
                var types = JsonSerializer.Deserialize<List<ProductType>>(typedata);
                if (types?.Count > 0)
                {
                    foreach (var type in types)
                    {
                        await dbcontext.Set<ProductType>().AddAsync(type);

                    }
                    await dbcontext.SaveChangesAsync();
                }

            }

            if (!dbcontext.Product.Any())
            {
                var productdata = File.ReadAllText("../talabat.reposatory/Data/DataSeed/products.json");
                var products = JsonSerializer.Deserialize<List<product>>(productdata);
                if (products?.Count > 0)
                {
                    foreach (var product in products)
                    {
                        await dbcontext.Set<product>().AddAsync(product);

                    }
                    await dbcontext.SaveChangesAsync();
                }
            }
        }
    }
}
