using System;
using System.IO;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
    
    //Cadastro da pessoa
    string nome;
    string senha;
    string telefone;
    string email;

    Pessoa cadastro = new Pessoa();

    Console.WriteLine("Digite seu nome:");
    nome = Console.ReadLine();

    Console.WriteLine("Digite sua senha:");
    senha = Console.ReadLine();

    Console.WriteLine("Digite seu telefone:");
    telefone = Console.ReadLine();

    Console.WriteLine("Digite seu email:");
    email = Console.ReadLine();

    cadastro.setNome(nome);
    cadastro.setSenha(senha);
    cadastro.setTelefone(telefone);
    cadastro.setEmail(email);

    cadastro.SaidaCadastro(cadastro);

    //Cadastro dos itens
    Item item = new Item();
    item.EscreverItem();

    Armario armario = new Armario();

    armario.AdicionarItens();
    armario.SaidaLista();

  }
}