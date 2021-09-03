using: System;
namespace DIO.Jogadores
{
    public class Jogadores: EntidadeBase
    {
        private Sexo Sexo {get; set;}
        private string Jogador {get;set;}
        private int Idade {get; set;}
        private string Time {get; set;}
        private string Nacionalidade {get; set;}
        private bool Ativade {get; set;}

        public Jogadores (int id,  Sexo sexo, Jogador jogador, int idade, string time, string nacionalidade)
    {
        this.Id = id;
        this.Jogador = jogador;
        this.Sexo = sexo;
        this.Idade = idade;
        this.Time = time;
        this.Nacionalidade = nacionalidade;
        this.Atividade = false
    }
    public override string ToString ()
    {
        string retorno = "";
        retorno += "Sexo" + this.Sexo + Environment.NewLine;
        retorno += "Jogador" + this.Jogador + Environment.NewLine;
        retorno += "Time" + this.Time + Environment.NewLine;
        retorno += "Nacionalidade" + this.Nacionalidade + Environment.NewLine;
        retorno += "Idade" + this.Idade + Environment.NewLine;
        return retorno;
    }
    public string retornaJogador ()
    {
        return this.Jogador;
    }
    
        internal int retornaId ()
      {
          return this.Id;
      }
      public void Atividade () {
      this.Atividade = true;
     }
}
