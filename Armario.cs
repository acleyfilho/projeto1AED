using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Armario{

  List<Item> itens = new List<Item>();

  Sensor sensor = new Sensor();

  public void AdicionarItens(){
    
    FileStream meuArq = new FileStream("itens.txt", FileMode.Open, FileAccess.Read);

    StreamReader sr = new StreamReader(meuArq, Encoding.UTF8);

    while(!sr.EndOfStream){

      string str = sr.ReadLine();
      string strAux  = str;
      int numeroAux;
      string nomeAux;

      nomeAux = String.Join("", System.Text.RegularExpressions.Regex.Split(str, @"[\d| -]"));
      numeroAux = int.Parse(String.Join("", System.Text.RegularExpressions.Regex.Split(strAux, @"[^\d]")));
      
      itens.Add(new Item() {nome = nomeAux, qtdMin = numeroAux, qtdAtual = sensor.leitorArmario()});
    }
    sr.Close();
    meuArq.Close();
  }

  public void MostrarLista(){
     foreach (Item i in itens){

      string resposta;
      int qtdMin;
      int qtdAtual;
      int qtdDesejada;

      qtdAtual = i.getQtdAtual();
      qtdMin = i.getQtdMin();

      if(qtdAtual > qtdMin){
        Console.WriteLine(i);
      }
      else{
        Console.WriteLine(i);
        Console.WriteLine("Esse item precisa de reposição!");
        Console.Write("Dejesa comprar esse item(S|N)? ");
        resposta = Console.ReadLine();
        if(resposta == "S" || resposta == "s"){
          Console.WriteLine("Digite a quantidade que deseja comprar:");
          qtdDesejada = int.Parse(Console.ReadLine());

          qtdAtual = qtdAtual + qtdDesejada;

          i.setQtdAtual(qtdAtual);

          Console.WriteLine("Quantidade comprada com sucesso!");
          Console.WriteLine(i);
        }
        else{
          Console.WriteLine("Esse item não tera reposição!");
        }
      }
    }
  }

  public void SaidaLista(){
    Console.WriteLine("\n║║║║║║║║║║║║║═>SEU ARMARIO<═║║║║║║║║║║║║║║");
    MostrarLista();
    Console.WriteLine("\n------------------------------------------");
  }
}