using System.Runtime.Intrinsics.Arm;
using rpgArma;
using rpgInventario;
using rpgPessoa;
using rpgMissao;
using rpgLocal;
using rpgConsumivel;

namespace rpgJogador;

public class Jogador : Pessoa
{
    public Inventario Inventario {get; private set;}
    public Arma? ArmaEquipada {get; set;} = null;
    public Boolean BonusDesvio {get; set;} = false;
    public Boolean MochilaEquipada {get; set;} = false;
    public Boolean ColeteEquipado {get; set;} = false;
    public Missao? MissaoAtual {get; set;}
    public Local LocalAtual {get; set;}

    public Jogador(int vidamaxima, int vida, int ataque, int defesa, int agilidade, String nome, Local localatual) : base(vidamaxima, vida, ataque, defesa, agilidade, nome)
    {
        this.Inventario = new Inventario(10);
        this.LocalAtual = localatual;
    }
    public void EquiparArma(Arma arma)
    {
        this.ArmaEquipada = arma;
    }
    public void SeCurar(Consumivel consumivel)
    {
        this.Vida = Math.Min(Vida + consumivel.QtdVidaRecuperada, VidaMaxima);      
    }
}