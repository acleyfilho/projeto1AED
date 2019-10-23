using System;

public class Sensor{

  public int leitorArmario(){
    Random randNum = new Random();

    return randNum.Next(10);
  }

  public int leitorLixeira(){
    Random randNum = new Random();

    return randNum.Next(2);
  }
  
}