namespace rpgSerVivo;

public class SerVivo
{
    private int VidaMaxima {get; set;}
    private int Vida {get; set;}
    private int Ataque {get; set;}
    private int Defesa {get; set;}

    public SerVivo(int vidamaxima, int vida, int ataque, int defesa)
    {
        this.VidaMaxima = vidamaxima;
        this.Vida = vida;
        this.Ataque = ataque;
        this.Defesa = defesa;
    }

    public void TomarDano(int dano)
    {
        Vida -= dano;
    }
    public Boolean EstaVivo()
    {
        if (Vida <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}