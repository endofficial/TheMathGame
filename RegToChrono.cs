public class RegToChrono 
{
    //lista privata per tenere traccia delle partite giocate; privata perchè non voglio che venga modificata dall'esterno
    private List<string> _games = new List<string>();

    public void AddGame(string game_Time)
    {
        _games.Add(game_Time);
    }

    public void GetChrono() //void perché non ritorna nulla, deve solo stampare
    {
        WriteLine("--- Games chronology ---\n");
        if (_games.Count == 0)
        {
            WriteLine("\nNo games recorded!\n");
            return;
        }

        foreach (var game in _games)
        {
            WriteLine(game);
        }
        WriteLine("\n--- End of chronology ---\n");
    }
}
