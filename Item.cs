using System;
using System.IO;
using System.Text;

public class Item{

  public string nome;
  public int qtdMin;
  public int qtdAtual;

  public Item(){

    nome = "Nome";
    qtdMin = 0;
    qtdAtual = 0;
  }

  public Item(string n, int qm, int qa){

    nome = n;
    qtdMin = qm;
    qtdAtual = qa;
  }

  public string getNome(){
    return nome;
  }

  public void setNome(string n){
    nome = n;
  }

  public int getQtdMin(){
    return qtdMin;
  }

  public void setQtdMin(int qm){
    qtdMin = qm;
  }

  public int getQtdAtual(){
    return qtdAtual;
  }

  public void setQtdAtual(int qa){
    qtdAtual = qa;
  }

  public override string ToString(){
    return "\nItem: " + nome + "\nQuantidade Minima: " + qtdMin + "\nQuantida Atual: " + qtdAtual;
  }
  
  public void EscreverItem(){

    FileStream meuArq = new FileStream("itens.txt", FileMode.Open, FileAccess.Write);

    StreamWriter sw = new StreamWriter(meuArq, Encoding.UTF8);

    string str = string.Empty;
    string str2 = string.Empty;
    string resposta;
    bool repetir = true;
    
    while(repetir == true){

      Console.WriteLine("Deseja cadastrar algum item(S|N)?");
      resposta = Console.ReadLine();

      if(resposta == "S" || resposta == "s"){

        Console.WriteLine("Escreva o item que deseja:");
        str = Console.ReadLine();
        Console.WriteLine("Escreva a quantidade minima que deseja:");
        str2 = Console.ReadLine();
        
        sw.WriteLine(str+" - "+str2);
        
      }else{
        repetir = false;
      }
    } 

    sw.Close();
    meuArq.Close();
  }

  
    
}