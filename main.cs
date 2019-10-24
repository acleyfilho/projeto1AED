using System;
using System.IO;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
    
    Console.Clear();

    //Cadastro da pessoa
    string nome;
    string senha;
    string telefone;
    string email;

    Console.WriteLine("CADASTRO INICIAL\n");

    Console.WriteLine("Digite seu nome: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite sua senha: ");
    senha = Console.ReadLine();

    Console.WriteLine("Digite seu telefone: ");
    telefone = Console.ReadLine();

    Console.WriteLine("Digite seu email: ");
    email = Console.ReadLine();

    Pessoa cadastro = new Pessoa(nome, senha, telefone, email);
    Console.Clear();

    //Menu
    string menu;
    bool repetir = true;
    int i = 0;

    Armario armario = new Armario();
    Item item = new Item();

    while(repetir == true){

      Console.WriteLine(" ");

      Console.WriteLine("╔═════════════MENU DE OPÇÕES═════════════╗    ");

      Console.WriteLine("║ 1 - DADOS DO USUARIO                   ║    ");

      Console.WriteLine("║                                        ║    ");

      Console.WriteLine("║ 2 - CADASTRO DE ITENS                  ║    ");

      Console.WriteLine("║                                        ║    ");

      Console.WriteLine("║ 3 - CHECAR ARMARIO                     ║    ");

      Console.WriteLine("║                                        ║    ");

      Console.WriteLine("║ 4 - JOGAR ITEM NO LIXO                 ║    ");

      Console.WriteLine("║                                        ║    ");

      Console.WriteLine("║ 5 - LIMPAR CONSOLE                     ║    ");
      
      Console.WriteLine("║                                        ║    ");

      Console.WriteLine("║ 6 - SAIR                               ║    ");

      Console.WriteLine("╚════════════════════════════════════════╝    ");

      Console.WriteLine(" ");

      Console.Write("Escolha uma opção: ");

      menu = Console.ReadLine();
      Console.Clear();
      Console.WriteLine(" ");

      //Opções do menu
      switch(menu){

        //Mostra os dados de cadastro do usuario
        case "1":
        cadastro.SaidaCadastro(cadastro);
        break;

        //Cadastro dos itens
        case "2":
        item.EscreverItem();
        break;

        //Lê lista de itens e adciona ao armario
        case "3":
        if(i == 0){
          armario.AdicionarItens();
          armario.SaidaLista();
          i++;
        }else{
          armario.SaidaLista();
        }
        break;

        case "4":
        Console.WriteLine("Item para o lixo...");
        break;

        case "5":
        Console.Clear();
        break;

        case "6":
        Console.WriteLine("Saindo...");
        repetir = false;
        break;

        default:
        Console.WriteLine("Opção invalida...");
        break;
      }
    }
    
  }
}