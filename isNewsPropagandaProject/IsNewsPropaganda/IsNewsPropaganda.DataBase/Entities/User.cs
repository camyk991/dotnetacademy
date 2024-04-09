using System.ComponentModel.DataAnnotations.Schema;

namespace IsNewsPropaganda.Models;

public enum UserRole
{
    Admin,
    Moderator,
    Visitor
}

public class User
{
    public Guid UserId { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    public UserRole? UserRole { get; set; }
}