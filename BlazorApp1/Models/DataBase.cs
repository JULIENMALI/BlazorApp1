using System;
using System.Collections.Generic;

namespace BlazorApp1.Models
{
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

        private int nextPlaceId = 1; 
        // Constructeur privé
        private DataBase()
        {
            // Simuler des données de base
            Equipes.Add(new Equipe { Id = 1, Name = "Karmine Corp" });
            Equipes.Add(new Equipe { Id = 2, Name = "G2" });

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
}
