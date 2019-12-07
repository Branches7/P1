/*Conta
---------------
-Titular 
-Numero
-Saldo
Sacar
Depositar

---------------------------

ContaCorrente : Conta
 -TaxaMovimentacao

---------------------------

ContaPoupanca : Conta
-TaxaRendimento
*/


using System;

class MainClass {
  public static void Main (string[] args) {

    conta cc = new contacorrente("Eu", "1245", 0.49);
    conta cp = new contapoupanca("Eu", "1245", 0.03);

      conta[] contas = new conta[]{cc,cp};

        foreach(conta c in contas){
          Console.WriteLine(c.getSaldo());
        }

  }
}