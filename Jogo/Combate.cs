using rpgArma;
using rpgJogador;
using rpgSerVivo;
using rpgZombie;

namespace rpgCombate;

public class Combate
{   
    private Jogador Jogador {get; set;}
    private Zombie Zombie {get; set;}
    private Random random {get; set;}

    public Combate(Jogador jogador, Zombie zombie, Random random)
    {
        this.Jogador = jogador;
        this.Zombie = zombie;
        this.random = random;
    }
    public void IniciarCombate()
    {
        while(Jogador.EstaVivo() && Zombie.EstaVivo())
        {
            TurnoJogador();

            if(VerificarFim()) break;

            TurnoZombie();

            if(VerificarFim()) break;
        }
    }
    private enum opcoesMenu
    {
        Atacar = 1,
        Desviar = 2,
        EquiparArma = 3,
        Recarregar = 4,
        Info = 0
    }
    private void DivisaoDeLinha()
    {
        Console.WriteLine("-------------------------------");
    }

    private void StatusGeral()
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine($"Jogador: [{Jogador.Vida} / {Jogador.VidaMaxima}] HP");
        Console.WriteLine($"Zombie: [{Zombie.Vida} / {Zombie.VidaMaxima}] HP");
        Console.WriteLine("Arma equipada: " + Jogador.ArmaEquipada);
        if (Jogador.ArmaEquipada.PodeRecarregar())
        {
            Console.WriteLine($"Munição: [{Jogador.ArmaEquipada.Municao} / {Jogador.ArmaEquipada.CapacidadeMunicao}]");    
        }
    }
    private void Menu()
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine("[1] - Atacar");
        Console.WriteLine("[2] - Desviar");
        Console.WriteLine("[3] - Equipar Arma");
        Console.WriteLine("[4] - Recarregar");
        Console.WriteLine("[0] - Info");
        Console.WriteLine("-----------------------");
        Console.WriteLine("--> ");
    }
    private void TurnoJogador()
    {
        StatusGeral();

        Menu();

        int opcao = Convert.ToInt32(Console.ReadLine());
        
        opcoesMenu escolha = (opcoesMenu)opcao;

        if(escolha == opcoesMenu.Info)
        {
            DivisaoDeLinha();

            Console.WriteLine("Ao escolher [1] Atacar, será seu Ataque - a Defesa do zombie. Você não pode atacar sem uma arma em mãos. O zombie vai tentar desviar.");
            
            Console.WriteLine("Ao escolher [2] Desviar, você tenta desviar e, se conseguir, diminui pela metade a Defesa do zombie. Mas se não conseguir, você tomará 1/3 a mais de dano.");
            
            Console.WriteLine("Ao escolher [3] Equipar Arma, você escolhe uma de suas armas para empunhar.");
            
            Console.WriteLine("Ao escolher [4] Recarregar, você recarrega a arma que tem em mãos.");

            return;
        }

        int danoTomado = 0;

        switch(escolha)
        {
            case opcoesMenu.Atacar:
                if(Jogador.ArmaEquipada == null)
                {
                    Console.WriteLine("Você está sem armas!");

                    break;
                }
                if (Jogador.ArmaEquipada.TemMunicao())
                {
                    Jogador.ArmaEquipada.GastarMunicao();

                    danoTomado = CalcularDano(Jogador.ArmaEquipada, Jogador, Zombie);
                        
                    if(Jogador.BonusDesvio)
                    {
                        Zombie.TomarDano(danoTomado + (danoTomado / 2));
                        Jogador.BonusDesvio = false;
                    }
                    else
                    {
                        Zombie.TomarDano(danoTomado);
                    }

                    DivisaoDeLinha();

                    Console.WriteLine("Você atacou o zombie!");

                    Console.WriteLine("Você deu " + danoTomado + " de dano!");

                    Console.WriteLine($"A vida do zombie é: [{Zombie.Vida} / {Zombie.VidaMaxima}]");

                    DivisaoDeLinha();
                }
                else
                {
                    DivisaoDeLinha();

                    Console.WriteLine("Essa arma não está carregada, então você não pode usá-la!");
                    
                    DivisaoDeLinha();
                }

                break;
            case opcoesMenu.Desviar:
                if(TentarDesviar(Jogador, Zombie))
                {
                    DivisaoDeLinha();

                    Console.WriteLine("Você desviou do ataque e garantiu 50% a mais de dano no próximo ataque!");

                    DivisaoDeLinha();

                    Jogador.BonusDesvio = true;
                }
                else
                {
                    danoTomado = CalcularDano(null, Zombie, Jogador);

                    Jogador.TomarDano(danoTomado + (danoTomado / 3));

                    DivisaoDeLinha();

                    Console.WriteLine("Você não conseguiu desviar!");

                    Console.WriteLine("Você tomou " + danoTomado + " de dano! (1/3 a mais aplicado).");
                
                    DivisaoDeLinha();
                }

                break;
            case opcoesMenu.EquiparArma:
                DivisaoDeLinha();

                Console.WriteLine("Qual arma deseja equipar?");

                List<Arma> armas = Jogador.Inventario.ListarArmas();

                for(int i = 0; i < armas.Count; i++)
                {
                    Console.WriteLine($"[{i + 1}] {armas[i].Nome}");
                }

                DivisaoDeLinha();

                Console.WriteLine("--> ");

                int escolhaArma = Convert.ToInt32(Console.ReadLine());

                if(escolhaArma < 0 || escolhaArma > armas.Count)
                {
                    Console.WriteLine("Entrada inválida");
                }
                else
                {
                    Jogador.EquiparArma(armas[escolhaArma - 1]);

                    Console.WriteLine("Você equipou: " + Jogador.ArmaEquipada);
                }

                break;
            case opcoesMenu.Recarregar:
                if(Jogador.ArmaEquipada != null && Jogador.ArmaEquipada.PodeRecarregar())
                {
                    Jogador.ArmaEquipada.Recarregar(Jogador.ArmaEquipada);
                }
                else
                {
                    DivisaoDeLinha();

                    Console.WriteLine("Não é possível recarregar!");

                    DivisaoDeLinha();
                }

                break;
            default:
                DivisaoDeLinha();

                Console.WriteLine("Entrada inválida!");

                DivisaoDeLinha();

                break;
        }

    }
    private void TurnoZombie()
    {
        int danoTomado = 0;

        Console.WriteLine("O zombie te atacou!");

        danoTomado = CalcularDano(null, Zombie, Jogador);

        Jogador.TomarDano(danoTomado);

        Console.WriteLine("Você tomou " + danoTomado + " de dano!");

        Console.WriteLine($"Sua vida atual é: [{Jogador.Vida} / {Jogador.VidaMaxima}]");
    }
    private int CalcularDano(Arma arma, SerVivo atacante, SerVivo defensor)
    {
        int dano = atacante.Ataque;

        if(arma != null)
        {
            dano += arma.Dano; 
        }

        dano -= defensor.Defesa;

        //variabilidade de dano para nao ficar estatico
        dano += random.Next(-3, 4);

        return Math.Max(1, dano);
    }
    private Boolean VerificarFim()
    {
        if(!Jogador.EstaVivo() || !Zombie.EstaVivo())
        {
            return true;
        }
        else return false;
    }
    private Boolean TentarDesviar(SerVivo defensor, SerVivo atacante)
    {
        int chance = 20 + defensor.Agilidade - atacante.Agilidade;

        chance = Math.Clamp(chance, 5, 80);

        return random.Next(100) < chance;
    }
    
}