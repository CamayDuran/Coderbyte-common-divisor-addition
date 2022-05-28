using System;

class MainClass {

  public static int SearchingChallenge(int num) {
    int a=3;
    int b=5;
    int sum=0;
    for(int i=0;i<num;i++){

      if(i%a ==0 || i%b ==0)
      sum += i;
    }
    // code goes here  
    return sum;

  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(SearchingChallenge(Console.ReadLine()));
  } 

}