using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Armario{

  List<Item> itens = new List<Item>();

  Random randNum = new Random();

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

      itens.Add(new Item() {nome = nomeAux, qtdMin = numeroAux, qtdAtual = randNum.Next(10)});
    }
    sr.Close();
    meuArq.Close();
  }

  public void MostrarLista(){
    foreach (Item i in itens){

      Console.WriteLine(i);
    }
  }

  public void SaidaLista(){
    Console.WriteLine("\n||||||||->ARMARIO<-||||||||");
    MostrarLista();
    Console.WriteLine("\n----------------------------");
  }
}