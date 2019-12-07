using System;

class conta{
  private string titular;
  private string numero;
  private float saldo;

  public conta(string titular, string n){
    this.titular = titular;
    this.numero = n;
    this.saldo = 0f;
  }

  //sacar
  public bool Sacar(float vlr_saque){
    if (saldo >= vlr_saque && vlr_saque>0){
      saldo -= vlr_saque;
      return true;
    }
    return false;
  }
  
  //depositar
  public bool Depositar (float vlr_deposito){
    if (vlr_deposito > 0){
      saldo += vlr_deposito;
      return true;
    }
    return false;
  }
  public string getSaldo(){
    return string.Format("R${0}", saldo);
  }
}
