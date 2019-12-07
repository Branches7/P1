using System;
using System.IO;
using System.Collections.Generic;

class Empreendedor {
  private bool id_Empreendedor;
  private string nome;
  private string cnpj;
  private string telefone;
  private string endereço;
  StreamWriter i;

  public Empreendedor(string n, string c, bool i, string t, string e){
    nome = n;
    cnpj = c;
    id_Empreendedor = i;
    telefone = t;
    endereço = e;
  }
  public string getEndereço(){
    return endereço;
  }
}
