namespace API.Entities;

public class AppUser
{
    public int Id { get; set; } /*tiene que ser public para que el EntityFramework pueda usarlo*/
    public required string UserName { get; set; } 
}