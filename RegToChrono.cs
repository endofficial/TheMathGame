public class RegToChrono
{
    protected List<DateTimeOffset> _games = new List<DateTimeOffset>();

    public DateTimeOffset GetChrono()
    {
        foreach (var game in _games)
        {
            WriteLine(game);
        }
        return DateTimeOffset.Now;
    }
}
