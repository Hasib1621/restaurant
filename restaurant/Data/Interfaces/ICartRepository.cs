using restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Data.Interfaces
{ 
    public interface ICartRepository : IRepository<Cart>
    {
        Cart GetCart(Guid CartId);
        int DeleteItem(Guid cartId, int itemId);
        int UpdateQuantity(Guid cartId, int itemId, int Quantity);
        int UpdateCart(Guid cartId, int userId);
    }
}
