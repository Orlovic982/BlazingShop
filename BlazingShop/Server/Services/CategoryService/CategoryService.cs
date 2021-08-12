using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category>  Categories { get; set; }= new List<Category>
            {
               new Category{Id=1, Name="Books", Url="books", Icon="book" },
               new Category{Id=2, Name="Electronics", Url="electronics", Icon="camera-slr" },
               new Category{Id=3, Name="Video games", Url="vide-games", Icon="aperture" },
               new Category{Id=4, Name="Movies", Url="movies", Icon="media-play" } 
            };


        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
