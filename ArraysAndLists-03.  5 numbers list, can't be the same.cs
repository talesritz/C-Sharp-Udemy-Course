using System;

class MainClass {
  public static void Main (string[] args) {
    
    int[] numbers = new int[5];
    bool checkNumber = false;

    foreach(int num in numbers){
      Console.WriteLine("Number: " + num);
    }


    for (int i=0; i < 5; i++){

      Console.Write(string.Format("Type the {0} number: ", i+1));
      var temp = int.Parse(Console.ReadLine());
      //Console.WriteLine(numbers[i].GetType());
      

      while(checkNumber == false){
   
        for(int j = 0; j<5; j++){
          
          if (numbers[j] == temp){
            Console.WriteLine("Can't be the same number.");
            Console.Write(string.Format("Type the {0} number: ", i+1));
            temp = int.Parse(Console.ReadLine());
            j = -1;

          //} else{
            //numbers[i] = temp;
            //Console.WriteLine("Number "+ (i+1) + ": " + numbers[i]);
            //break;
          }     
        }
        numbers[i] = temp;
        Console.WriteLine(string.Format("Number {0}: {1}", i+1, numbers[i]));
        break;
      }
    } 
  }
}
