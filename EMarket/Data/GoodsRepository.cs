using EMarket.Data;
using EMarket.Models;

public class GoodsRepository
{
    private readonly ApplicationDbContext _context;

    public GoodsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Category> GetAllCategories()
    {
        var categories = _context.Categories.ToList();
        return categories;
    }
}