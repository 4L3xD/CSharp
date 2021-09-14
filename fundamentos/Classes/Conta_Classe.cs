using System;

class Conta
{
  public int numero;
  public string titular;
  public double saldo;

  // Com o "void" na declaração do método ñ é necessário ter return
  public void Saque(double retirada)
  {
    // "this" p/ acessar a referência em que um método foi invocado
    if (this.saldo > 0 && retirada <= this.saldo)
    {
      this.saldo -= retirada;
    }
    else
    {
      Console.WriteLine("Sem saldo suficiente!");
    }
  }

  public void Deposito(double valor)
  {
    this.saldo += valor;
  }

  // "void" pode ser substituído pelo tipo retornado, exigindo um return na função. O return() sai do método quando executado.
  public bool Transferencia(double valor, Conta destino)
  {
    if (this.saldo >= valor)
    {
      destino.saldo += valor;
      this.saldo -= valor;
    }
    return true;
  }

}