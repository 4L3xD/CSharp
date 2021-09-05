using System;

class Program
{
  class Aula
  {
    public string nome;
    public string data;
    public string linguagem;
    public string xp;
    public bool kid;
    public string horario;

    public Aula(string modelNome, string modelData, string  modelLinguagem, string modelXp, bool modelKid, string  modelHorario)
    {
      nome = modelNome;
      data = modelData;
      linguagem = modelLinguagem;
      xp = modelXp;
      kid = modelKid;
      horario = modelHorario;
    }

  }
  static void Main(string[] args)
  {
    Aula Experimental = new Aula("Alê", "05/09/2021", "C#",   "intermediário", false, "09:00");

    Console.WriteLine($"Alune {Experimental.nome} foi cadastrado em {Experimental.data} às {Experimental.horario}, cursando a linguagem de programação {Experimental.linguagem} no nível {Experimental.xp}.\nAula adaptada para crianças? {Experimental.kid}");
  }

}