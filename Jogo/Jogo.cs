using rpgItem;
using rpgJogador;
using rpgLocal;
using rpgInventario;

namespace rpgJogo;

public class Jogo
{
    private Jogador Jogador {get; set;}
    private Local LocalAtual {get; set;}
    private Boolean emExecucao {get; set;}

    public Jogo(Jogador jogador, Local localatual)
    {
        this.Jogador = jogador;
        this.LocalAtual = localatual;
    }
}