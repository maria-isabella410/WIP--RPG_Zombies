using System.Runtime.Intrinsics.Arm;
using rpgArma;
using rpgInventario;
using rpgPessoa;

namespace rpgJogador;

public class Jogador : Pessoa
{
    private Inventario Inventario {get; set;}
    private Arma? ArmaEquipada {get; set;} = null;

    public Jogador(int vidamaxima, int vida, int ataque, int defesa, String nome, Arma? armaequipada) : base(vidamaxima, vida, ataque, defesa, nome)
    {
        Inventario inventario = new Inventario(null, 10);
        this.ArmaEquipada = armaequipada;
    }
}