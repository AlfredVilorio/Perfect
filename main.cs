using System;

class Program {
  public static void Main (string[] args) {

     //Display Input for User
    Console.WriteLine("Enter a number:  ");
    if(int.TryParse(Console.ReadLine(), out int num))
      {
        //integer is going to start at 1 with the input increasing  
        int sum = 0;
        for (int n = 1; n < num; n++){
        // If Input divided by n is evenly divisible and equals zero then the sum is increased by the value of input
        if ( num % n == 0){
        sum += n;
      }
      
    }
//Displays two possible answers based on Input
    if (sum == num) {
      Console.WriteLine("Perfect Number");}
     
    else {
      Console.WriteLine ("Not A Perfect Number");
        }
    }
  }}

        
    
    
  
  