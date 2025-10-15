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
        bool isPlaying = true;
        while (isPlaying)
        {
            try
            {
                Write("\nEnter your name: ");
                string? playerName = ReadLine();
                if (string.IsNullOrWhiteSpace(playerName))
                {
                    throw new ArgumentNullException("Name cannot be null.");
                }
                WriteLine($"Welcome to the Mathgame, {playerName}!\n");
            }
            catch (ArgumentNullException ex)
            {
                WriteLine($"\nERROR!: {ex.Message}\n");
                continue; // Torno all'inizio del ciclo while per chiedere nuovamente il nome
            }

            while (isPlaying)
            {
                try
                {
                    Write("Choose an operator for the game between: \nA -> '+' \nS -> '-' \nM -> 'x' \nD -> ':' \ne -> exit game\n");
                    string? Input_game = ReadLine();
                    if (string.IsNullOrWhiteSpace(Input_game))
                    {
                        throw new ArgumentNullException("Input cannot be null or empty.");
                    }
                    char inputChar = Input_game[0]; // Prendo il primo carattere dell'input
                    char upperChar = char.ToUpper(inputChar);
                    if (!(upperChar == 'A' || upperChar == 'S' || upperChar == 'M' || upperChar == 'D' || upperChar == 'E'))
                    {
                        throw new ArgumentException("Invalid input. Please enter 'A' for addition, 'S' for subtraction, 'M' for multiplication, 'D' for division, or 'e' to exit.");
                    }
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
                catch (ArgumentNullException ex)
                {
                    WriteLine($"\nERROR!: {ex.Message}\n");
                    continue; 
                }
                catch (ArgumentException ex)
                {
                    WriteLine($"\nERROR!: {ex.Message}\n");
                    continue;
                }
            } 
        }     
    }         
}
