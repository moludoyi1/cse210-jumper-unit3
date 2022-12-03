using System;

public class Guess{
   List<string> answers = new List<string>();

   public List<string> answersAppend(string answer){
      answers.Append(answer);
      return answers;
   }

    public List<string> stringunderscores(string underscores) {
        // string stringunderscores = "";
        // foreach (var character in rgen){
        underscores += '_';
        // }
        return underscores;
    }

}