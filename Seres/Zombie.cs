using System.Data;
using rpgSerVivo;
using rpgTipoZombie;

namespace rpgZombie;

public class Zombie : SerVivo
{
    private TipoZombie Tipo {get; set;}

    public Zombie(int vidamaxima, int vida, int ataque, int defesa, TipoZombie tipo) : base(vidamaxima, vida, ataque, defesa)
    {
        this.Tipo = tipo;
    }

    private void CriarZombies()
    {
        //zombies
        Zombie zombieComum = new Zombie(80, 80, 15, 10, TipoZombie.Comum);
        Zombie zombieJumper = new Zombie(100, 100, 30, 20, TipoZombie.Especial);
        Zombie zombieTank = new Zombie(150, 150, 45, 35, TipoZombie.Especial);
    }
}