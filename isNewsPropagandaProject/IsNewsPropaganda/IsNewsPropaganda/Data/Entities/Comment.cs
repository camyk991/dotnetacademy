using System.ComponentModel.DataAnnotations.Schema;

namespace IsNewsPropaganda.Models;

public class Comment
{
    public int CommentId { get; set; }
    
    [ForeignKey("ArticleId")]
    public int? ArticleId { get; set; }
    
    [ForeignKey("UserId")]
    public int? UserId { get; set; }
    
    public string CommentContent { get; set; }
}