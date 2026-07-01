using rpgSerVivo;

namespace rpgPessoa;

public class Pessoa : SerVivo
{
    private String Nome {get; set;}

    public Pessoa(int vidamaxima, int vida, int ataque, int defesa, String nome) : base(vidamaxima, vida, ataque, defesa)
    {
        this.Nome = nome;
    }
}