// Have a method that has print parachute
// that usess the DoOutput in the Director class

class Jumper{
    public void PrintParachute(int chances) {
        if (chances == 4){
        //Console.WriteLine(@"_ _ _ _ _");
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

        else if (chances == 3) {
        Console.WriteLine(@" /___\ ");
        Console.WriteLine(@" \   / ");
        Console.WriteLine(@"  \ /  ");
        Console.WriteLine(@"   0   ");
        Console.WriteLine(@"  /|\  ");
        Console.WriteLine(@"  / \  ");
        }
        else if (chances == 2) {
        Console.WriteLine(@" \   / ");
        Console.WriteLine(@"  \ /  ");
        Console.WriteLine(@"   0   ");
        Console.WriteLine(@"  /|\  ");
        Console.WriteLine(@"  / \  ");
        }
        else if (chances == 1) {
        Console.WriteLine(@"  \ /  ");
        Console.WriteLine(@"   0   ");
        Console.WriteLine(@"  /|\  ");
        Console.WriteLine(@"  / \  ");
        }
        else if (chances == 0) {
        Console.WriteLine(@"   x   ");
        Console.WriteLine(@"  /|\  ");
        Console.WriteLine(@"  / \  ");
        }
    }
}