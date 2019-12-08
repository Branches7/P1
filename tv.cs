/* Uma grande emissora de televisão quer fazer uma enquete entre os seus telespectadores para saber qual o melhor jogador após cada jogo. Para isto, faz-se necessário o desenvolvimento de um programa, que será utilizado pelas telefonistas, para a computação dos votos. Sua equipe foi contratada para desenvolver este programa, utilizando a linguagem de programação C++. Para computar cada voto, a telefonista digitará um número, entre 1 e 23, correspondente ao número da camisa do jogador. 
Um número de jogador igual zero, indica que a votação foi encerrada.
 Se um número inválido for digitado, o programa deve ignorá-lo, mostrando uma breve mensagem de aviso, e voltando a pedir outro número. Após o final da votação, o programa deverá exibir:
A - O total de votos computados;
B - Os númeos e respectivos votos de todos os jogadores que receberam votos;
C - O percentual de votos de cada um destes jogadores;
D - O número do jogador escolhido como o melhor jogador da partida, juntamente com o número de votos e o percentual de votos dados a ele.
Observe que os votos inválidos e o zero final não devem ser computados como votos. O resultado aparece ordenado pelo número do jogador. O programa deve fazer uso de arrays. O programa deverá executar o cálculo do percentual de cada jogador através de uma função. Esta função receberá dois parâmetros: o número de votos de um jogador e o total de votos. A função calculará o percentual e retornará o valor calculado. Abaixo segue uma tela de exemplo. O disposição das informações deve ser o mais próxima possível ao exemplo. Os dados são fictícios e podem mudar a cada execução do programa. Ao final, o programa deve ainda gravar os dados referentes ao resultado da votação em um arquivo texto no disco, obedecendo a mesma disposição apresentada na tela. */


using System;

class MainClass {
  public static void Main (string[] args) {
   
    int tam = 23, totalVotos=0, voto=1, maisVotado=0;
    float percentual;
    int [] vetJogador = new int[tam]; //cria o vetor


     Console.WriteLine("Digite o numero do jogador ou zero para sair");
      voto = int.Parse(Console.ReadLine());
   
    while (voto != 0){
     if (voto>=1 && voto<=23){
      vetJogador[voto-1] ++;
    }
    else{
      Console.WriteLine("Jogador invalido");
    }
     Console.WriteLine("Digite o numero do jogador ou zero para sair");
      voto = int.Parse(Console.ReadLine());
    }
    // LETRA a
    Console.WriteLine ("total de votos: {0}", totalVotos);

    // LETRA B - C
    for (int i=0; i<tam; i++){
      if (vetJogador[i]>0){
        percentual = ((float)vetJogador[i]/totalVotos);
        Console.WriteLine("O jogador {0} teve {1} votos e tem {2:f} % do total de votos", i+1 , vetJogador[i], percentual);
      }
    }
    //LETRA D
    for(int i=0; i<tam; i++){
      if(vetJogador[i]> vetJogador[maisVotado])
      maisVotado = i;
    }
    percentual = ((float)vetJogador[maisVotado]/totalVotos*100);
    Console.WriteLine("O jogador mais votado teve{0} votos, ficando com {1:f} % dos votos" , maisVotado+1, percentual);

     //para mostrar o valor do vetor
    for(int i=0; i<tam ; i++){
      Console.Write("{0} - ", vetJogador[i]);
    }
    Console.WriteLine( vetJogador.Length); //montra o total de posições no vetor
 
  }
}
