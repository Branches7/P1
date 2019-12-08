using System;

namespace exemplo{
 
  class MainClass {
    public static void Main (string[] args) {
      Carro meuCarro = new Carro("Carrodaniel");  //recebe um novo objeto do tipo carro
      Carro meuCarro2 = new Carro();
      Carro meuCarro3 = new Carro("uno", 43,1000);
      Console.WriteLine(meuCarro.modelo);
      Console.WriteLine(meuCarro2.modelo);
      Console.WriteLine(meuCarro3.modelo);
    }
  }
}
  namespace exemplo{
    class Carro{
      public string modelo;
      public float totalCombustivel;
      public float totalKm;

      public Carro(){//Construtor
        modelo = "PADRÃO";
        totalCombustivel = 0;
        totalKm = 0;
      }
      public Carro(string m){
        modelo=m;
      } // outro Construtor
      public Carro(string m, float tc, float tk){
        modelo=m;
        totalCombustivel = tc;
        totalKm = tk;
      } // outro Construtor
    }
  }
