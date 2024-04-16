using IsNewsPropaganda.Models;
using IsNewsPropaganda.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace IsNewsPropaganda.Controllers;

public class ArticleController : Controller
{
    private readonly IArticleService _articleService;

    public ArticleController(IArticleService articleService)
    {
        _articleService = articleService;
    }

    public async Task<Article[]> Index()
    {
        var articles = await _articleService.GetArticlesAsync();
        return articles;
    }
}