using System.Collections.Generic;
public class Addition
{
    private class Operation // Classe interna per rappresentare un'operazione di addizione
    {
        public int Number1 { get; } //è solo get perchè non voglio che vengano modificate dopo la creazione
        public int Number2 { get; }
        public int Result { get; }

        public Operation(int n1, int n2) // Costruttore
        {
            Number1 = n1;
            Number2 = n2;
            Result = n1 + n2;
        }

        public override string ToString() // Sovrascrivo ToString per una facile visualizzazione
        {
            return $"{Number1} + {Number2} = ?";
        }
    }
    // Lista per tenere traccia delle operazioni
    private readonly List<Operation> _operations;

    //Generatore di numeri casuali. Static per una migliore randomizzazione
    private static readonly Random _random = new Random();

    public Addition() // Costruttore della classe Addition
    {
        _operations = new List<Operation>(); // Inizializzo la lista delle operazioni. Potevo anche farlo direttamente nella dichiarazione
        GenerateOperationRandom(3); // Genera 3 operazioni iniziali
    }

    private void GenerateOperationRandom(int count) //metodo privato che genera operazioni casuali
    {
        for (int i = 0; i < count; i++)
        {
            int n1 = _random.Next(1, 1001); // Numeri tra 1 e 1000
            int n2 = _random.Next(1, 1001);
            _operations.Add(new Operation(n1, n2));
        }
    }

    public void StartAdditionGame()
    {
        WriteLine("Starting Addition Game!\n");

        for (int i = 0; i < _operations.Count; i++)
        {
            Operation currentOp = _operations[i]; // Prendo l'operazione corrente

            while (true)
            {
                Write($"Operation {i + 1}: {currentOp} Enter your answer: ");
                if (int.TryParse(ReadLine(), out int resAnswer))
                {
                    if (resAnswer == currentOp.Result)
                    {
                        WriteLine("Correct! +3 points");
                    }
                    else
                    {
                        WriteLine($"Incorrect! The correct answer is {currentOp.Result}. -2 point");
                    }
                }
                break; // Esco dal ciclo while per passare alla prossima operazione
            }
        }

    }
}
