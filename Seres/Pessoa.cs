using rpgSerVivo;

namespace rpgPessoa;

public class Pessoa : SerVivo
{
    public String Nome {get; private set;}

    public Pessoa(int vidamaxima, int vida, int ataque, int defesa, int agilidade, String nome) : base(vidamaxima, vida, ataque, defesa, agilidade)
    {
        this.Nome = nome;
    }
}