using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductMicroservice.Models;


namespace ProductMicroservice.Repository
{
    public interface ICategoryRepository
    {
        Category GetCategoryByID(int category);
        void InsertCategory(Category category);
        void DeleteCategory(int categoryId);
        void UpdateCategory(Category category);
        void Save();
    }
}
