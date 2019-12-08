using System;

class MainClass {
  public static void Main (string[] args) {

    int linhas=0, zero=0;    
    Console.WriteLine ("Digite o numero de linhas da piramide de 0");
    linhas=int.Parse(Console.ReadLine());
    
    for (int j=0; j<linhas; j++){
     
      //inicio da inscricao das linhas
        for (int i=1; i<(linhas-j);i++){
          Console.Write(" ");// escreve a quantidade de espaços na linha
                   
        }
        
        for (int k=0; k<=zero;k++){
          
          Console.Write("0"); //escreve os zeros na linha 
        }
        //fim da inscriçao da linha
        
      Console.WriteLine("");//quebra a liha para escrever a proxima linha da piramide
      zero=zero+2;
    }

  }
}
