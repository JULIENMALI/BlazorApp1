public abstract class Place
{
    public int Id {  get; set; }
    public bool Occupee { get; set; }
    public decimal Prix { get; protected set; }
}

public class PlaceNormale : Place
{
    public PlaceNormale() => Prix = 30;
}

public class PlaceGold : Place
{
    public PlaceGold() => Prix = 70;
}

public class PlaceVIP : Place
{
    public PlaceVIP() => Prix = 120;
}

public static class PlaceFactory
{
    public static Place Creer(string type)
    {
        return type switch
        {
            "Normale" => new PlaceNormale(),
            "Gold" => new PlaceGold(),
            "VIP" => new PlaceVIP(),
            _ => throw new ArgumentException("Type de place invalide")
        };
    }
}
