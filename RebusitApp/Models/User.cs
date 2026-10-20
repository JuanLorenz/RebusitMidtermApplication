namespace RebusitApp.Models; // Change namespace to match your project

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty; // Plain text for local prototype simplicity
}