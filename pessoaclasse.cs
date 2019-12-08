using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ExemploClasses
{
    class Pessoa
    {
        // 1. Atributos da classe
        private String nome;
        private String rg;
        private int idade;
 
        // 2. Métodos construtores
        public Pessoa() { }
 
        public Pessoa(String nome, String rg, int idade)
        {
            this.nome = nome;
            this.rg = rg;
            this.idade = idade;
        }
 
        //3. Métodos acessores
        public void setNome(String nome)
        {
            this.nome = nome;
        }
 
        public String getNome()
        {
            return this.nome;
        }
 
        public void setRg(String rg)
        {
            this.rg = rg;
        }
 
        public String getRg()
        {
            return this.rg;
        }
 
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
 
        public int getIdade()
        {
            return this.idade;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ExemploClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um objeto da classe Pessoa chamado p1.
            // Inicialmente o objeto é criado sem nenhuma informação.
            // As informações são adicionadas pelos métodos set.
            Pessoa p1 = new Pessoa();
            Console.WriteLine("digite o nome");
            string Nome = Console.ReadLine();
            p1.setNome(Nome);

            Console.WriteLine("digite a idade");
            int idade = int.Parse(Console.ReadLine());
            p1.setIdade(idade);
            bool maioridade = false;
            if (idade >= 18){
              maioridade = true;
            }

            p1.setRg("12.345-67");


 
            // Vamos exibir os valores na tela. Para isso usaremos
            // os métodos get.
            Console.WriteLine("Nome.: " + p1.getNome());
            Console.WriteLine("Rg...: " + p1.getRg());
            Console.WriteLine("Idade: " + p1.getIdade());
            Console.WriteLine("é maior de Idade: " + maioridade);
 
            // Pular duas linhas
            Console.WriteLine();
            Console.WriteLine();
 
            // Agora vamos criar um novo objeto p2 com os valores já inicializados.
            Pessoa p2 = new Pessoa("Maria", "33.444-55", 35);
 
            // Vamos exibir os dados na tela
            Console.WriteLine("Nome.: " + p2.getNome());
            Console.WriteLine("Rg...: " + p2.getRg());
            Console.WriteLine("Idade: " + p2.getIdade());
        }
    }
}
/*using System;

class MyString {
  public static void Main (string[] args) {

    bool LetraDigito();
    
    Console.WriteLine ("Hello World");
  }
}*/
