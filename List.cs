// This program creates a list/dictionary for the jumper game

class GuessList{

    List<string> Movies = new List<string>{"Conjuring", "Robocop", "Avengers", "Get Out", "Beauty and the Beast", "Iron Man", "Knives Out",
    "Megamind", "Klaus", "Queens Gambit", "Sea Beast", "SouthPaw", "Loving", "Uncharted", "All Quiet on the Western Front", "Home", "Chips",
    "Wednesday", "Peaky Blinders", "The Witcher", "The Sandman", "Sex Education", "Money Heist","All American", "Family Feud",
    "Who wants to be a Millionaire", "Battleship", "New Girl"};

    public string randomWord() {
        Random rgen = new Random();
        int index = rgen.Next(Movies.Count);
        return Movies[index];
    }

}


// use a foreach loop to get the # of characters