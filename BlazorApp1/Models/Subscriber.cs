namespace BlazorApp1.Models;

public class Subscriber : Person
{
    public string Email { get; private set; }
    public string State { get; private set; }
    public List<Game> Games { get; private set; }

    private Subscriber(int id, string name, string firstName, int age, string state, string email, List<Game> games)
        : base(id, name, firstName, age)
    {
        State = state;
        Email = email;
        Games = games ?? new List<Game>();
    }

    public class Builder
    {
        private int _id;
        private string _name = null!;
        private string _firstName = null!;
        private int _age;
        private string _state = null!;
        private string _email = null!;
        private List<Game> _games = new List<Game>();

        public Builder SetId(int id)
        {
            _id = id;
            return this;
        }

        public Builder SetName(string nom)
        {
            _name = nom;
            return this;
        }

        public Builder SetFirstName(string prenom)
        {
            _firstName = prenom;
            return this;
        }

        public Builder SetAge(int age)
        {
            _age = age;
            return this;
        }

        public Builder SetEtat(string etat)
        {
            _state = etat;
            return this;
        }

        public Builder SetEmail(string email)
        {
            _email = email;
            return this;
        }

        // Permet d'ajouter un jeu au suivi
        public Builder AddGame(Game game)
        {
            if (game != null)
            {
                _games.Add(game);
            }
            return this;
        }

        // Ou permet d'ajouter plusieurs jeux en une fois
        public Builder AddGames(IEnumerable<Game> games)
        {
            if (games != null)
            {
                _games.AddRange(games);
            }
            return this;
        }

        public Subscriber Build()
        {
            return new Subscriber(_id, _name, _firstName, _age, _state, _email, _games);
        }
    }
}
