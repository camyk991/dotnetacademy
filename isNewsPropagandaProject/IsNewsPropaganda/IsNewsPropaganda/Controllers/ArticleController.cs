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

    public async Task<IActionResult> Index()
    {
        var articles = await _articleService.GetArticlesByIdAsync();
        return View(articles);
    }
}