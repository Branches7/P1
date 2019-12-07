using System.IO;
using System.Collections.Generic;

  class Representante {
    private string nome;
    private string telefone;
    private string setorAtua;
    
    public Representante(bool i, string n, string t, string e, string s) {
      id_Representante = i;
      nome = n;
      telefone = t;
      setorAtua = s; 
    }
    public bool validar_Empreendedor (string x){
      StreamReader i;
      i = File.OpenText("id_empreendedor.txt");
      string id_valida=  i.ReadLine();
      if(id_valida == x){
        return true;
      }
      else{
        return false;
      }
    }
  }