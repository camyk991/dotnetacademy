using IsNewsPropaganda.Data;
using IsNewsPropaganda.Services.Abstractions;
using IsNewsPropaganda.Models;
using Microsoft.EntityFrameworkCore;

namespace IsNewsPropaganda.Services.Implementation;

public class ArticleService : IArticleService
{
    private readonly IsNewsPropagandaDbContext _dbContext;

    public ArticleService(IsNewsPropagandaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<Article[]> GetArticlesAsync()
    {
        return _dbContext.Articles.ToArrayAsync();
    }

    public Task<Article?> GetArticlesByIdAsync(int id)
    {
        return _dbContext.Articles.SingleOrDefaultAsync(article => article.ArticleId.Equals(id));
    }

    public async Task<int> EditArticleAsync(Article article)
    {
        _dbContext.Articles.Update(article);
        return await _dbContext.SaveChangesAsync();
    }
    
}