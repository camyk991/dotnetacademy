namespace IsNewsPropaganda.Models;

public class ArticleModel
{
    public int ArticleId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int SourceId { get; set; }
    public decimal Rating { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
}