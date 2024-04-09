using Microsoft.AspNetCore.Mvc;

namespace IsNewsPropaganda.Controllers;

public class ArticleController : Controller
{
    private readonly IArticleService _articleService;

    public ArticleController(IArticleService articleService)
    {
        _articleService = articleService;
    }

    public IActionResult Index()
    {
        return View();
    }

    
    public IActionResult Details(Guid id)
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create()
    {
        return View();
    }
}