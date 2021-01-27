using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    
    var numbers = new List<int>();
    var temp = "";
    var count = 0;
    var verifier = true;

    while(verifier == true){

      Console.Write(string.Format("{0} number or \"quit\" to exit: ", count+1));  
      temp = Console.ReadLine();

      if(temp == "quit"){
        Console.WriteLine("\nThe program has ended...\n");
        verifier = false;
        break;
      } else{
        numbers.Add(int.Parse(temp));
      }

      count++;
    }

    var exists = false;
    var uniqueNumbers = new List<int>();
    var repeatedNumbers = new List<int>();
    foreach(int tmp in numbers){

      foreach(int uniqueTmp in uniqueNumbers){
        if(tmp == uniqueTmp){
          exists = true;
          repeatedNumbers.Add(tmp);
          break;
        }
      }

      if(!exists){
        uniqueNumbers.Add(tmp);
      }

      exists = false;     
    }
    
    for(int i = 0; i < uniqueNumbers.Count; i++){
      Console.WriteLine(string.Format("Number {0}: {1}", i+1, uniqueNumbers[i]));
    }

    Console.WriteLine("");

    for(int i = 0; repeatedNumbers.Count; i++){
      Console.WriteLine(string.Format("Repeated {0}: {1}", i+1, repeatedNumbers[i]))
    }
    
  }
}
