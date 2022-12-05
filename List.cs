// This program creates a list/dictionary for the jumper game

class GuessList{

    List<string> Movies = new List<string>{"Conjuring", "Robocop", "Avengers", "Get Out", "BeautyAndTheBeast", "IronMan", "KnivesOut",
    "Megamind", "Klaus", "QueensGambit", "SeaBeast", "SouthPaw", "Loving", "Uncharted", "AllQuietOnTheWesternFront", "Home", "Chips",
    "Wednesday", "PeakyBlinders", "TheWitcher", "TheSandman", "SexEducation", "MoneyHeist","AllAmerican", "FamilyFeud",
    "WhoWantsToBeAMillionaire", "Battleship", "NewGirl"};

    // for each loop

    public string randomWord() {
        Random rgen = new Random();
        int index = rgen.Next(Movies.Count);
        return Movies[index];
    }

}