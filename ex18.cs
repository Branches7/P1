using System;

class MainClass {
  public static void Main (string[] args) {
    int[] numeracao = new int[23];
    int voto = 0, cont = 0;
    decimal porcentagem = 0;
    int melhorJogador = 0;
    while(true){
      Console.Write("Número do jogador (0=fim):");
      voto = int.Parse(Console.ReadLine()) ;
      if(voto == 0)
        break;
      if(voto >= 1 && voto <= 23){
        numeracao[voto-1] += 1;
        cont++;
      }else{
        Console.WriteLine("Informe um valor entre 1 e 23 ou 0 para sair!");
      }
    }
    Console.WriteLine("Foram computados {0} votos", cont);
    melhorJogador = numeracao[0];
    for(int x = 0; x < numeracao.Length; x++){
      if(numeracao[x] != 0){
        if(numeracao[x] > melhorJogador)
          melhorJogador = numeracao[x];
        porcentagem = Decimal.Round((numeracao[x]*100)/cont);
        Console.WriteLine("O Jogador {0} obteve {1} votos - {2}%",(x+1),numeracao[x],porcentagem);
      }
    }
    Console.WriteLine("O melhor Jogador foi o {0}", numeracao[melhorJogador+1]);
  }
}