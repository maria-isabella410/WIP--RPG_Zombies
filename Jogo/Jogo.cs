using rpgJogador;
using rpgLocal;

namespace rpgJogo;

public class Jogo
{
    private Jogador Jogador {get; set;}
    private Local LocalAtual {get; set;}
    private Random random {get; set;} = new Random();
    private Boolean emExecucao {get; set;}

    public Jogo(Jogador jogador, Local localatual)
    {
        this.Jogador = jogador;
        this.LocalAtual = localatual;
    }
}