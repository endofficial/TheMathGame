WriteLine("Welcome to Mathgame!");
WriteLine("P - PLAY \nC - CHRONOLOGY \nQ - QUIT\n");

string? input_1 = ReadLine();
switch (input_1)
{
    case "P":
        Play gameStart = new Play();
        gameStart.PlayGame();
        break;
    case "C":
        Chronology chronology = new Chronology();
        chronology.StartChronology();
        break; 
    case "Q":
        WriteLine("You chose to quit the game, goodbye!");
        break;
};