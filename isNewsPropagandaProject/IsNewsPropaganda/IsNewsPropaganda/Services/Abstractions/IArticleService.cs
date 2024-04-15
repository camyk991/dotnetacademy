using IsNewsPropaganda.Models;

namespace IsNewsPropaganda.Services.Abstractions;


public interface IArticleService
{
    public Task<Article[]> GetArticlesAsync();

    public Task<Article> GetArticlesByIdAsync(Guid id);

    // public Task<int> AddArticleAsync(Article article);
}