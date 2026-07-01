using rpgArma;
using rpgConsumivel;
using rpgItem;
using rpgJogador;
using rpgTipoArma;
using rpgInventario;
using rpgZombie;

namespace MainProgram;

public class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Meu RPG de zombies! :)");

        //jogador
        String nome = "Fulaninho";
        Jogador jogador = new Jogador(100, 100, 30, 20, nome, null);

        //consumiveis
        Consumivel bandaid = new Consumivel("Band-Aid", "Recupera um pouco da sua vida.", 20);
        Consumivel kitmed = new Consumivel("Kit Médico", "Recupera grande parte da sua vida", 70);
        Consumivel spray = new Consumivel("Spray", "Recupera parcialmente sua vida", 40);

        //armas
        Arma pistola = new Arma("Pistola", "Uma arma eficiente (Causa 25 de dano)", 25, TipoArma.Pistola, 12, 12);
        Arma shotgun = new Arma("Shotgun", "Uma arma poderosa que causa um bom estrago (causa 50 de dano)", 50, TipoArma.Shotgun, 8, 8);
        Arma faca = new Arma("Faca", "Uma arma pequena, mas eficiente (Causa 10 de dano)", 10, TipoArma.Faca, null, null);

        //zombies
    }
}