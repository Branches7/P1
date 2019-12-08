/*
    Ao menos três classes;
    Cada classe precisará ter, ao menos, 3 métodos e 4 atributos significativos para a classe.
    Deverá trabalhar persistência de dados por meio de leitura e escrita de arquivos.
    verá promover uma integração das classes, por meio de relacionamentos ou listas de objetos
    modificadores de acesso devem estar adequados para garantir o encapsulamento dos métodos e atributos
    verá fazer uso de estruturas de dados aprendidas como listas, vetores ou matrizes.

O projeto terá a princípio 3 classe
Empreendedor: cnpj, nome telefone, id_empreendedor
Representante:telefone, e-mail, empresa Id_representade
Empresas:telefone , nome da empresa, e-mail
ID_empresa
*/
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    int Cadastrar;

      StreamWriter DataSet;
      StreamWriter Doador;
      StreamWriter Adotante;

      List<string> contaAdocao = new List<string>();
      List<string> contaDoacao = new List<string>();

      dataUser CadUser = new dataUser("Nome", "Telefone", "cidade","Email");

      Console.WriteLine ("Já possui cadastro? ");
      Console.WriteLine("Digite \n 1 - NÃO \n 2 - SIM");
      Cadastrar = int.Parse(Console.ReadLine());

      switch(Cadastrar){
        case 1:
            DataSet = File.AppendText("id_empreendedor.txt");
            Console.WriteLine("Digite seu Nome: \n");
            CadUser.Nome = Console.ReadLine().ToUpper();
            DataSet.WriteLine(CadUser.Nome);

            Console.WriteLine("Telefone para contato: \n");
            CadUser.Telefone = Console.ReadLine();
            DataSet.WriteLine(CadUser.Telefone);

            Console.WriteLine("Digite o nome da sua cidade: \n");
            CadUser.Localidade = Console.ReadLine().ToUpper();
            DataSet.WriteLine(CadUser.Localidade);

            Console.WriteLine("E-mail: \n");
            CadUser.Email = Console.ReadLine().ToUpper();
            DataSet.WriteLine(CadUser.Email);

            Console.WriteLine("Obrigado por se Cadastrar! ");


            DataSet.Close();
          break;
            
        case 2:
            string x;

            Console.WriteLine("Confirme seu telefone cadastrado: \n");
            x = Console.ReadLine();

            if(verifTel(x)) {
              
              Console.WriteLine("Telefone encontrado");

            } 
            else{

              Console.WriteLine("Telefone não encontrado");
              while(verifTel(x)== false){
                Console.WriteLine("Digite novamente: ");
                x = Console.ReadLine();
              }
            }

          break;

          }

  } 
}