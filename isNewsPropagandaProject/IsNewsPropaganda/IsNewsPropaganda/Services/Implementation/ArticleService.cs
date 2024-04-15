using IsNewsPropaganda.Data;
using IsNewsPropaganda.Services.Abstractions;
using IsNewsPropaganda.Models;
using Microsoft.EntityFrameworkCore;

namespace IsNewsPropaganda.Services.Implementation;

public class ArticleService : IArticleService
{
    private readonly IsNewsPropagandaDbContext _dbContext;

    public ArticleService()
    {
    }

    public Task<Article[]> GetArticlesAsync()
    {
        return _dbContext.Articles.ToArrayAsync();
    }

    public Task<Article?> GetArticlesByIdAsync(Guid id)
    {
        return _dbContext.Articles.SingleOrDefaultAsync(article => article.ArticleId.Equals(id));
    }
    
    
}