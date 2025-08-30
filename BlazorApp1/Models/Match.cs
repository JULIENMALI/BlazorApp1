using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlazorApp1.Models;

public class Match
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public Equipe Equipe1 { get; set; } = null!;
    public Equipe Equipe2 { get; set; } = null!;
    public Game Jeu { get; set; } = null!;

}

