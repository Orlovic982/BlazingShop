using BlazingShop.Server.Services.CategoryService;
using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;

        public ProductService(ICategoryService categoryService )
        {
            _categoryService = categoryService;
        }


        public List<Product> Products { get; set; } = new List<Product>
                {
        new Product {

               Id=1,
               CategoryId=1,
               Title="The Hitchhiker's Guide to Galaxy",
               Description="The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams.",
               Image="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
               Price=9.99m,
               OriginalPrice=19.99m



        },
        new Product {

               Id=2,
               CategoryId=3,
               Title="Half-Life 2",
               Description="Half-Life 2 is a 2004 first-person shooter game developed and published by Valve.",
               Image="https://upload.wikimedia.org/wikipedia/en/thumb/2/25/Half-Life_2_cover.jpg/220px-Half-Life_2_cover.jpg",
               Price=8.19m,
               OriginalPrice=29.99m
                       },
        new Product {

               Id=3,
               CategoryId=4,
               Title="Ready Player One",
               Description="Ready Player One is a 2018 American science fiction action film based on Ernest Cline's 2011 novel of the same name. Directed by Steven Spielberg, from a screenplay by Zak Penn and Cline",
               Image="https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
               Price=7.99m,
               OriginalPrice=14.99m
                       },
        new Product
                    {
                Id = 4,
                CategoryId = 2,
                Title = "Nokia 3310",
                Description = "The Nokia 3310 is a GSM mobile phone announced on 1 September 2000,[2] and released in the fourth quarter of the year, replacing the popular Nokia 3210. It sold very well, being one of the most successful phones with 126 million units sold worldwide,[3] and being one of Nokia's most iconic devices",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Nokia_3310_Blue_R7309170_%28retouch%29.png/150px-Nokia_3310_Blue_R7309170_%28retouch%29.png",
                Price = 199.99m,
                OriginalPrice = 200.00m
                    },
        new Product {

               Id=5,
               CategoryId=1,
               Title="The Hitchhiker's Guide to Galaxy",
               Description="The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams.",
               Image="https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
               Price=9.99m,
               OriginalPrice=19.99m



        },
        new Product {

               Id=6,
               CategoryId=3,
               Title="Half-Life 2",
               Description="Half-Life 2 is a 2004 first-person shooter game developed and published by Valve.",
               Image="https://upload.wikimedia.org/wikipedia/en/thumb/2/25/Half-Life_2_cover.jpg/220px-Half-Life_2_cover.jpg",
               Price=8.19m,
               OriginalPrice=29.99m
                       },
        new Product {

               Id=7,
               CategoryId=4,
               Title="Ready Player One",
               Description="Ready Player One is a 2018 American science fiction action film based on Ernest Cline's 2011 novel of the same name. Directed by Steven Spielberg, from a screenplay by Zak Penn and Cline",
               Image="https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png",
               Price=7.99m,
               OriginalPrice=14.99m
                       },
        new Product
                    {
                Id = 8,
                CategoryId = 2,
                Title = "Nokia 3310",
                Description = "The Nokia 3310 is a GSM mobile phone announced on 1 September 2000,[2] and released in the fourth quarter of the year, replacing the popular Nokia 3210. It sold very well, being one of the most successful phones with 126 million units sold worldwide,[3] and being one of Nokia's most iconic devices",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Nokia_3310_Blue_R7309170_%28retouch%29.png/150px-Nokia_3310_Blue_R7309170_%28retouch%29.png",
                Price = 199.99m,
                OriginalPrice = 200.00m
                    }
               };

        
        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p=>p.CategoryId==category.Id).ToList();
        }
    }
}
