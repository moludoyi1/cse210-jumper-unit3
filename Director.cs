using System;

class Director {

    Guess guess = new Guess();
    Jumper jumper = new Jumper();
    
    bool NotGameOver = true;
    public void StartGame() {
        GuessList movies = new GuessList();
        var randomWord = movies.randomWord();
        while (NotGameOver){
            GetInput();
            GetUpdates();
            DoOutput();
        }
    }

    
    public void GetInput() {
        // gets input from user for the game
        Console.Write("Guess a letter [a-z]: ");
        string input = Console.ReadLine();

        guess.answersAppend(input);
    }
    public void GetUpdates() {

    }

    public void DoOutput() {
        jumper.PrintParachute();
    }
}