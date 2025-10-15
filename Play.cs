public class Play
{
    // Composizione: Play "ha un" RegToChrono per registrare le partite giocate
    private readonly RegToChrono _gState;
    public Play(RegToChrono gState)
    {
        _gState = gState;
    }
    public void PlayGame()
    {
        Write("\nEnter your name: ");
        string? playerName = ReadLine();
        WriteLine($"Welcome to the Mathgame, {playerName}!\n");

        Write("Choose an operator for the game between: \nA - '+' \nS - '-' \nM - 'x' \nD - ':' \ne - exit game\n");
        WriteLine();
        string? Input_game = ReadLine();
        switch (Input_game)
        {
            case "A" or "a":
                WriteLine("\nYou chose Addition!");
                Addition addition = new Addition(_gState); // Passo l'istanza di RegToChrono al costruttore di Addition
                addition.StartAdditionGame();
                return; // Esco dal metodo per tornare al menu principale del gioco senza perdere lo stato del gioco
            /*case "S" or "s":
                WriteLine("You chose Subtraction!");
                Subtraction subtraction = new Subtraction();
                subtraction.StartSubtractionGame(playerName);
                break;
            case "M" or "m":
                WriteLine("You chose Multiplication!");
                Multiplication multiplication = new Multiplication();
                multiplication.StartMultiplicationGame(playerName);
                break;
            case "D" or "d":
                WriteLine("You chose Division!");
                Division division = new Division();
                division.StartDivisionGame(playerName);
                break;*/
            case "e":
                WriteLine("\nExiting the game. Goodbye!\n");
                return;
            default:
                WriteLine("Invalid choice. Please select a valid operator.");
                break;
        }
    }

}