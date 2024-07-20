﻿using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Data.Services;

public class CategoryServies : ICategoryServices
{
    private readonly EcommerceDbContext _context;
    public CategoryServies(EcommerceDbContext context)
    {

        _context = context;

    }
    public Task CreateAsync(Category entity)
    {
        throw new System.NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    public async Task<IEnumerable<Category>> GetALLAsycn()
    => await _context.Categories.ToListAsync();
    

    public Task<Category> GetByIdAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    public Task UpdateAsync(Category entity)
    {
        throw new System.NotImplementedException();
    }
}
