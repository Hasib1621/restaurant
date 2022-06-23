using Microsoft.EntityFrameworkCore;
using restaurant.Data.Interfaces;
using restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurant.Data.Implementations
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext AppContext
        {
            get
            {
                return _dbContext as AppDbContext;
            }
        }


        public CategoryRepository(DbContext dbContext) : base(dbContext)
        {

        }

        

        public IEnumerable<Category> GetCategory(int CategoryId)
        {
            return AppContext.Categories.Where(x => x.Id == CategoryId).ToList();
        }
    }
}
