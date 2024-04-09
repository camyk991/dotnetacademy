using IsNewsPropaganda.Data.Entities;
using IsNewsPropaganda.Models;

namespace IsNewsPropaganda.Services.Abstractions;


public interface IArticleService
{
    public Task<Article[]> GetBooksAsync();

    public Task<Article> GetArticleByIdAsync(Guid id);

    public Task<int> AddArticleAsync(Article article);
}