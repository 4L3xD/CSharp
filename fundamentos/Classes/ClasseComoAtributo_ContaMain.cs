using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Bem vindo a sua conta bancária!");

    Cliente usuario = new Cliente();
    usuario.nome = "Teste da Silva";
    usuario.rg = "12.345.678-0";

    Conta conta_usuario = new Conta();
    conta_usuario.titular = usuario;

    Console.WriteLine($"Titular: {conta_usuario.titular.nome}, RG: {conta_usuario.titular.rg}");
  }
}