using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Bem vindo a sua conta bancária!");

    Conta conta_usuario = new Conta();
    conta_usuario.Numero = 1; 
    conta_usuario.Saldo = 200.01d;
    
    Console.WriteLine($"Numero: {conta_usuario.Numero}, Saldo: {conta_usuario.Saldo}");
  }
}