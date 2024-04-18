using IsNewsPropaganda.Models;
using IsNewsPropaganda.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace IsNewsPropaganda.Controllers;

public class ArticlesController : Controller
{
    private readonly IArticleService _articleService;

    public ArticlesController(IArticleService articleService)
    {
        _articleService = articleService;
    }

    public async Task<IActionResult> Index()
    {
        var articles = await _articleService.GetArticlesAsync();
        
        var articleModels = articles.Select(article => new ArticleModel
        {
            Title = article.Title,
            Content = article.Content,
            // Map other properties as needed
        }).ToArray();

        var viewModel = new ArticleIndexViewModel { Articles = articleModels };

        return View(viewModel);
    }
}