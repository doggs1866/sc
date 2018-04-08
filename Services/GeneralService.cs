using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet_shoppingCart.Models;
using Microsoft.EntityFrameworkCore;
using dotnet_shoppingCart.Data;
using dotnet_shoppingCart.ViewModels;

namespace dotnet_shoppingCart.Services
{
    public class GeneralService : IGeneralService
    {
        private readonly ApplicationDbContext _dbContex;
        public GeneralService(ApplicationDbContext dbContext)
        {
            _dbContex = dbContext;
        }

        public Task<bool> AddShipment(ShipmentViewModel newShipment)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> AllProducts()
        {
            return await _dbContex.Products.ToListAsync();
        }
    }
}