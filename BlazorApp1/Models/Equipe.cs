namespace BlazorApp1.Models;

public class Equipe
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Player> Joueurs { get; set; } = new List<Player>();
}
