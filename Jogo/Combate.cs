using rpgArma;
using rpgJogador;
using rpgSerVivo;
using rpgTipoArma;
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
    private void IniciarCombate()
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
    }
    private void Menu()
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine("[1] - Atacar");
        Console.WriteLine("[2] - Desviar");
        Console.WriteLine("[3] - Equipar Arma");
        Console.WriteLine("[4] - Recarregar");
        Console.WriteLine("-----------------------");
        Console.WriteLine("--> ");
    }
    private void TurnoJogador()
    {
        Menu();
        int opcao = Convert.ToInt32(Console.ReadLine());
        opcoesMenu escolha = (opcoesMenu)opcao;

        switch(escolha)
        {
            case opcoesMenu.Atacar:
                if (Jogador.ArmaEquipada.TemMunicao())
                {
                    Jogador.ArmaEquipada.GastarMunicao();
                    Zombie.TomarDano(CalcularDano(Jogador.ArmaEquipada, Jogador, Zombie));
                }
                Console.WriteLine("Você atacou o zombie!");
                break;
            case opcoesMenu.Desviar:
                if(TentarDesviar(Jogador, Zombie))
                {
                    Console.WriteLine("Você desviou do ataque!");
                }
                else
                {
                    Jogador.TomarDano(CalcularDano(null, Zombie, Jogador));
                    Console.WriteLine("Você não conseguiu desviar!");
                }
                break;
            case opcoesMenu.EquiparArma:
                Console.WriteLine("Qual arma deseja equipar?");
                break;
            case opcoesMenu.Recarregar:
                Jogador.ArmaEquipada?.Recarregar(Jogador.ArmaEquipada);
                break;
        }

    }
    private void TurnoZombie()
    {
        
    }
    private int CalcularDano(Arma arma, SerVivo atacante, SerVivo defensor)
    {
        int dano = atacante.Ataque;

        if(arma != null)
        {
            dano += arma.Dano; 
        }

        dano -= defensor.Defesa;

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