using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    
  
    var tempString = Console.ReadLine();
    var numbers = new List<int>();
    var verifier = false;

    for(int i=0; i < tempString.Length; i++){
     
      if(Char.IsDigit(tempString, i)){
        numbers.Add(int.Parse(tempString[i].ToString()));
      }
    }
    

    while(verifier == false){

      if(numbers.Count == 0){
        Console.WriteLine("Cannot be an empty string.\nPlease, try again: ");
        tempString = Console.ReadLine();
        
        for(int i=0; i < tempString.Length; i++){
     
          if(Char.IsDigit(tempString, i)){
            numbers.Add(int.Parse(tempString[i].ToString()));
          }
        }
      } 
      else if(numbers.Count < 5){

        Console.WriteLine("Invalid List.\nPlease, try again: ");
        tempString = Console.ReadLine();
        
        for(int i=0; i < tempString.Length; i++){
     
          if(Char.IsDigit(tempString, i)){
            numbers.Add(int.Parse(tempString[i].ToString()));
          }
        }
      } 
      else{
        verifier = true;
        numbers.Sort();

        for(int i=0; i<3; i++){
          Console.WriteLine(string.Format("Number {0}: {1}",i+1, numbers[i]));
        }
      }
            
    }   
  }
}
