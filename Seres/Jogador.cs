using System.Runtime.Intrinsics.Arm;
using rpgArma;
using rpgInventario;
using rpgPessoa;

namespace rpgJogador;

public class Jogador : Pessoa
{
    private Inventario Inventario {get; set;}
    public Arma? ArmaEquipada {get; private set;} = null;

    public Jogador(int vidamaxima, int vida, int ataque, int defesa, String nome, Arma? armaequipada) : base(vidamaxima, vida, ataque, defesa, nome)
    {
        this.Inventario = new Inventario(10);
        this.ArmaEquipada = armaequipada;
    }

    public void CriaJogador()
    {
        String nome = "Fulaninho";
        Jogador jogador = new Jogador(100, 100, 30, 20, nome, null);
    }
}