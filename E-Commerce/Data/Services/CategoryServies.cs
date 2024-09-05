using E_Commerce.Models;
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
    public async Task CreateAsync(Category entity)
    {
        await _context.Categories.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public Task DeleteAsync(int id)
    {
        throw new System.NotImplementedException();
    }

    public async Task<IEnumerable<Category>> GetALLAsycn()
    => await _context.Categories.ToListAsync();
    

    public async Task<Category> GetByIdAsync(int id)
      => await _context.Categories.FirstOrDefaultAsync(x=> x.Id == id);
   

    public Task UpdateAsync(Category entity)
    {
        throw new System.NotImplementedException();
    }
}
