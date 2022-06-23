using ePizzaHub.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Data.Implementations
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private AppDbContext AppContext
        {
            get
            {
                return _dbContext as AppDbContext;
            }
        }
        public OrderRepository(DbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Order> GetUserOrders(int UserId)
        {
            return AppContext.Orders
               .Include(o => o.OrderItems)
               .Where(x => x.UserId == UserId).ToList();
        }
    }
}
