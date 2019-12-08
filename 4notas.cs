//Faça um Programa que leia 4 notas, mostre as notas e a média na tela.
using System;

class MainClass {
  static void Main(string[] args) {
    int[] vet = new int[4];
    int media,soma = 0;

    for (int i=0;i<vet.Length;i++) {
      soma += 1;
      int vet[i] = int.Parse(Console.ReadLine());
    }
    media = vet[i] / 4
    Console.WriteLine("Media {0}: ", media);
  }
}


