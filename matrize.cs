using System;
using System.IO;
using System.Text;

class MainClass {

  
  public static void Main (string[] args) {

 

    const int qtdLinhas = 5, qtdColunas = 5;
   int [,] matriz = new int [qtdLinhas, qtdColunas]; 

    
    FileStream meuArq = new FileStream("arquivo.txt", FileMode.Open, FileAccess.Read);

    //leitor de arquivo
    StreamReader sr = new StreamReader(meuArq, Encoding.UTF8);

    //passa pela matriz e pega os dados dali

    for (int i=0; i<qtdLinhas; i++){
        for (int j=0; j<qtdColunas; j++){
            string str = sr.ReadLine();
            matriz[i,j] = int.Parse(str);
        }

    }
    

    for (int i=0; i<qtdLinhas; i++){
        for (int j=0; j<qtdColunas; j++){
            
           // martiz[i,j] = int.Parse(str);
            Console.Write("{0} ", matriz[i,j]);
        }
        Console.WriteLine();

    }



/*

    float[,] dados = new float[qtdLinhas, qtdColunas];

    Console.WriteLine("Informe 12 números para a matriz:");
    for(int l=0; l<qtdLinhas; l++){
      for(int c=0; c<qtdColunas; c++){
        dados[l, c] = float.Parse(Console.ReadLine());
      }
    }
    float [] soma = new float [qtdColunas];

    for(int l=0; l<qtdLinhas; l++){
      for(int c=0; c<qtdColunas; c++){

        soma[c] = soma[c] + dados[l,c];
        
      }
    }

    for (int i=0; i<qtdLinhas; i++){
    float media = soma[i]/qtdLinhas;
      Console.WriteLine("Média da coluna {0} : {1}", i, media);
    }*/
  }
}
1
2
3
4
5
6
7
8
9
0
1
2
3
4
5
6
7
8
9
0
1
2
3
4
5
