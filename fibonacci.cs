using System;

class MainClass {
  static void Main (string[] args) {
    int termo1 = 1, termo2 = 1, prox_termo;
    int[] fibo = new int[20];

    Console.WriteLine("A série fibonacci até o 20º:"); 

    for(int i=0;i<fibo.Length;i++) {
      prox_termo = termo1 + termo2;
      termo1 = termo2;
      termo2 = prox_termo;

      fibo[i] = termo1;
      fibo[i] = termo2;
      fibo[i] = prox_termo;

      Console.Write(fibo[i]+","); 
      
    }
    
  }
}