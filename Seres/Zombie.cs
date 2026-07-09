using System.Data;
using rpgSerVivo;
using rpgTipoZombie;

namespace rpgZombie;

public class Zombie : SerVivo
{
    private TipoZombie Tipo {get; set;}

    public Zombie(int vidamaxima, int vida, int ataque, int defesa, int agilidade, TipoZombie tipo) : base(vidamaxima, vida, ataque, defesa, agilidade)
    {
        this.Tipo = tipo;
    }
}