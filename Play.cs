public class Play
{
    public void PlayGame()
    {
        Write("Enter your name: ");
        string? playerName = ReadLine();
        WriteLine($"Welcome to the Mathgame, {playerName}!\n");

        Write("Choose an operator for the game between: \nA - '+' \nS - '-' \nM - 'x' \nD - ':' \ne - exit game");
        string? Input_game = ReadLine();
        switch (Input_game)
        {
            case "A":
                WriteLine("You chose Addition!");
                Addition addition = new Addition();
                addition.StartAdditionGame(playerName);
                break;
            case "S":
                WriteLine("You chose Subtraction!");
                Subtraction subtraction = new Subtraction();
                subtraction.StartSubtractionGame(playerName);
                break;
            case "M":
                WriteLine("You chose Multiplication!");
                Multiplication multiplication = new Multiplication();
                multiplication.StartMultiplicationGame(playerName);
                break;
            case "D":
                WriteLine("You chose Division!");
                Division division = new Division();
                division.StartDivisionGame(playerName);
                break;
            case "e":
                WriteLine("Exiting the game. Goodbye!");
                Welcome back_game = new Welcome();
                back_game.StartWelcome();
                break;
            default:
                WriteLine("Invalid choice. Please select a valid operator.");
                break;
        }
    }

}