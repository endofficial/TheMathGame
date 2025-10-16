using System.Collections.Generic;
public class Subtraction
{
    public class Operation
    {
        public int Number1 { get; }
        public int Number2 { get; }
        public int Result { get; }
        public Operation(int n1, int n2)
        {
            Number1 = n1;
            Number2 = n2;
            Result = n1 - n2;
        }
        public override string ToString()
        {
            return $"{Number1} - {Number2} = ?";
        }
    } 

    private readonly List<Operation> _operations = new List<Operation>();
    private static readonly Random _random = new Random();

    private void GenerateOperationRandom(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int n1 = _random.Next(1, 101);
            int n2 = _random.Next(1, 101);
            _operations.Add(new Operation(n1, n2)); // Aggiungo l'operazione alla lista
        }
    }

    private readonly RegToChrono _gState;
    public Subtraction(RegToChrono gState)
    {
        _gState = gState;
        _operations = new List<Operation>();
        GenerateOperationRandom(3);
    }

    int points = 0;
    
    public void StartSubtractionGame()
    {
        string currentDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        _gState.AddGame(currentDate);
        Chronology chronology = new Chronology(_gState);
        WriteLine("Starting Subtraction Game!\n");
        int score = 0;
        for (int i = 0; i < _operations.Count; i++)
        {
            Operation currentOp = _operations[i]; // Prendo l'operazione corrente
            WriteLine($"Operation {i + 1}: {currentOp}"); // Mostro l'operazione
            Write("Your answer: ");
            string? input = ReadLine();
            if (int.TryParse(input, out int userAnswer))
            {
                if (userAnswer == currentOp.Result)
                {
                    WriteLine("Correct!\n");
                    score++;
                }
                else
                {
                    WriteLine($"Wrong! The correct answer is {currentOp.Result}\n");
                }
            }
            else
            {
                WriteLine($"Invalid input! The correct answer is {currentOp.Result}\n");
            }
        }
        points += score;
        WriteLine($"Game Over! You scored {score} out of {_operations.Count}.");
        WriteLine($"Total Points: {points}\n");
        while (true)
        {
            Write("Do you want to play again? (y/n) or view chronology (c): ");
            string? choice = ReadLine()?.ToLower();
            if (choice == "y")
            {
                _operations.Clear();
                GenerateOperationRandom(3);
                StartSubtractionGame();
                break;
            }
            else if (choice == "n")
            {
                WriteLine("Thanks for playing! Goodbye!");
                break;
            }
            else if (choice == "c")
            {
                chronology.StartChronology();
            }
            else
            {
                WriteLine("Invalid choice. Please enter 'y', 'n', or 'c'.");
            }
        }
    }
}