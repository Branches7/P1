using System;

class MainClass {
  public static void reserva(Controle n1){
    int lin = 0, col = 0;
    char tipo;
    Console.WriteLine("Digite a fila de 1 a 20");
    lin = int.Parse(Console.ReadLine())-1;
    Console.WriteLine("Digite o num da cadeira de 1 a 15");
    col = int.Parse(Console.ReadLine())-1;
    Console.WriteLine("Digite M pasa meia entrada ou I para inteira");
    tipo = char.Parse(Console.ReadLine());


    if(n1.reservar(lin, col, tipo)){
      Console.WriteLine("Reserva efetivada!");
    }
    else 
      Console.WriteLine("Erro, lugar ocupado");
  }
  public static void Main (string[] args) {
    char resp = ' ';
    Controle n1 = new Controle();
    
    Console.WriteLine("Para reservar digiti R, para ver o mapa digite P para sair S");
    resp = char.Parse(Console.ReadLine());
    while(resp != 'S'){
      switch (resp) {
        case 'R':
          reserva(n1);
        break;
        case 'P':
          n1.Print();
        break;
      }
      Console.WriteLine("Para reservar digiti R, para ver o mapa digite P para sair S");
      resp = char.Parse(Console.ReadLine());
    }
    n1.Print();
    n1.relatorioOcupacao();
    n1.relatorioFinaceiro();
    
  }
}
using System;

public class Controle{
  private char [,] acentos = new char [20,15];
  public Controle( char[,] a){
    limpa();
  }
  public  Controle(){
    limpa();
  }

  // metodos

  void limpa (){
    for(int i = 0; i<20; i++){
      for(int j = 0; j< 15; j++){
        acentos [i,j]  = 'L';
      }
    }
  }
  public void Print (){
    for(int i = 0; i<20; i++){
      for(int j = 0; j< 15; j++){
       Console.Write("{0} ", acentos [i,j]) ;
      }
      Console.WriteLine();
    }
  }
  public bool reservar(int lin, int col, char tipo){
    if(verificarOcupacao(lin, col)){
      return false;
    }
    acentos[lin, col] = tipo;

    return true;
  }
  public bool verificarOcupacao(int lin, int col){
    return acentos[lin, col] != 'L';
  }
  public int contarOcupacao(){
    //int I = 0;
    int M = 0;

    for(int i = 0; i < 20; i++){
      for(int j = 0; j < 15; j++){
        if(acentos[i,j] != 'L'){
          M++;
        }
      }
    }
    return M;
  }
  public void relatorioOcupacao(){
    int I = 0;
    int M = 0;

    for(int i = 0; i < 20; i++){
      for(int j = 0; j < 15; j++){
        if(acentos[i,j] == 'I') I++;
        else if(acentos[i,j] == 'M') M++;
      }
    }
    Console.WriteLine("Meia: {0}%, Inteira: {1}%, Livre: {2}%", percent(M, 300), percent(I, 300), percent(300-(M+I), 300) );
  }

  public void relatorioFinaceiro(){
    int I = 0;
    int M = 0;

    for(int i = 0; i < 20; i++){
      for(int j = 0; j < 15; j++){
        if(acentos[i,j] == 'I') I++;
        else if(acentos[i,j] == 'M') M++;
      }
    }
    Console.WriteLine("Meia:{2} X 35 = R${0}.00 , Inteira:{3} X 70 R${1}.00", M*35, I*70, M, I);
  }

  float percent(int val, int total){
    float retorno = ((float)val*100f)/(float)total;
    return retorno;
  }
} // fim da class

