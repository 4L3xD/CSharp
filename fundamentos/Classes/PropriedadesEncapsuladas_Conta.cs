class Conta
{
  //Encapsulamento
  //"Atributos	 e	 métodos	 	PRIVATE		 são	 acessados	 apenas	 pela	 própria	 classe"
  private int numero;
  private double saldo;

  /*public int Numero
  {
    get
    {
      return this.numero;
    }
    set
    {
      this.numero = value;
    }
  }*/
  
  //Auto-implemented properties
  public int Numero { get; set; }
  /*public int Numero { get; private set; }*/
  public double Saldo { get; set; }

  //https://www.caelum.com.br/apostila/apostila-csharp-orientacao-objetos.pdf
}