public class Play
{
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
                Addition addition = new Addition();
                addition.StartAdditionGame();
                break;
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