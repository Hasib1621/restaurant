using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using restaurant.Models;

namespace restaurant.Data
{
    public class AppDbContext :DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

        DbSet<Adress> Adresses;
        DbSet<Cart> Carts;
        DbSet<CartItem> CartItems;
        DbSet<Category> Categories;
        DbSet<Item> Items;
        DbSet<ItemType> ItemTypes;
        DbSet<Order> Orders;
        DbSet<OrderItem> OrderItems;
        DbSet<Payment> Payments;
        DbSet<Role> Roles;
        DbSet<User> Users;

            
    }
}
