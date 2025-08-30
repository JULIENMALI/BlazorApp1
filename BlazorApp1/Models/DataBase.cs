using System;
using System.Collections.Generic;

namespace BlazorApp1.Models;

public class DataBase
{
    // Singleton instance
    private static DataBase _instance;
    public static DataBase Instance => _instance ??= new DataBase();

    // Tables simulées
    public List<Equipe> Equipes { get; set; } = new List<Equipe>();
    public List<Subscriber> Abonnes { get; set; } = new List<Subscriber>();
    public List<Match> Matches { get; set; } = new List<Match>();
    public List<Place> Places { get; set; } = new List<Place>();
    public List<Game> Games { get; set; } = new List<Game>();
    public List<Player> Players { get; set; }= new List<Player>();



    private int nextPlaceId = 1; 
    // Constructeur privé
    private DataBase()
    {

        // Simuler des données de base
       


        Equipes.Add(new Equipe { Id = 1, Name = "Karmine Corp"});
        Equipes.Add(new Equipe { Id = 2, Name = "G2" });
        Equipes.Add(new Equipe { Id = 3, Name = "NAVI" });
        Equipes.Add(new Equipe { Id = 4, Name = "KOI" });
        Equipes.Add(new Equipe { Id = 5, Name = "Fnatic" });
        Equipes.Add(new Equipe { Id = 6, Name = "SK" });
        Equipes.Add(new Equipe { Id = 7, Name = "BDS" });
        Equipes.Add(new Equipe { Id = 8, Name = "Vitality" });
        Equipes.Add(new Equipe { Id = 9, Name = "GiantX" });
        Equipes.Add(new Equipe { Id = 10, Name = "Heretics" });

        Players.Add(new Player(1, "Canna", "Kim", 24, "CANNA", "TOP", 10)
        {
            EquipeId = 1,
            Equipe = Equipes.FirstOrDefault(e => e.Id == 1)
        });
        Equipes.First(e => e.Id == 1).Joueurs.Add(Players.Last());
        Players.Add(new Player(2, "Yike", "Yike", 24, "Yike", "JGL", 10)
        {
            EquipeId = 1,
            Equipe = Equipes.FirstOrDefault(e => e.Id == 1)
        });
        Equipes.First(e => e.Id == 1).Joueurs.Add(Players.Last());
        Players.Add(new Player(3, "Vladi", "Vladi", 20, "Vladi", "MID", 10)
        {
            EquipeId = 1,
            Equipe = Equipes.FirstOrDefault(e => e.Id == 1)
        });
        Equipes.First(e => e.Id == 1).Joueurs.Add(Players.Last());
        Players.Add(new Player(4, "Caliste", "Caliste", 19, "Caliste", "ADC", 10)
        {
            EquipeId = 1,
            Equipe = Equipes.FirstOrDefault(e => e.Id == 1)
        });
        Equipes.First(e => e.Id == 1).Joueurs.Add(Players.Last());
        Players.Add(new Player(5, "Targamas", "Targamas", 24, "Targamas", "SUP", 10)
        {
            EquipeId = 1,
            Equipe = Equipes.FirstOrDefault(e => e.Id == 1)
        });
        Equipes.First(e => e.Id == 1).Joueurs.Add(Players.Last());


        Players.Add(new Player(6, "BB", "BB", 24, "BB", "TOP", 10)
        {
            EquipeId = 2,
            Equipe = Equipes.FirstOrDefault(e => e.Id == 1)
        });
        Equipes.First(e => e.Id == 2).Joueurs.Add(Players.Last());
        Players.Add(new Player(7, "Skwemond", "Skwemond", 24, "Skwemond", "JGL", 10)
        {
            EquipeId = 2,
            Equipe = Equipes.FirstOrDefault(e => e.Id == 2)
        });
        Equipes.First(e => e.Id == 2).Joueurs.Add(Players.Last());
        Players.Add(new Player(8, "Caps", "Caps", 20, "Caps", "MID", 10)
        {
            EquipeId = 2,
            Equipe = Equipes.FirstOrDefault(e => e.Id == 2)
        });
        Equipes.First(e => e.Id == 2).Joueurs.Add(Players.Last());
        Players.Add(new Player(9, "Hans Sama", "Hans Sama", 19, "Hans Sama", "ADC", 10)
        {
            EquipeId = 2,
            Equipe = Equipes.FirstOrDefault(e => e.Id == 2)
        });
        Equipes.First(e => e.Id == 2).Joueurs.Add(Players.Last());
        Players.Add(new Player(10, "Labrov", "Labrov", 24, "Labrov", "SUP", 10)
        {
            EquipeId = 2,
            Equipe = Equipes.FirstOrDefault(e => e.Id == 2)
        });
        Equipes.First(e => e.Id == 2).Joueurs.Add(Players.Last());

        Games.Add(new Game { Id = 1, Name = "League of Legends" });
        Games.Add(new Game { Id = 2, Name = "Valorant" });

        // Exemple de match existant
        Matches.Add(new Match
        {
            Date = DateTime.Today.AddDays(7),
            Equipe1 = Equipes[0],
            Equipe2 = Equipes[1],
            Jeu = Games[0]
        });

        // Créer des places avec ID unique
        CreatePlaces("Gold", 5, 12);    
        CreatePlaces("Normale", 15, 20); 
        CreatePlaces("VIP", 2, 6);       
    }

    private void CreatePlaces(string type, int rows, int cols)
    {
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Place place = PlaceFactory.Creer(type);
                place.Id = nextPlaceId++; 
                Places.Add(place);
            }
        }
    }
}
