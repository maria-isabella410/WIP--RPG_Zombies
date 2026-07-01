using System.Runtime.Intrinsics.Arm;
using rpgArma;
using rpgInventario;
using rpgPessoa;

namespace rpgJogador;

public class Jogador : Pessoa
{
    private Inventario Inventario {get; set;}
    private Arma ArmaEquipada;

    public Jogador(int vidamaxima, int vida, int ataque, int defesa, String nome, Inventario inventario, Arma armaequipada) : base(vidamaxima, vida, ataque, defesa, nome)
    {
        this.Inventario = inventario;
        this.ArmaEquipada = armaequipada;
    }
}