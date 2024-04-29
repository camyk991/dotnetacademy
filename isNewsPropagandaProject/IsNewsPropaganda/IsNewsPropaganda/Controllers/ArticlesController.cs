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
            ArticleId = article.ArticleId,
            Title = article.Title,
            Content = article.Content,
            
        }).ToArray();
        
        var viewModel = new ArticleIndexViewModel { Articles = articleModels };

        return View(viewModel);
        // return articles;
    }
    
    public async Task<IActionResult> EditArticle(int id)
    {
        var specificArticle = await _articleService.GetArticlesByIdAsync(id);
        
        var viewModel = new ArticleModel
        {
            ArticleId = specificArticle.ArticleId,
            Content = specificArticle.Content,
            Dislikes = specificArticle.Dislikes,
            Likes = specificArticle.Likes,
            Rating = specificArticle.Rating,
            SourceId = specificArticle.SourceId,
            Title = specificArticle.Title
        };
        
        return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> EditArticle(int id, String Title, String Content, decimal Rating)
    {

        var article = await _articleService.GetArticlesByIdAsync(id);

        article.Title = Title;
        article.Content = Content;
        article.Rating = Rating;

        var response = await _articleService.EditArticleAsync(article);
        if (response == 1)
        {
            ViewBag.UpdateMessage = "Article updated successfully.";    
        }
        
        return View();
    }
    
}