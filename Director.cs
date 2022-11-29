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
        Console.WriteLine(@"_ _ _ _ _");
        Console.WriteLine("");
        Console.WriteLine(@"  ___  ");
        Console.WriteLine(@" /___\ ");
        Console.WriteLine(@" \   / ");
        Console.WriteLine(@"  \ /  ");
        Console.WriteLine(@"   0   ");
        Console.WriteLine(@"  /|\  ");
        Console.WriteLine(@"  / \  ");
        Console.WriteLine("");
        Console.WriteLine("^^^^^^^");
    }
    // public bool IsGameOver() {
    //     // while 
    // }
}