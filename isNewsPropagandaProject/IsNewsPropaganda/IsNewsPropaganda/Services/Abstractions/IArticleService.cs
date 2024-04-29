using IsNewsPropaganda.Models;

namespace IsNewsPropaganda.Services.Abstractions;


public interface IArticleService
{
    public Task<Article[]> GetArticlesAsync();

    public Task<Article> GetArticlesByIdAsync(int id);

    // public Task<int> AddArticleAsync(Article article);

    public Task<int> EditArticleAsync(Article article);
}