using System;

class Director {

    Guess guess = new Guess();
    Jumper jumper = new Jumper();
    string wordGuess = "";
    int chances = 4;

    
    bool NotGameOver = true;
    public void StartGame() {
        GuessList movies = new GuessList();
        wordGuess = movies.randomWord();
        // Console.WriteLine(wordGuess);
        while (NotGameOver){
            GetInput();
            GetUpdates();
            DoOutput();
            chances -= 1;
            if (chances == 0) {
                NotGameOver = false;
            }
        }
        Console.WriteLine($"The word you're trying to guess is: {wordGuess}, you idiot");
    }

    
    public void GetInput() {
        // gets input from user for the game
        Console.Write("Guess a letter [a-z]: ");
        string input = Console.ReadLine();
        guess.answersAppend(input.ToLower());
    }
    public void GetUpdates() {
        
    }

    public void DoOutput() {
        jumper.PrintParachute(chances);
        // guess.guessUnderscore(wordGuess);
        Console.WriteLine(guess.guessUnderscore(wordGuess));

    }
}