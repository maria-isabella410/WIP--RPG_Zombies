using System.Runtime.Intrinsics.Arm;
using rpgArma;
using rpgInventario;
using rpgPessoa;

namespace rpgJogador;

public class Jogador : Pessoa
{
    public Inventario Inventario {get; private set;}
    public Arma? ArmaEquipada {get; set;} = null;
    public Boolean BonusDesvio {get; set;} = false;

    public Jogador(int vidamaxima, int vida, int ataque, int defesa, int agilidade, String nome, Arma? armaequipada) : base(vidamaxima, vida, ataque, defesa, agilidade, nome)
    {
        this.Inventario = new Inventario(10);
        this.ArmaEquipada = armaequipada;
    }

    public void CriaJogador()
    {
        String nome = "Fulaninho";
        Jogador jogador = new Jogador(100, 100, 30, 20, 25, nome, null);
    }
    public void EquiparArma(Arma arma)
    {
        this.ArmaEquipada = arma;
    }
}