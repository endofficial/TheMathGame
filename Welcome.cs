public class Welcome
{
    public void StartWelcome()
    {
        WriteLine("Welcome to Mathgame!");
        WriteLine("P - PLAY \nC - CHRONOLOGY \nQ - QUIT\n");

        string? input_1 = ReadLine();
        switch (input_1)
        {
            case "P" or "p":
                Play gameStart = new Play();
                gameStart.PlayGame();
                break;
            case "C" or "c":
                Chronology chronology = new Chronology();
                chronology.StartChronology();
                break;
            case "Q" or "q":
                WriteLine("You chose to quit the game, goodbye!");
                break;
        }
        ;
    }
}
