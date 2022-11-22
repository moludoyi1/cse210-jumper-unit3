class Program {

    static void Main() {
        Director start = new Director();
        DisplayWelcomeMessage();
        start.StartGame();

    }




    static void DisplayWelcomeMessage() {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("############################");
        Console.WriteLine("Welcome");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Let the game begin!!!");
        Console.WriteLine("############################");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
    }

}