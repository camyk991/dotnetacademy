using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IsNewsPropaganda.Models;

public class Article
{
    public int ArticleId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    
    [ForeignKey("SourceId")]
    public int SourceId { get; set; }
    
    [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10")]
    public decimal Rating { get; set; }
    
    public int Likes { get; set; }
    public int Dislikes { get; set; }
}