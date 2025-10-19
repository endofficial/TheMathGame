public class RegToChrono
{
    /*private readonly Play _gPlayer;
    public RegToChrono(Play gPlayer) // Costruttore che accetta un'istanza di Play
    {
        _gPlayer = gPlayer;
    }*/

    //lista privata per tenere traccia delle partite giocate; privata perchè non voglio che venga modificata dall'esterno
    protected List<string> _games = new List<string>();
    protected List<string> _gPlayer = new List<string>();

    public void AddGame(string game_Time)
    {
        _games.Add(game_Time);
    }

    public void AddPlayer(string player_Name)
    {
        _gPlayer.Add(player_Name);
    }

    public void GetChrono() //void perché non ritorna nulla, deve solo stampare
    {
        WriteLine("--- Games chronology ---\n");
        if (_games.Count == 0)
        {
            WriteLine("\nNo games recorded!\n");
            return;
        }

        HashSet<string> uniquePlayers = new HashSet<string>(_gPlayer);

        // Stampo il nome del giocatore e la lista delle partite giocate
        foreach (var player in uniquePlayers)
        {
            Write($"Player: {player}\n");
        }

        foreach (var game in _games)
        {
            Write($"{game}\n");
        }
        WriteLine("\n--- End of chronology ---\n");
    }
}
