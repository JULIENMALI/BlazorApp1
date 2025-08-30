namespace BlazorApp1.Models;

public class Player : Person
{
    public string Pseudo { get; set; }
    public string Poste { get; set; }
    public int Numero { get; set; }

    public Player(int id, string name, string firstName, int age, string pseudo, string poste, int numero)
        : base(id, name, firstName, age)
    {
        Pseudo = pseudo;
        Poste = poste;
        Numero = numero;
    }
}

