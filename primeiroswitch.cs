using System;

class MainClass {
  public static void Main (string[] args) {
    int valor=0, volta=0;
    float comp=0, larg=0, alt=0, raio=0, bas=0;
    double pi=3.141592, area=0;
    
    

    while(volta!=1){ // enquanto o valor correto nao for digitado segura a tela nas opções
    Console.WriteLine("");
    Console.WriteLine ("Digite o numero correspondente da forma geometrica para calcular a sua área:");
    Console.WriteLine ("1 - Retangulo");
    Console.WriteLine ("2 - Triângulo");
    Console.WriteLine ("3 - Circunferência");
    valor = int.Parse(Console.ReadLine());
    Console.WriteLine("");//espaçar uma linha

    if (valor>3 || valor<1){ // controla o acesso correto as opçoes
      Console.WriteLine("Opção invalida.");
    }
    else{
      volta++;
    
    
    switch (valor){ // calcula a área do retangulo
      case 1:
        Console.WriteLine("Vamos Calcular a área do Retângulo. Utilize as medidas em cm.");
        Console.WriteLine("");
        Console.WriteLine("Digite o comprimento do Retângulo");
        comp = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a largura do Retângulo");
        larg = float.Parse(Console.ReadLine());

        area=(larg*comp);

        Console.WriteLine("A área do Retângulo é: {0}", area);
        
       
       break;

    }
    switch (valor){ // calcula a área do triangulo
      case 2:
       Console.WriteLine("Vamos Calcular a área do Triângulo. Utilize as medidas em cm.");
        Console.WriteLine("");
        Console.WriteLine("Digite o comprimento da base do Triângulo");
        bas = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura do Triângulo");
        alt = float.Parse(Console.ReadLine());
        area=((bas*alt)/2);
        Console.WriteLine("");
        Console.WriteLine("A área do Triângulo é: {0}", area);
         

       break;

    }
    switch (valor){ // calcula a área da circunferencia
      case 3:
       Console.WriteLine("Vamos Calcular a área da Circunferência. Utilize as medidas em cm.");
        Console.WriteLine("");
        Console.WriteLine("Digite o raio da Circunferência");
        raio = float.Parse(Console.ReadLine());
        area=(raio*raio*pi);
        Console.WriteLine("");
        Console.WriteLine("A área da Circunferência é: {0}", area);
        

       break;

    }
    
      //voltar ao menu inicial ou sair do programa
       if (valor<=3){
        Console.WriteLine("");
        Console.WriteLine("Deseja calcular outra área?");
         Console.WriteLine("");
          Console.WriteLine("digite 0 para calcular outra área ou 1 para sair");
          volta = int.Parse(Console.ReadLine());  
       }
    }}
    Console.WriteLine("Obrigado!");
  }
}
