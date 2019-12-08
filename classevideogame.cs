using System;

namespace exemplo1 {

  class MainClass {
    public static void Main (string[] args) {
      
      Videogame xbox = new Videogame();
      xbox.Ligar();
    }
  }
}

using System;

namespace exemplo1{

  class Videogame {
      private string fabricante;
      private string modelo;
      private int geração;

      public string getModelo(){
        return modelo;
      }
      public void setModelo(string x){
        modelo = x;
      }
      public void Ligar(){
        Console.WriteLine("Olá Daniel");
      }
  }
}