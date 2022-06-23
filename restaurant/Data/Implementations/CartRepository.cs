using ePizzaHub.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using restaurant.Data.Interfaces;
using restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Data.Implementations
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        private AppDbContext AppContext
        {
            get
            {
                return _dbContext as AppDbContext;
            }
        }
        public CartRepository(DbContext dbContext) : base(dbContext)
        {

        }
        public Cart GetCart(Guid CartId)
        {
            return AppContext.Carts.Include("Items").Where(c => c.Id == CartId && c.IsActive == true).FirstOrDefault();
        }

        public int DeleteItem(Guid cartId, int itemId)
        {
            var item = AppContext.CartItems.Where(ci => ci.CartId == cartId && ci.Id == itemId).FirstOrDefault();
            if (item != null)
            {
                AppContext.CartItems.Remove(item);
                return AppContext.SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public int UpdateQuantity(Guid cartId, int itemId, int Quantity)
        {
            bool flag = false;
            var cart = GetCart(cartId);
            if (cart != null)
            {
                for (int i = 0; i < cart.Items.Count; i++)
                {
                    if (cart.Items[i].Id == itemId)
                    {
                        flag = true;
                        //for minus quantity
                        if (Quantity < 0 && cart.Items[i].Quantity > 1)
                            cart.Items[i].Quantity += (Quantity);
                        else if (Quantity > 0)
                            cart.Items[i].Quantity += (Quantity);
                        break;
                    }
                }
                if (flag)
                    return AppContext.SaveChanges();
            }
            return 0;
        }

        public int UpdateCart(Guid cartId, int userId)
        {
            Cart cart = GetCart(cartId);
            cart.UserId = userId;
            return AppContext.SaveChanges();
        }
    }
}
