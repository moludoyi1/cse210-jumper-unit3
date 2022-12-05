using System;

public class Guess{
   List<string> answers = new List<string>();

   public List<string> answersAppend(string answer){
      answers.Append(answer);
      return answers;
   }

    public string guessUnderscore(string Movies) { //getting the numbers of characters from the guess
        string underscores = "";
        for (int i = 0; i < Movies.Length; i++){
            underscores += "_";
        }
        return underscores;  
    }
}