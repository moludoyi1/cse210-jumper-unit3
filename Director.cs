using System;

class Director {

    Guess guess = new Guess();
    
    bool NotGameOver = true;

    public void StartGame() {

        while (NotGameOver){
            GetInput();
            GetUpdates();
            DoOutput();
        }
    }

    
    public void GetInput() {
        // string input;
        Console.Write("Guess a letter [a-z]: ");
        guess.i = Console.ReadLine();

    }
    public void GetUpdates() {

    }

    public void DoOutput() {

    }
    // public bool IsGameOver() {
    //     // while 
    // }
}