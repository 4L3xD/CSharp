using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Bem vindo à sua conta bancária!");

    // Criando uma nova instância de Conta na memória
    // c# alocará memória para guardar as infos da conta dentro da applicação
    // "New" referencia um apontamento para a o objeto na memória
    Conta usuario0 = new Conta();
    Conta usuario1 = new Conta();

    // Acessando o objeto
    usuario0.numero = 1;
    usuario0.titular = "Usuário C";
    usuario0.saldo = 100.02;

    Console.WriteLine($"Titular: {usuario0.titular}, Nº: {usuario0.numero}, Saldo: {usuario0.saldo}");

    Console.WriteLine("OPERAÇÕES:\n1. Saque\n2. Depósito\n3. Tranferência\n4. Extrato");
    Console.WriteLine("Digite a operação desejada:");
    string operacao = Console.ReadLine();

    switch (operacao)
    {
      case "1":
        Console.WriteLine("Digite o valor para saque:");
        double valor_saque = Double.Parse(Console.ReadLine());
        
        usuario0.Saque(valor_saque);
        Console.WriteLine($"Seu saldo é de {usuario0.saldo}.");
        break;
      
      case "2":
        Console.WriteLine("Digite o valor para depósito:");
        double valor_deposito = Double.Parse(Console.ReadLine());
        usuario0.Deposito(valor_deposito);
        
        Console.WriteLine($"Seu saldo é de {usuario0.saldo}.");
        break;

      case "3":
        Console.WriteLine("Digite o valor da transferência:");
        double valor_tranferencia = Double.Parse(Console.ReadLine());
        usuario0.Tranferencia(valor_tranferencia, usuario1);

        Console.WriteLine($"Saldo0: {usuario0.saldo}, Saldo1: {usuario1.saldo}");
        break;

      case "4":
        Console.WriteLine($"\n         EXTRATO:         \n");
        Console.WriteLine($"");
        break;
    }
  }
}